using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    class Container
    {
        int Id { get; }
        float Weight { get; }
        bool IsRefrigerated { get; }
        List<string> Merchandise { get; }
        string Color { get; }
        public Container(int id, float weight, bool isRefrigerated, string color) 
        {
            Id = id;
            Weight = weight;
            IsRefrigerated = isRefrigerated;
            Color = color;
            Merchandise = new List<string>();
        }  
    }

}