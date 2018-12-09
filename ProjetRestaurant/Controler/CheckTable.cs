namespace command
{
    internal class CheckTable
    {
        public int Check(int NumberPerson)
        {
            int i = NumberPerson;

            if (i <= 2)
            {
                return 1;  //Table 2 places
            }
            else if (i <= 4)
            {
                return 4;   //Table 4 places
            }
            else if (i <= 6)
            {
                return 6;   //Table 6 places
            }
            else if (i <= 8)
            {
                return 8;   //Table 8 places
            }
            else if (i <= 10)
            {
                return 10;  //Table 10 places
            }
            else
            {
                return 0;  //Pas de place
            }

        }
    }
}