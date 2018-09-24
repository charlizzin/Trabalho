using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorDados
{
    public class MapperFields<TEntity> where TEntity : class, new()
    {
        // Faço uma varreruda na propriedade do objeto, verificando se contem MapField como atributo
        // Se existir, crio uma lista desses campos que foram criados no objeto
        // Ex: [MapFieldName("first_name", "name_user", "name")], retornará 3 supostos campos que existem no banco
        private static IEnumerable<string> GetFieldNameFromAttribute(Type type, string propertyName)
        {
            var property = type.GetProperty(propertyName)
                .GetCustomAttributes(false)
                .FirstOrDefault(p => p.GetType().Name.Equals("MapFieldNameAttribute"));

            return property != null ? ((MapFieldNameAttribute)property).AttributeNames : new List<string>();
        }

        // Pegará o valor do DataRow e atribuirá na classe que desejo fazer o parse
        private static void Mapper(Type type, DataRow row, PropertyInfo prop, object entity)
        {
            var fields = GetFieldNameFromAttribute(type, prop.Name);

            foreach (var field in fields)
            {
                if (string.IsNullOrWhiteSpace(field) || !row.Table.Columns.Contains(field))
                    continue;

                if (row[field] == DBNull.Value)
                    continue;

                prop.SetValue(entity, row[field], null);

                break;
            }
        }

        // Fará o parse de uma linha completa do DataTable para um objeto
        public TEntity Map(DataRow dataRow)
        {
            var properties = typeof(TEntity).GetProperties()
                .Where(x => x.GetCustomAttributes(typeof(MapFieldNameAttribute), true).Any())
                .ToList();

            var entity = new TEntity();

            foreach (var prop in properties)
            {
                Mapper(typeof(TEntity), dataRow, prop, entity);
            }

            return entity;
        }

        // Estou reutilizando o método principal Map(DataRow dataRow) que faz o parse de somente um objeto
        // Percorro todo o DataTable, selecionando linha a linha e convertendo para objeto
        // Por fim, retorno uma lista de objetos já convertida
        public IEnumerable<TEntity> Map(DataTable dataTable)
        {
            return dataTable.Rows.Cast<DataRow>().Select(Map).ToList();
        }
    }
}
