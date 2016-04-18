using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AesProject
{
    public static class Aes
	{

        private static Block SubBytes(Block block)
        {
            throw new NotImplementedException();
        }

        private static Block ShiftRows(Block block)
        {
            byte[] arrayAfterShift = new byte[16];
            // firsr row
            for (int i =0; i < 3; i++)
            {
                arrayAfterShift [i]= block.get
            }
            // second row

            // thirde row

            //  last row

            return blockAfterShift;

              }

        private static Block MixColumns(Block block)
        {
            throw new NotImplementedException();
        }

        private static Block AddRoundKey(Block block)
        {
            throw new NotImplementedException();
        }
    }
}
