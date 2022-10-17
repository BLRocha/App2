using App2.Models;
using System.Data;
using System.Reflection;

namespace App2.Helpers
{
    public class FetchDataTable<TClassType>
    {

        private int rowCount = 0;
        private int pageCount = 0;
        private PropertyInfo[]? _propertyInfo;
        private IList<TClassType> pages = new List<TClassType>();
        private DataSet _dataSet = new DataSet();

        public FetchDataTable(IList<TClassType> pages)
        {
            if (pages.Count > 0)
            {
                rowCount = pages.Count;
                pageCount = (rowCount / 10) + (rowCount % 10 != 0 ? 1 : 0);

                _propertyInfo = typeof(TClassType).GetProperties();

                this.pages = pages;
            }
        }

        public DataSet GetDataTables()
        {
            for (int i = 0; i < pageCount; i++)
            {
                var items = pages.Skip( i == 0 ? 0 : i * 10).Take(10);

                IList<TClassType> b = items.Cast<TClassType>().ToList();
                var a = new PreencherDataSet<TClassType>(b).GetDataTable();
                _dataSet.Tables.Add(a);
            }
            return _dataSet;
        }
    }
}
