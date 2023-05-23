public static class Info
{
    private static List<Pais> ListaPaises = new List<Pais>();

   private static void InicializarLista()
   {
    Pais unPais = new Pais("Argentina" , "argentina.png" ,  45000000 , new DateTime (1816,7,9) , "Cataratas");
    ListaPaises.Add(unPais);
    unPais = new Pais("Brasil" , "brasil.png" ,  145000000 , new DateTime (1820,4,3) , "Rio de Janeiro");
    ListaPaises.Add(unPais);
    unPais = new Pais("Chile" , "chile.png" ,  8000000 , new DateTime (1824,6,7) , "Pucon");
    ListaPaises.Add(unPais);
     unPais = new Pais("Uruguay" , "uruguay.png" , 5000000 , new DateTime (1824,12,3) , "Pucon");
    ListaPaises.Add(unPais);
     unPais = new Pais("Paraguay" , "paraguay.png" ,  5000000 , new DateTime (1824,4,10) , "asuncion");
    ListaPaises.Add(unPais);
   }
   public static List<Pais> ListarPaises()
   {
    if (ListaPaises.Count == 0)
    {
        InicializarLista();
        
    }
    return ListaPaises;

   }
   public static Pais DetallePais(string Nombre)
   {
    Pais PaisBuscado = new Pais();
    foreach (Pais item in ListaPaises)
    {
        if (item.Nombre == Nombre)
        {
            return item;
        }
    }
    return PaisBuscado;

   }
}