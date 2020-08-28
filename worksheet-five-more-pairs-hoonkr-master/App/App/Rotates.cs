namespace App
{
    public class Rotates
    {
        public char move(char ch, int num)
        {
            if (num == 0)
            {
                return ch;
            }
            
            else
            {
                char nextCh = (char)((int) ch + num);
                if ((int) nextCh >= 122)
                {
                    nextCh = (char) ((int) nextCh - 26);
                }

                // else ((int) nextCh  90)
                
                    return nextCh;
            }
            
        }
    }
}