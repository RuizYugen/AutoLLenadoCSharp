﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoLlenado
{
    class Alumno
    {
        private int id;
        private string matricula;
        private string curp;
        private string apellido1;
        private string apellido2;
        private string nombre;
        private string fechaNacimiento;
        private string escuela;
        private string direccion;
        private string telefono;
        private string tipoSangre;
        private string tutor;
        private string direccionTutor;
        private string telefonoTutor;
        private string[] apellidos = {"Abad","Abalos","Abarca","Abendano","Abila","Abina","Abitua","Aboites","Abonce","Abrego",
"Abrica","Abrigo","Abundis","Aburto","Acebedo","Acebes","Acencio","Acero","Acevedo","Aceves",
"Acha","Adan","Adrian","Agirre","Agredano","Aguado","Aguallo","Aguas","Aguayo","Agueda",
"Aguero","Aguila","Aguilar","Aguilera","Aguinaga","Aguino","Aguirre","Agundis","Ahuatl","Ahumada",
"Aiala","Aillon","Alamilla","Alamiya","Alamo","Alanis","Alarcon","Alatorre","Alatriste","Alaves",
"Alba","Albarado","Albares","Albarran","Alberto","Albino","Albis","Albornos","Alcantar","Alcaras",
"Alcocer","Alcorta","Aldaco","Aldape","Aldaz","Alderete","Alejandro","Alejo","Aleman","Alexos",
"Alfaro","Alferes","Alfonso","Alguera","Allala","Allende","Almager","Almaguer","Almanza","Almaras",
"Almasan","Almeda","Almejo","Almendares","Almodovar","Almonte","Almorin","Alonzo","Altamirano","Altra",
"Altusar","Alva","Alvarado","Alvares","Alverto","Alvidres","Alvillar","Alvino","Alviso","Amador",
"Amalla","Amaral","Amarilla","Amaro","Amaya","Ambris","Ambrocio","Americano","Amescua","Amesola",
"Amesquita","Ana","Analla","Anaya","Anda","Anderson","Andrada","Andrade","Andres","Andrews",
"Andrez","Angel","Angeles","Angiano","Angon","Anguiano","Angulo","Anna","Anrriquez","Ansaldo",
"Ansures","Antillon","Antonio","Antuna","Antunes","Aparicio","Apodaca","Apolinar","Apresa","Aquallo",
"Aquilar","Aquirre","Ara","Aragon","Araiza","Arana","Aranda","Arango","Aranguti","Araujo",
"Araus","Arauxo","Arayza","Arbizu","Arce","Arceo","Arcia","Arciniega","Arcola","Arebalo",
"Arechiga","Aredondo","Arellano","Arenas","Arevalo","Areyano","Argote","Arguelles","Arguello","Argueta",
"Arguijo","Arias","Ariola","Arisa","Arisaga","Arismendis","Arispe","Ariza","Arizaga","Armadillo",
"Armendaris","Armengol","Armenta","Armijo","Aro","Aroche","Aros","Aroyo","Arpero","Arrasola",
"Arrayales","Arreaga","Arredondo","Arreguin","Arreola","Arreortua","Arrequin","Arriaga","Arrieta","Arriola",
"Arroio","Arrollo","Arrona","Arroyo","Arsate","Arse","Arsiga","Arsiniega","Arsola","Arteaga",
"Arujo","Arze","Arzola","Asa","Ascona","Asebes","Asencio","Asero","Asevedo","Aseves",
"Aspitia","Astorga","Astudillo","Asuara","Atilano","Atondo","Auguiano","Aumada","Aurioles","Avelino",
"Avila","Aviles","Avilla","Avitia","Ayon","Azebedo","Azero","Azevedo","Baca","Bacasegua",
"Badillo","Badiola","Baena","Baes","Bahena","Baina","Baisa","Baker","Balades","Balbaneda",
"Balberde","Balbuena","Balderas","Baldes","Baldespino","Baldibia","Baldivia","Baldivieso","Baldonado","Baldovinos",
"Balencia","Balencuela","Balensuela","Balentin","Balenzuela","Balero","Balladares","Ballarta","Ballejo","Ballesa",
"Ballesteros","Ballin","Ballinas","Balona","Balseca","Baltierres","Balverde","Balvuena","Banderas","Bandilla",
"Banegas","Banes","Baptista","Baquera","Baragan","Barajas","Baraxas","Barba","Barbero","Barcenas",
"Barco","Barela","Barientos","Barques","Barra","Barragan","Barrales","Barranco","Barraza","Barreda",
"Barreto","Barrientes","Barrientos","Barron","Barros","Barroso","Barsena","Barunda","Barva","Barvosa",
"Barzena","Basan","Basgues","Basques","Basulto","Basurto","Bata","Batres","Bautista","Bayejo",
"Baylon","Bazan","Becerra","Becerril","Bedolla","Bedoya","Bega","Begil","Bejarano","Bela",
"Belarde","Belasco","Belasques","Belendes","Belis","Belman","Belmontes","Belmudes","Belos","Beltran",
"Benabides","Benegas","Benites","Benito","Bentura","Bera","Berber","Berdin","Berdusco","Bergara",
"Bermejo","Bermudes","Bernal","Bernales","Bernardino","Berra","Berrio","Berrones","Berruecos","Bertis",
"Berumen","Beserra","Betancourt","Betancur","Bexarano","Bibaldo","Bibas","Bidal","Bidales","Biera",
"Bigueria","Billa","Billagomes","Billalobos","Billalovos","Billalpando","Billanueba","Billanueva","Billasenor","Billegas",
"Biscarra","Blancarte","Blancas","Blanco","Blas","Bobadilla","Bocanegra","Bocardo","Bocas","Bojorques",
"Bolanos","Bona","Bonifacio","Bonilla","Bonito","Borbon","Borda","Borjas","Borrego","Bosque",
"Botello","Bovadilla","Boyd","Bracamontes","Bracho","Brambila","Bravo","Brena","Bribiesca","Briones",
"Brisena","Briseno","Brito","Briviescas","Brocal","Brooks","Brown","Bruno","Brusiaga","Buelna",
"Buen","Buenabides","Buenavides","Buendia","Bueno","Buenrostro","Buentello","Bugarin","Buitimea","Buitron",
"Burciaga","Burgos","Burnett","Bustamante","Bustos","Butanda","Butierres","Byrd","Caacuaa","Caacusi",
"Caaghu","Caasayu","Caballero","Cabanillas","Cabello","Cabesa","Cabral","Cabrera","Cabriales","Cacalotl",
"Cacillas","Cacimiro","Caco","Cacuaa","Cacuiy","Cacusi","Caghi","Caghu","Cague","Caguihui",
"Cahua","Cahuaco","Cahuidzu","Cahuiyo","Calata","Calbario","Calbo","Caldera","Calderon","Calisto",
"Calistro","Callejas","Calleros","Calles","Calletano","Calsada","Calvario","Calvillo","Calzada","Cama",
"Camacho","Camahu","Camarena","Camargo","Camarillo","Camau","Camberos","Cambray","Camino","Campa",
"Campillo","Campirano","Campos","Camposano","Campusano","Cana","Canal","Canceco","Canchola","Cancino",
"Candelaria","Candelario","Candia","Canedo","Canela","Canencia","Cano","Canoa","Canpos","Canseco",
"Cansino","Cantero","Cantu","Canuu","Canzeco","Capasete","Capetillo","Capistrano","Capitan","Caquihui",
"Cara","Carabajal","Caraballo","Carabantes","Carabaxal","Carandia","Carapia","Carasco","Caravajal","Caravallo",
"Caravantes","Cardenas","Cardiel","Cardona","Cardoso","Cariaga","Carillo","Carion","Carlin","Carlon",
"Carlos","Carmel","Carmona","Carnero","Caro","Carpintero","Carpio","Carrales","Carranco","Carrasco",
"Carreno","Carrera","Carreto","Carrillo","Carrion","Carrisal","Carrisales","Carriyo","Carrizal","Carro",
"Carvajal","Casa","Casanoba","Casanova","Casares","Casas","Casasola","Casayu","Casco","Caseres",
"Casian","Casillas","Casimiro","Casique","Cassas","Cassillas","Castanon","Castelan","Castellanos","Castellon",
"Casteneda","Castilla","Castilleja","Castillo","Castiyo","Casto.","Castorena","Castrejon","Castrillo","Castro",
"Catalan","Catano","Catuta","Cavallero","Cavazos","Cavello","Cavrera","Cayetano","Cayo","Cazares",
"Ceballos","Cedeno","Cedillo","Ceja","Celaya","Celio","Celis","Cena","Centeno","Cepeda",
"Cerbantes","Cerda","Cermeno","Cerna","Ceron","Cerrano","Cerrato","Cerrillo","Certuche","Cervantes",
"Cervera","Cervin","Cevallos","Cevilla","Chabaria","Chabarin","Chabarria","Chabes","Chabira","Chaboya",
"Chaca","Chacon","Chagolla","Chagollan","Chaire","Chantes","Chapa","Chapul","Charles","Charqueno",
"Chavarria","Chavarrieta","Chaves","Chaveste","Chavez","Chavira","Chavolla","Chia","Chica","Chico",
"Chicuate","Chihuagua","Chihuahua","Chilaca","Chilar","Chilchotl","Chiquito","Chirinos","Cholico","Cholula",
"Chon","Choperena","Cierra","Cifuentes","Cilba","Cilva","Cimental","Cirilo","Cisneros","Cistos",
"Clark","Claudio","Clemente","Cleto","Climaco","Coatl","Coba","Cobarrubias","Cobian","Cobos",
"Coca","Cochi","Cocio","Cocone","Cocusi","Coeto","Coghi","Coix","Colchado","Colima",
"Colin","Colirio","Collado","Colmenares","Colmenero","Colorado","Colunga","Comparan","Compean","Concepcion",
"Condado","Conde","Conrrique","Constancia","Constante","Constantino","Contreras","Conuu","Copado","Coquau",
"Coquihui","Corales","Corchado","Cordoba","Cordova","Corea","Coreno","Coria","Cornejo","Cornelio",
"Corona","Coronado","Corral","Corrales","Correa","Corro","Cortes","Cortez","Cos","Cosa",
"Cosileon","Cosme","Costilla","Cota","Cotzomi","Covarrubias","Covarruvias","Covos","Cox","Coyaso",
"Coyo","Coyote","Coyotl","Coz","Cozatl","Cozileon","Crespin","Crespo","Crisanto","Crisostomo",
"Crispin","Cristan","Crus","Cruz","Cuachitl","Cuacitl","Cuacuil","Cuadros","Cuaetle","Cuatecatl",
"Cuatlat","Cuatlayol","Cuautle","Cuautli","Cuaya","Cuechi","Cuello","Cuenca","Cuesta","Cuevas",
"Cueyar","Cueyo","Cuin","Cumplido","Cura","Cusicuiy","Cusihuidzu","Cusihuiyo","Cusimahu","Cusimau",
"Cusimey","Cusinuu","Cusiquihui","Cusisayu","Cusituta","Dabalos","Dabila","Dado","Damian","Daniel",
"Dasa","Davila","Daza","Delara","Delgadillo","Delgado","Delos","Delossantos","Deras","Diego",
"Dimas","Dionicio","Dios","Dolores","Domingues","Dominguez","Donate","Dongu","Dorado","Dorantes",
"Duarte","Duenas","Duque","Duran","Duron","Echeverria","Eledesma","Elenes","Elias","Elisondo",
"Elizarraras","Elizondo","Enamorado","Encarnacion","Encinas","Enciso","Enriquez","Enrrique","Enrriquez","Ensiso",
"Eredia","Erera","Ernandes","Errera","Escalante","Escalera","Escamilla","Escandon","Escobar","Escobedo",
"Escojido","Escovar","Escutia","Espalin","Espana","Esparcia","Esparza","Espejo","Espindola","Espinel",
"Espinola","Espinoza","Espiritu","Espitia","Esqueda","Esquibel","Esquibias","Esquivel","Esquivias","Esteban",
"Estebes","Estevan","Esteves","Estrada","Estrella","Estreya","Estudillo","Europa","Evangelista","Evans",
"Evora","Fabela","Fabian","Facio","Fajardo","Falcon","Farfan","Farias","Faustino","Faxardo",
"Feliciano","Felis","Feliz","Ferel","Fermin","Fernandes","Fernandez","Fernando","Ferreira","Ferrel",
"Fierro","Figueroa","Filoteo","Fiscal","Fletes","Flores","Florez","Fonceca","Fonseca","Frade",
"Fraga","Fragoso","Fraide","Fraile","Franca","Francisco","Franco","Frausto","Fregoso","Frias",
"Frutos","Fuente","Fuentes","Fuerte","Fulgencio","Funes","Gabia","Gabino","Gabriel","Gadillo",
"Gado","Galabis","Galan","Galarza","Galas","Galavis","Galban","Galbes","Galego","Galicia",
"Galisia","Gallardo","Gallega","Gallegos","Gallo","Galvan","Galvana","Gama","Gamboa","Gamero",
"Games","Gamez","Gamino","Ganboa","Gandara","Gaona","Garambuyo","Garate","Garavito","Garay",
"Garcia","Gardea","Garduno","Garfias","Garia","Garibai","Garibaldo","Garibay","Garivay","Garnica",
"Garrido","Garsa","Garsia","Garza","Garzia","Gasca","Gascon","Gaspar","Gastan","Gatica",
"Gauna","Gausin","Gavia","Gavilan","Gavilanes","Gavino","Gayardo","Gayo","Gaytan","Gazca",
"Gebara","George","Gerardo","Gerero","German","Gerra","Gertrudis","Gervacio","Ghco","Ghcuaa",
"Ghcuiy","Ghcusi","Ghghu","Ghichi","Ghico","Ghicuau","Ghicuey","Ghicuiy","Ghicusi","Ghighi",
"Ghighu","Ghihuaco","Ghihuidzu","Ghihuiyo","Ghima","Ghinoo","Ghiquau","Ghisa","Ghisayu","Ghituta",
"Ghiyo","Ghma","Ghmahu","Ghmau","Ghmey","Ghnoo","Ghnuu","Ghquihui","Ghsa","Ghsayu",
"Ghsichi","Ghsighi","Ghsima","Ghsisa","Ghsiyo","Ghtuta","Ghyo","Gil","Gillen","Gimenes",
"Gimenez","Gines","Gloria","Gobea","Goche","Godina","Godines","Godoi","Godoy","Gomes",
"Goncales","Gongora","Gonzaga","Gonzalez","Gopar","Gordillo","Gordo","Govea","Gracia","Gradilla",
"Grageda","Grajales","Grajeda","Granado","Grande","Grangenal","Grano","Grasia","Gregorio","Griego",
"Grigalva","Grijalva","Grusiaga","Guadalaxara","Guadalupe","Guadarrama","Guadiana","Guajardo","Guanajuato","Guaracha",
"Guardado","Guardia","Guardiola","Guarneros","Gudino","Guereca","Guerra","Guerrero","Guerta","Guete",
"Guevara","Guia","Guido","Guijarro","Guillen","Guilo","Guimenes","Guines","Guipe","Guisa",
"Guisar","Guiterres","Guiza","Gurrola","Gusman","Gutieres","Gutierrez","Haro","Harris","Haumada",
"Helguera","Henrique","Henriquez","Heredia","Hererra","Hermoso","Hernandes","Hernandez","Herrada","Herrera",
"Herver","Hibarra","Hierro","Higareda","Higuera","Hijar","Hilario","Hinojosa","Hornelas","Horosco",
"Horta","Hortega","Hortis","Huaracha","Huerta","Huisache","Huisar","Huitzil","Huizar","Humada",
"Hurtado","Hurvina","Hydalgo","Ianes","Ianito","Ibarra","Idalgo","Illescas","Infante","Inigues",
"Inojos","Inojosa","Isarraras","Ivarra","Jacinto","Jaco","Jacoba","Jacobo","Jaen","Jahuey",
"Jalpa","Jamaica","Jan","Jaques","Jara","Jaramillo","Jaramiyo","Jarquin","Jaso","Jaure",
"Jauregui","Jauri","Jazo","Jimenes","Jiron","Jonguitud","Juache","Juan","Juares","Jurado",
"Labra","Labrador","Ladino","Ladron","Lagunas","Lagunillas","Lala","Lamas","Lambarena","Landa",
"Landeros","Landeta","Landin","Langarcia","Langarica","Larios","Laris","Laro","Lasareno","Laso",
"Laureano","Lazareno","Lazaro","Lazo","Leal","Leandro","Leche","Lechuga","Leiba","Lemus",
"Leon","Leonardo","Leonor","Lepe","Lerma","Lesama","Leso","Letins","Levario","Leyba",
"Liebanos","Liera","Ligas","Lilo","Limon","Linan","Linares","Lino","Lira","Lisama",
"Lisarde","Lisarraga","Lisea","Lisola","Lisondo","Llaguno","Llamas","Llanas","Llanes","Llanito",
"Llepes","Loayza","Lobato","Lobos","Loeza","Lomas","Lomeli","Lomelin","Longoria","Lopez",
"Loredo","Lorenzana","Lorenzano","Lorenzo","Loreto","Loria","Losada","Losano","Lossano","Lovato",
"Loya","Loza","Lozada","Luciano","Lucio","Luengas","Luevano","Lueza","Luga","Lugarda",
"Luguin","Lujan","Lule","Lumbreras","Luna","Lupercio","Lupez","Lupian","Luria","Luz",
"Macario","Macedo","Machado","Machorro","Macias","Maciel","Madaleno","Madera","Madrigal","Madrueno",
"Mafra","Magallanes","Magallon","Magana","Magdaleno","Maguellal","Maia","Maiorga","Malacara","Maldonado",
"Maleno","Malindo","Malo","Malpica","Mancera","Mancha","Mancilla","Mandujano","Mani","Manriquez",
"Mansanales","Mansanares","Mansanero","Mansano","Mansilla","Manso","Mantilla","Manuel","Manzanales","Manzanares",
"Manzo","Marabilla","Maravilla","Marceleno","Marchan","Marcial","Mareno","Mares","Marfil","Margues",
"Maria","Mariano","Marimon","Marin","Marines","Marroquin","Marrufo","Martel","Martin","Martines",
"Martinon","Mascorro","Massias","Mata","Mateo","Mateos","Matheo","Mathias","Matias","Maturan",
"Maya","Mayor","Meave","Meda","Medel","Medellin","Medero","Medez","Medina","Medinilla",
"Megia","Mejia","Mejicano","Mejorada","Melecio","Melendres","Melesio","Melgar","Melgarejo","Melgoza",
"Mellado","Membrila","Mena","Menchaca","Mendes","Mendez","Mendia","Mendieta","Mendiola","Mendosa",
"Meneces","Meneses","Meras","Mercado","Merced","Mereles","Merino","Merlin","Merlo","Merodio",
"Mesquite","Messa","Mexia","Meza","Michaca","Miguel","Milan","Minchaca","Minero","Minguela",
"Minxares","Mira","Miramontes","Miranda","Mireles","Mitzi","Moctesuma","Modesto","Mogica","Moia",
"Mojica","Molina","Molla","Molleda","Monares","Moncada","Moncayo","Mondragon","Monjaras","Monreal",
"Montana","Montanes","Montano","Monte","Montecillo","Montecinos","Montejano","Montelongo","Montemar","Montemayor",
"Monteon","Montero","Monterroso","Montesillo","Montesinos","Montesuma","Montez","Montiel","Montion","Montolla",
"Montoya","Montufar","Monzon","Mora","Morado","Moral","Morales","Morantes","Moras","Morelos",
"Moreno","Morentin","Morfin","Morgado","Morillo","Morin","Moriyo","Morones","Morquecho","Morras",
"Morua","Moscoso","Moso","Mosqueda","Mota","Motete","Mototl","Moxarro","Moxica","Moya",
"Moyeda","Moyotl","Muela","Mujica","Mulgado","Mundo","Munes","Mungia","Munguia","Munis",
"Munos","Murgo","Muriyo","Muro","Nabarro","Nabor","Nachi","Naco","Nagera","Naghi",
"Naghu","Nahuidzu","Nahuiyo","Najar","Najera","Nama","Namau","Namorado","Nanes","Napoles",
"Naquihui","Narbaes","Narvaez","Nasa","Nasayu","Natividad","Natuta","Navarrete","Naveda","Navia",
"Nayo","Nazario","Negreros","Negrete","Neira","Neri","Neria","Nesta","Neto","Nevares",
"Niave","Nicolaza","Niebes","Niebla","Nieva","Nieves","Nila","Nino","Noboa","Nocelotl",
"Noco","Nocuaa","Nocuiy","Nocusi","Nogales","Noghi","Nohuaco","Nohuidzu","Nohuiyo","Nolasco",
"Nollola","Noma","Nomau","Nopalera","Noquihui","Norabuena","Noriega","Nosa","Nosayu","Notario",
"Novoa","Noyo","Numau","Nuncio","Nunes","Nungarai","Nuno","Oballe","Obispo","Oblea",
"Obregon","Ocana","Ocaranza","Oceguera","Ochoa","Octavo","Ogalde","Olachia","Olaque","Olaya",
"Oldorica","Olea","Olgin","Olguin","Oliba","Olibares","Olibas","Olibera","Oliva","Olivas",
"Olivera","Olivo","Olivos","Olmos","Olveda","Onate","Oporto","Oranday","Ordaz","Ordones",
"Ordorica","Orduno","Oregel","Oria","Oribe","Orihuela","Orisava","Orocio","Orona","Oropesa",
"Orosco","Orsua","Orta","Ortes","Ortigosa","Ortis","Ortuno","Osegueda","Osorio","Ossorio",
"Osuna","Otero","Otuel","Oviedo","Oxeda","Ozegueda","Pablo","Pacho","Paderes","Padia",
"Padilla","Padron","Padua","Paes","Palacios","Palafos","Palasios","Palencia","Pallares","Palma",
"Palmerin","Palo","Paloalto","Paloblanco","Palomar","Palomeque","Palomera","Palomino","Palomo","Palos",
"Palula","Panecatl","Paneda","Paniagua","Pantaleon","Pantoja","Pantoxa","Para","Parada","Paramo",
"Pardave","Pardinas","Pardo","Pareja","Parra","Parrales","Parrilla","Partida","Pasillas","Pasqual",
"Pastrana","Patino","Patlan","Patricio","Patron","Paulin","Paura","Pavon","Paz","Pecina",
"Pedraza","Pedrosa","Peeres","Peguero","Peinado","Pelaes","Pelayo","Pena","Penalosa","Penilla",
"Penuelas","Perales","Peralta","Percino","Perea","Peredo","Peregrina","Pereira","Perez","Pescador",
"Pesina","Pestana","Pezina","Piceno","Pichardo","Picon","Piedra","Pilar","Piloto","Pimienta",
"Pineda","Pinon","Pinson","Pinto","Pintor","Pinzon","Pio","Pisa","Pisano","Pitones",
"Plancarte","Plasola","Plata","Plaza","Plazola","Pliego","Poblano","Poblete","Polanco","Polino",
"Polvo","Pompa","Ponse","Popoca","Porras","Portales","Portante","Portillo","Posada","Posas",
"Poso","Prada","Prado","Preciada","Preciado","Presas","Priego","Prieto","Proa","Procel",
"Provencio","Puebla","Puente","Puerta","Puga","Pulgarin","Pulido","Quebara","Quebas","Quebedo",
"Quenca","Queretano","Quero","Quesada","Quevedo","Quezada","Quijada","Quijano","Quijas","Quinones",
"Quintanar","Quintanilla","Quintano","Quintero","Quintos","Quiralte","Quirarte","Quiros","Quiteria","Quitl",
"Quixano","Rabadan","Rabago","Rada","Radillo","Rafael","Raia","Ralla","Ramales","Ramblas",
"Ramires","Ramiro","Ramon","Ramos","Rams.","Ranguel","Ranjel","Ranxel","Rascon","Rasgado",
"Raso","Rasura","Rauda","Ravago","Raya","Razon","Rea","Real","Rebeles","Rebollo",
"Rebolloso","Recendes","Recio","Regalado","Regino","Regla","Reies","Reina","Reinaga","Reinoso",
"Relles","Rendon","Requenes","Resa","Resendes","Reta","Reteguin","Reveles","Revilla","Reyes",
"Reyna","Reynaga","Reynero","Reza","Ribas","Ribera","Rica","Ricardo","Rico","Riestra",
"Rincon","Rios","Rivera","Rizo","Roa","Robalcaba","Robledo","Roblero","Robles","Rocha",
"Rocio","Rodarte","Rodas","Rodrigues","Rogue","Rojas","Rojo","Roldan","Rolon","Roman",
"Romano","Romero","Ronco","Rondan","Rondero","Roque","Rosa","Rosario","Rosas","Rosendo",
"Rosete","Rosiles","Rositas","Rossales","Rostro","Roxas","Rozas","Ruan","Ruano","Rubio",
"Ruedas","Ruelas","Ruis","Rutia","Rutiaga","Ruvalcaba","Saavedra","Sabaleta","Sabas","Sabedra",
"Sabino","Sacarias","Saco","Sacusi","Saes","Saghi","Sagredo","Sagrero","Sahua","Sahuaco",
"Sahuiyo","Sains","Sais","Sala","Salado","Salais","Salamanca","Salas","Salbatierra","Salcedo",
"Saldana","Saldibar","Sales","Salgado","Salinas","Sallabedra","Salmeron","Salsedo","Salsido","Salvador",
"Salvatierra","Samaniego","Samano","Samarron","Samora","Samorano","Samores","Samudio","Sanabia","Sanabria",
"Sanavia","Sanbrano","Sanchez","Sandobal","Sanguino","Sanmiguel","Santa","Santana","Santander","Santarrosa",
"Santellan","Santiago","Santiestevan","Santillan","Santis","Santiyan","Santo","Santollo","Santos","Santoya",
"Santoz","Sapata","Sapien","Sapote","Saquau","Saquihui","Sarabia","Saracho","Saragosa","Sarate",
"Saravia","Sarco","Sardo","Saria","Sarmiento","Sasa","Sasayu","Satuta","Sauceda","Sausedo",
"Savala","Savallos","Savedra","Sayabedra","Sayas","Sayavedra","Sayo","Sebastian","Sebayos","Sebilla",
"Sedeno","Sedillo","Segobia","Segoviano","Segueda","Segundo","Segura","Seja","Seledon","Sena",
"Sendejas","Sendexas","Senor","Senteno","Sepeda","Sepulbeda","Serano","Serbantes","Serbin","Serda",
"Serena","Sereso","Sermeno","Seron","Serpa","Serrato","Serrillo","Servantes","Servera","Servin",
"Sesar","Sesena","Sespedes","Sevallos","Sevilla","Sexa","Sibrian","Sichi","Sicuaa","Sicuau",
"Sicuiy","Sicusi","Sid","Sierra","Sifuentes","Sigala","Sighu","Siguihui","Sihua","Sihuaco",
"Sihuidzu","Sihuiyo","Silbestre","Silva","Silverio","Silvestre","Simental","Simona","Sinto","Sintora",
"Sion","Siordia","Sipres","Siquaa","Siquau","Siquihui","Siranda","Sirlos","Sisa","Sisnero",
"Sistos","Situta","Siyo","Solache","Solachi","Solana","Solano","Soledad","Soliz","Soloriano",
"Solorsano","Soltero","Sonora","Sordia","Soriano","Sorrilla","Sosa","Sosalla","Sostenes","Sotela",
"Sotero","Soto","Sotomayor","Sotto","Suares","Subia","Suchel","Suchil","Sumaia","Sumalla",
"Sumano","Sumaya","Suniga","Sureque","Surita","Suro","Sustaita","Tabarez","Tabera","Taboada",
"Tafolla","Tagle","Talabera","Talamantes","Talavera","Talledos","Tamaio","Tamallo","Tamaris","Tamayo",
"Tapias","Tarin","Tavares","Tecol","Tecpanecatl","Tegeda","Tehuitzil","Tejeda","Teles","Tello",
"Temascal","Temblador","Tena","Teodoro","Tepale","Tepos","Teran","Terraso","Terriquez","Terrones",
"Teutli","Texeda","Teyes","Teyo","Thelles","Thobar","Thorres","Thovar","Tierra","Tierrablanca",
"Tijon","Timal","Tinajero","Tinoco","Tirado","Tiscareno","Tisnado","Tlapaltotoli","Tobares","Toledo",
"Tolentino","Tome","Topete","Tore","Torija","Toris","Torivio","Toro","Torre","Torrero",
"Torres","Tortolero","Toscano","Tosqui","Tostado","Tovar","Tranquilino","Trebino","Trejo","Trevino",
"Trexo","Trillo","Trinidad","Tristan","Triyo","Troche","Troncoso","Trujillo","Truxeque","Truxillo",
"Tunal","Turrubiartes","Ubaldo","Uballe","Ubeda","Udave","Umada","Urbana","Urbina","Urena",
"Ureste","Uresti","Uriarte","Uribe","Urillas","Urista","Urosa","Urquisa","Urresti","Urrutia",
"Ursua","Urvano","Urvina","Vadillo","Vaena","Vaes","Vahena","Valades","Valasquez","Valberde",
"Valcasar","Valderas","Valderrama","Valdes","Valdespino","Valdibia","Valdovinos","Valenciano","Valensia","Valentin",
"Valeria","Valeriano","Valesquez","Vallarta","Valle","Vallejo","Valles","Vallesa","Valleza","Vallin",
"Valverde","Vanda","Vanderas","Vanegas","Vara","Varajas","Varela","Varelas","Vargas","Varrientos",
"Varrios","Varron","Varva","Varvosa","Vasguez","Vasquez","Vautista","Vazques","Veas","Vecerra",
"Vedoya","Vegines","Vego","Vejar","Vejarano","Vela","Velador","Velarde","Velasco","Velasques",
"Velazco","Velazquez","Veles","Velez","Velis","Veliz","Vello","Velman","Velmontes","Velmudes",
"Velos","Veltran","Venavides","Venegas","Venites","Ventura","Vera","Verdugo","Verdusco","Vergara",
"Vermejo","Vernal","Veserra","Vetancur","Vetancurt","Vetansos","Vexarano","Vibanco","Vibar","Vicencio",
"Vicente","Vicinais","Vidaurri","Vidro","Viera","Viernes","Vieyra","Vigil","Vigueria","Vilchis",
"Villa","Villafane","Villafranco","Villafuerte","Villagra","Villalbaso","Villalobos","Villalon","Villalovos","Villalpando",
"Villalva","Villalvazo","Villamar","Villami","Villanueba","Villapando","Villareal","Villasana","Villasenor","Villasor",
"Villatoro","Villaverde","Villavicencio","Villegas","Villela","Villicana","Vincent","Vique","Viramontes","Virjan",
"Viscaino","Viscarra","Visente","Vivaldo","Vivanco","Vivar","Vivas","Viveros","Vlloa","Volanos",
"Vribe","Vriceno","Vriseno","Vrive","Xaime","Xaimes","Xaramillo","Xaso","Xavier","Xaymes",
"Xicotencatl","Xihuitl","Ximes","Ximines","Xique","Xiron","Xochitecatl","Xopanecatl","Xuares","Yanez",
"Ybanez","Ybara","Ybarrola","Yepez","Yerena","Yescas","Yglesias","Ygnacio","Yllan","Yllescas",
"Yniguez","Ynojosa","Ynostrosa","Ypolito","Yreta","Yrigollen","Ysaguirre","Ysidro","Yvanes","Yxtlamati",
"Yzquierdo","Zabala","Zabedra","Zalais","Zalamanca","Zaldana","Zamarripa","Zambrano","Zamudio","Zanabria",
"Zapote","Zarabia","Zarate","Zaravia","Zavala","Zeballos","Zedano","Zedillo","Zeferino","Zenon",
"Zepeda","Zerbantes","Zerrano","Zertucha","Zervantes","Zetina","Zisneros","Zolis","Zolorsano","Zoriano",
"Zosa","Zosaya","Zotelo","Zoto","Zuares","Zubia","Zuniga","Zurita"};
        private string[] nombres = {"JUAN","JOSE LUIS","JOSE","MARIA GUADALUPE","FRANCISCO","GUADALUPE","MARIA","JUANA","ANTONIO","JESUS",
"MIGUEL ANGEL","PEDRO","ALEJANDRO","MANUEL","MARGARITA","MARIA DEL CARMEN","JUAN CARLOS","ROBERTO","FERNANDO","DANIEL",
"CARLOS","JORGE","RICARDO","MIGUEL","EDUARDO","JAVIER","RAFAEL","MARTIN","RAUL","DAVID",
"JOSEFINA","JOSE ANTONIO","ARTURO","MARCO ANTONIO","JOSE MANUEL","FRANCISCO JAVIER","ENRIQUE","VERONICA","GERARDO","MARIA ELENA",
"LETICIA","ROSA","MARIO","FRANCISCA","ALFREDO","TERESA","ALICIA","MARIA FERNANDA","SERGIO","ALBERTO",
"LUIS","ARMANDO","ALEJANDRA","MARTHA","SANTIAGO","YOLANDA","PATRICIA","MARIA DE LOS ANGELES","JUAN MANUEL","ROSA MARIA",
"ELIZABETH","GLORIA","ANGEL","GABRIELA","SALVADOR","VICTOR MANUEL","SILVIA","MARIA DE GUADALUPE","MARIA DE JESUS","GABRIEL",
"ANDRES","OSCAR","GUILLERMO","ANA MARIA","RAMON","MARIA ISABEL","PABLO","RUBEN","ANTONIA","MARIA LUISA",
"LUIS ANGEL","MARIA DEL ROSARIO","FELIPE","JORGE JESUS","JAIME","JOSE GUADALUPE","JULIO CESAR","JOSE DE JESUS","DIEGO","ARACELI",
"ANDREA","ISABEL","TERESA","IRMA","CARMEN","LUCIA","ADRIANA","AGUSTIN","GUSTAVO"};
        private string[] sangres = { "A-", "A+", "B-", "B+", "O-", "O+" };
        private string[] escuelas = {"Escuela de nivel Medio Superior Centro Historico Leon","Centro de Estudios Tecnologicos Industrial y de Servicios No. 115","Escuela preparatoria de Silao. Universidad de Guanajuato","Escuela preparatoria de San Luis de la Paz. Universidad de Guanajuato","Escuela preparatoria de Guanajuato. Universidad de Guanajuato","Escuela preparatoria de Celaya. Universidad de Guanajuato","CONALEP Acambaro","Escuela preparatoria de Salvatierra. Universidad de Guanajuato","Centro de Estudios Tecnologicos Industrial y de Servicios No. 62","Escuela preparatoria de Salamanca. Universidad de Guanajuato",
"Escuela preparatoria de Penjamo. Universidad de Guanajuato","COMBAM","Escuela preparatoria de Irapuato. Universidad de Guanajuato","Centro de Estudios Tecnologicos Industrial y de Servicios No. 150","CECYTE","Preparatoria del sur de guanajuato","Instituto Yurirense","Preparatoria Lazaro Cardenas","Centro de Estudios Tecnologicos Industrial y de Servicios No. 65","Centro de Estudios Tecnologicos Industrial y de Servicios No. 198",
"Instituto de ciencias de Moroleon","CONALEP Moroleon","Centro de Estudios Tecnologicos Industrial y de Servicios No. 160","Centro de Estudios Tecnologicos Industrial y de Servicios No. 217"};
        private string[] direcciones = { "Roma", "benito Juarez", "Miguel Hidalgo", "Pedraza","Acapulco","Nayarit","Av. Leovino Zavala",
        "Pedregal","Rio Panuco","Victoria","Guanajuato"," heroes de chalpultepec"};
        private Random rmd = new Random();

        public Alumno(int id)
        {
            //rmd = new Random();
            //id =;
            //a.Matrícula.Genere un número consecutivo que tenga el texto “S000000X” 
            //donde X es el identity y a la izquierda se rellena con ceros.
   
            string cadena = "0000000000" + id;
            matricula = "S" + cadena.Substring(cadena.Length - 7);
            //b.CURP: genere un texto aleatorio de 4 letras y 10 dígitos.
            cadena = "000000000" + id;            
            apellido1 = apellidos[rmd.Next((id%apellidos.Length))];
            apellido1 = apellido1.ToUpper();
            if (id % apellidos.Length == 0)
            {
                apellido2 = apellidos[0];
            }
            else
            {
                apellido2 = apellidos[rmd.Next(1, ((id % apellidos.Length))) - 1];
            }
            
            apellido2 = apellido2.ToUpper();
            nombre = nombres[rmd.Next(nombres.Length)];
            curp = "" + apellido1.Substring(0,2)+ apellido2.Substring(0,1) + nombre.Substring(0,1) + cadena.Substring(cadena.Length - 10);            
            fechaNacimiento = rmd.Next(1950, 2001) + "-" + rmd.Next(1, 12) + "-" + rmd.Next(1, 28);
            escuela = (escuelas[rmd.Next(escuelas.Length)]).ToUpper();
            direccion = (direcciones[rmd.Next(direcciones.Length)]+" #"+(rmd.Next(1,1001)+id%50)).ToUpper();
            cadena = "0000000000" + id;
            telefono = "445" + cadena.Substring(cadena.Length - 7);
            tutor = (apellido1 + " " + apellidos[rmd.Next(id%apellidos.Length)] + " " + nombres[rmd.Next(id%nombres.Length)]).ToUpper();
            direccionTutor = direccion;
            TelefonoTutor = telefono;
            tipoSangre = sangres[rmd.Next(sangres.Length)];

        }

        public void  llenar(int id,Random rm)
        {


            rm = new Random();
            //id =;
            //a.Matrícula.Genere un número consecutivo que tenga el texto “S000000X” 
            //donde X es el identity y a la izquierda se rellena con ceros.

            string cadena = "0000000000" + id;
            matricula = "S" + cadena.Substring(cadena.Length - 7);
            //b.CURP: genere un texto aleatorio de 4 letras y 10 dígitos.
            cadena = "000000000" + id;
            curp = "" + ((char)(rm.Next(65, 91))) + (char)(rm.Next(65, 91)) + (char)(rm.Next(65, 91)) + (char)(rm.Next(65, 91)) + cadena.Substring(cadena.Length - 10);
            apellido1 = apellidos[rm.Next(apellidos.Length)];
            apellido2 = apellidos[rm.Next(apellidos.Length)];
            nombre = nombres[rm.Next(nombres.Length)];
            fechaNacimiento = rm.Next(1950, 2001) + "-" + rm.Next(1, 12) + "-" + rm.Next(1, 28);
            escuela = escuelas[rm.Next(escuelas.Length)];
            direccion = direcciones[rm.Next(direcciones.Length)] + " #" + rm.Next(1, 1001);
            cadena = "0000000000" + rm.Next(1000000);
            telefono = "445" + cadena.Substring(cadena.Length - 7);
            tutor = apellido1 + " " + apellidos[rm.Next(apellidos.Length)] + " " + nombres[rm.Next(nombres.Length)];
            direccionTutor = direccion;
            cadena = "0000000000" + rm.Next(1000000);
            TelefonoTutor = "445" + cadena.Substring(cadena.Length - 7);
            tipoSangre = sangres[rm.Next(sangres.Length)];

        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public string Curp
        {
            get
            {
                return curp;
            }

            set
            {
                curp = value;
            }
        }

        public string Apellido1
        {
            get
            {
                return apellido1;
            }

            set
            {
                apellido1 = value;
            }
        }

        public string Apellido2
        {
            get
            {
                return apellido2;
            }

            set
            {
                apellido2 = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public string Escuela
        {
            get
            {
                return escuela;
            }

            set
            {
                escuela = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string TipoSangre
        {
            get
            {
                return tipoSangre;
            }

            set
            {
                tipoSangre = value;
            }
        }

        public string Tutor
        {
            get
            {
                return tutor;
            }

            set
            {
                tutor = value;
            }
        }

        public string DireccionTutor
        {
            get
            {
                return direccionTutor;
            }

            set
            {
                direccionTutor = value;
            }
        }

        public string TelefonoTutor
        {
            get
            {
                return telefonoTutor;
            }

            set
            {
                telefonoTutor = value;
            }
        }

        public string toString()
        {
            string cadena = matricula + " - ";
            cadena += curp + " - ";
            cadena += nombre + " - ";
            cadena += apellido1 + " - ";
            cadena += apellido2 + " - ";
            cadena += tipoSangre + " - ";
            cadena += telefono + " - ";
            cadena += direccion + " - ";
            cadena += escuela + " - ";
            cadena += tutor + " - ";
            cadena += direccionTutor + " - ";
            cadena += telefonoTutor;
            return cadena;
        }
    }
}