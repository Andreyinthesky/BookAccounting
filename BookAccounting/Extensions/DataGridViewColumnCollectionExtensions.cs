using System.Collections.Generic;
using System.Windows.Forms;

namespace BookAccounting.Extensions
{
    public static class DataGridViewColumnCollectionExtensions
    {
        public static IEnumerable<DataGridViewColumn> AsEnumerable(this DataGridViewColumnCollection collection)
        {
            foreach (var item in collection)
            {
                yield return (DataGridViewColumn) item;
            }
        }
    }
}