namespace Menu
{
    internal class Menu
    {
        public string[] items;
        public string nombreMenu;
        public int priItem;
        public int columna;
        public int fila;

        public Menu(int priItem, string nombreMenu, string[] opciones, int fila, int col)
        {
            this.items = opciones;
            this.nombreMenu = nombreMenu;
            this.priItem = priItem;
            this.fila = fila;
            this.columna = col;
        }
    }
}