using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForTest2
{
    SortedList<(double, double, double), double> zFunc = new SortedList<(double, double, double), double>();
    double dX, dY, dW, dZ;
    int nX, nY, nW;
    for()
    nY = 0;
    for(dY = -1; dY <=1; dY += 0.1){
        dY = Math.Round(dY,1);
        nX = 0;
        for(dX = 0; dX <=4; dY +=0.1){
            dX = Math.Round(dX,1);
            dZ = 4 * dY * dY * dY + 2 * dX * dX - 8 * dX + 7;
            dX = Math.Round(dZ, 3);
            zFunc[nX, nY, 0] = dX;
            zFunc[nX, nY, 1] = dY;
            zFunc[nX, nY, 2] = dZ;
            ++nY;
        }
        ++nX;
    }



}
