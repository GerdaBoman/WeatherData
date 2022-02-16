﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MoldCalcuation
    {
        int[,] mold =
        {
         {0,0,0,0},
     {0,97,98,100},
     { 0,95,97,100},
     { 0,93,95,100},
     { 0,91,93,98},
     { 0,88,92,97},
     { 0,87,91,96},
     { 0,86,91,95},
     { 0,84,90,95},
     { 0,83,89,94},
     { 0,82,88,93},
     { 0,81,88,93},
     { 0,81,88,92},
     { 0,80,87,92},
     { 0,79,87,92},
     { 0,79,87,91},
     { 0,79,86,91},
     { 0,79,86,91},
     { 0,79,86,90},
     { 0,79,85,90},
     { 0,79,85,90},
     { 0,79,85,90},
     { 0,79,85,89},
     { 0,79,84,89},
     { 0,79,84,89},
     { 0,79,84,89},
     { 0,79,84,89},
     { 0,79,83,88},
     { 0,79,83,88},
     { 0,79,83,88},
     { 0,79,83,88},
     { 0,79,83,88},
     { 0,79,83,88},
     { 0,79,82,88},
     { 0,79,82,87},
     { 0,79,82,87},
     { 0,79,82,87},
     { 0,79,82,87},
     { 0,79,82,87},
     { 0,79,82,87},
     { 0,79,82,87},
     { 0,79,81,87},
     { 0,79,81,87},
     { 0,79,81,87},
     { 0,79,81,87},
     { 0,79,81,86},
     { 0,79,81,86},
     { 0,79,81,86},
     { 0,79,80,86},
     { 0,79,80,86},
     { 0,79,80,86}
        };

        public int moldCalc(int temp, int fukt)
        {
            int Mindex;
            if (temp <= 0 || temp > 50)
            {
                Mindex = 0;
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (fukt < mold[temp, i])
                    {
                        Mindex = i - 1;
                        break;
                    }

                }
                Mindex = 3;
            }
            return Mindex;

        }

    }
}
