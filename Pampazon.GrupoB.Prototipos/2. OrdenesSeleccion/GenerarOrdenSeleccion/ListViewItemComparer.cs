using System.Collections;
using System.ComponentModel.Design.Serialization;

namespace Pampazon.GrupoB.Prototipos
{
    public class ListViewItemComparer : IComparer
    {
        private int col;
        private SortOrder order;

        public ListViewItemComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }

        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            string[] xParts = ((ListViewItem)x).SubItems[col].Text.Split('-');
            string[] yParts = ((ListViewItem)y).SubItems[col].Text.Split('-');

            for (int i = 0; i < xParts.Length; i++)
            {
                int xVal = int.Parse(xParts[i]);
                int yVal = int.Parse(yParts[i]);

                int comparisonResult = xVal.CompareTo(yVal);
                if (comparisonResult != 0)
                {
                    return order == SortOrder.Ascending ? comparisonResult : -comparisonResult;
                }
            }

            return 0;
        }
    }
}