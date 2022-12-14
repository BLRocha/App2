using System.Data;
using System.Reflection;

namespace App2.Helpers
{
    public class PreencherDataSet<T>
    {
        private PropertyInfo[] _propertyInfo;
        
        private IList<T> _tableList = new List<T>();

        private DataSet _dataSet = new DataSet();
        private DataTable _dataTable = new DataTable();
        public PreencherDataSet(IList<T> Table)
        {
            if (Table != null)
            {
                _tableList = Table;
                _propertyInfo = typeof(T).GetProperties();
                _tableColumns();
            }
        }

        private void _tableColumns()
        {
            foreach (PropertyInfo prop in _propertyInfo)
            {
                _dataTable.Columns.Add(prop.Name.Trim());
            }
            _tableRows();
        }

        private void _tableRows()
        {
            for (int i = 0; i < _tableList.Count; i++)
            {
                DataRow row = _dataTable.NewRow();
                foreach (var prop in _propertyInfo)
                {
                    row[prop.Name.ToString()] = prop.GetValue(_tableList[i]);
                }
                _dataTable.Rows.Add(row);
            }
        }

        public DataSet GetDataSet()
        {
            _dataSet.Tables.Add(_dataTable);
            return _dataSet;
        }

        public DataTable GetDataTable()
        {
            return _dataTable;
        }
    }
}
