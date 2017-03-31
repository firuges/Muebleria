
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Class
{
    public class FacturaCOMMON
    {
        public DateTime SaleDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public EmployeeCOMMON SellerEmployee { get; set; }
        public ClientCOMMON BuyerClient { get; set; }
        public decimal TotalPrice { get; set; }
        public List<LineCOMMON> ListOfLine { get; set; }
        private static FacturaCOMMON _instance_Factura;
        public static FacturaCOMMON getInstanceFactura()
        {
            if (_instance_Factura == null)
            {
                _instance_Factura = new FacturaCOMMON();
            }

            return _instance_Factura;
        }
        private static List<LineCOMMON> _instance_List_Line;
        public static List<LineCOMMON> getInstanceLine()
        {
            if (_instance_List_Line == null)
            {
                _instance_List_Line = new List<LineCOMMON>();
            }

            return _instance_List_Line;
        }
    }
}
