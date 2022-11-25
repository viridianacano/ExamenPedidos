using System.ComponentModel;
using System.Globalization;

namespace pedidos.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }

        public string producto { get; set; }

        public string envioDireccion { get; set; }

        public int clienteId { get; set; }


    }
}
