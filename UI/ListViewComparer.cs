using System.Collections;
using SortOrder = System.Windows.Forms.SortOrder;

namespace UI
{
    public class ListViewComparer : IComparer
    {
        private int col;
        private SortOrder order;
        public ListViewComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }

        public ListViewComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                       ((ListViewItem)y).SubItems[col].Text);

            // Determine whether the sort order is descending.
            if (order == SortOrder.Descending)
                // Invert the value returned by String.Compare.
                returnVal *= -1;

            return returnVal;
        }
    }
}
