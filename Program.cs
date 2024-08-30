using DesafioPOO.Models;

Iphone ip1 = new Iphone("123456","abc-123","654321",256);
ip1.Ligar();
ip1.ReceberLigacao();
ip1.InstalarAplicativo("IphoneApp");

Nokia nk1 = new Nokia("654321","def-456","123456",64);

nk1.Ligar();
nk1.ReceberLigacao();
nk1.InstalarAplicativo("NokiaApp");
