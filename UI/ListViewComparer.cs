using System.Collections;
using SortOrder = System.Windows.Forms.SortOrder;

namespace UI
{
    public class ListViewComparer : IComparer
    {
        private const int DateHeader = 0;
        private const int LocationHeader = 1;
        private const int TemperaturHeader = 2;
        private const int HumidityHeader = 3;
        private const int MoldRiskHeader = 4;

        private int sortColumn = -1;
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
            double numFirst, numSecond;
            int firstNum, secondNum;

            switch (col)
            {
                case DateHeader:

                    returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                       ((ListViewItem)y).SubItems[col].Text);
                    break;

                case LocationHeader:
                    returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                       ((ListViewItem)y).SubItems[col].Text);
                    break;

                case TemperaturHeader:
                case HumidityHeader:
                    numFirst = Convert.ToDouble(((ListViewItem)x).SubItems[col].Text);
                    numSecond = Convert.ToDouble(((ListViewItem)y).SubItems[col].Text);
                    if (numFirst < numSecond)
                        returnVal = -1;
                    else if (numFirst > numSecond)
                        returnVal = 1;
                    else
                        returnVal = 0;
                    break;

                case MoldRiskHeader:
                    firstNum = int.Parse(((ListViewItem)x).SubItems[col].Text);
                    secondNum = int.Parse(((ListViewItem)y).SubItems[col].Text);
                    if (firstNum < secondNum)
                        returnVal = -1;
                    else if (firstNum > secondNum)
                        returnVal = 1;
                    else
                        returnVal = 0;
                    break;
            }

            if (order == SortOrder.Descending)

                returnVal *= -1;

            return returnVal;
        }
    }
}