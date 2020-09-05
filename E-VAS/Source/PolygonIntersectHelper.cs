using System;
using System.Drawing;

class PolygonIntersectHelper
{
    public bool IsPointInPolygon(PointF[] polygon, PointF point)
    {
        bool result = false;
        int j = polygon.Length - 1;
        for (int i = 0; i < polygon.Length; i++)
        {
            if (polygon[i].Y < point.Y && polygon[j].Y >= point.Y || polygon[j].Y < point.Y && polygon[i].Y >= point.Y)
            {
                if (polygon[i].X + (point.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) < point.X)
                {
                    result = !result;
                }
            }
            j = i;
        }
        return result;
    }
}