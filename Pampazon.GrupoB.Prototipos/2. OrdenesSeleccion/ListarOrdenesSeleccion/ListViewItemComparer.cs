using System.Collections;
using System.ComponentModel.Design.Serialization;

namespace Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion
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

            // Asegúrate de comparar todas las partes relevantes.
            int maxLength = Math.Max(xParts.Length, yParts.Length);
            for (int i = 0; i < maxLength; i++)
            {
                // Usa un valor predeterminado si una de las partes es más corta.
                string xPart = i < xParts.Length ? xParts[i] : "0";
                string yPart = i < yParts.Length ? yParts[i] : "0";

                if (int.TryParse(xPart, out int xVal) && int.TryParse(yPart, out int yVal))
                {
                    int comparisonResult = xVal.CompareTo(yVal);
                    if (comparisonResult != 0)
                    {
                        return order == SortOrder.Ascending ? comparisonResult : -comparisonResult;
                    }
                }
                else
                {
                    // Maneja el caso donde las partes no son números válidos.
                    int stringComparisonResult = string.Compare(xPart, yPart, StringComparison.Ordinal);
                    if (stringComparisonResult != 0)
                    {
                        return order == SortOrder.Ascending ? stringComparisonResult : -stringComparisonResult;
                    }
                }
            }

            return 0;
            //string[] xParts = ((ListViewItem)x).SubItems[col].Text.Split('-');
            //string[] yParts = ((ListViewItem)y).SubItems[col].Text.Split('-');

            //for (int i = 0; i < xParts.Length; i++)
            //{
            //    int xVal = int.Parse(xParts[i]);
            //    int yVal = int.Parse(yParts[i]);

            //    int comparisonResult = xVal.CompareTo(yVal);
            //    if (comparisonResult != 0)
            //    {
            //        return order == SortOrder.Ascending ? comparisonResult : -comparisonResult;
            //    }
            //}

            //return 0;
        }
    }
}