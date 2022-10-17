using System.Data;

namespace App2.Helpers
{
    public abstract class SplitDataTable
    {
        public static DataSet SplitTable(DataTable tableOrigem, int numTable = 0)
        {
            List<DataTable> tables = new List<DataTable>();
            DataSet dataSet = new DataSet();
            if (tableOrigem.Rows.Count <= numTable || numTable == 0)
            {
                dataSet.Tables.Add(tableOrigem);
                return dataSet;
            }
            int rowsCount = tableOrigem.Rows.Count;
            int tableNum = (rowsCount / numTable) + (rowsCount % numTable != 0 ? 1 : 0);

            int index = 0;

            for (int i = 0; i < tableNum; i++)
            {
                DataTable newDt = tableOrigem.Clone();
                newDt.TableName = "Table" + (i+1);
                newDt.Clear();
                for (int j = 0; j < numTable && index < rowsCount; j++)
                {
                    DataRow newRow = newDt.NewRow();
                    newRow.ItemArray =tableOrigem.Rows[index].ItemArray;
                    newDt.Rows.Add(newRow);
                    index++;
                }
                tables.Add(newDt);
                dataSet.Tables.Add(tables[i]);
            }
            return dataSet;
        }
    }
}
