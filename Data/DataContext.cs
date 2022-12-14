using Microsoft.EntityFrameworkCore;
using Models;
namespace Data;
public class DataContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<TipoIdioma> TiposIdiomas { get; set; }
    public DbSet<Idioma> Idiomas { get; set; }
    public DbSet<TipoMagia> TiposMagias { get; set; }
    public DbSet<Magia> Magias { get; set; }
    public DbSet<Item> Itens { get; set; }
    public DbSet<TipoArma> TiposArmas { get; set; }
    public DbSet<Arma> Armas { get; set; }
    public DbSet<TipoArmadura> TiposArmaduras { get; set; }
    public DbSet<Armadura> Armaduras { get; set; }
    public DbSet<Designer> Designers { get; set; }
    public DbSet<Skin> Skins { get; set; }
    public DbSet<Antecedente> Antecedentes { get; set; }
    public DbSet<Arquetipo> Arquetipos { get; set; }
    public DbSet<ListaMagia> ListasMagias { get; set; }
    public DbSet<HabilidadeRacial> HabilidadesRaciais { get; set; }
    public DbSet<Classe> Classes { get; set; }
    public DbSet<TracodeClasse> TracosdeClasse { get; set; }
    public DbSet<Classe_TracodeClasse> Classes_TracosdeClasses { get; set; }
    public DbSet<Raca> Racas { get; set; }
    public DbSet<SubRaca> SubRacas { get; set; }
    public DbSet<HabilidadeRacial_Raca> HabilidadesRaciais_Racas { get; set; }
    public DbSet<HabilidadeRacial_SubRaca> HabilidadesRaciais_SubRacas { get; set; }
    public DbSet<TracodeClasse_Arquetipo> TracosdeClasse_Arquetipos { get; set; }
    public DbSet<Magia_ListaMagia> Magias_ListasMagias { get; set; }
    public DbSet<Personagem> Personagens { get; set; }
    public DbSet<Idioma_Personagem> Idiomas_Personagens { get; set; }
    public DbSet<Personagem_Arma> Personagens_Armas { get; set; }
    public DbSet<Personagem_Armadura> Personagens_Armaduras { get; set; }
    public DbSet<Personagem_Item> Personagens_Itens { get; set; }
    public DbSet<Proficiencia_Arma> Proficiencias_Armas { get; set; }
    public DbSet<Proficiencia_Armadura> Proficiencias_Armaduras { get; set; }
    public DbSet<Proficiencia_Item> Proficiencias_Itens { get; set; }

    public DbSet<ASVTracao> ASVTracoes { get; set; }
    public DbSet<VeiculoTerrestre> VeiculosTerrestres { get; set; }
    public DbSet<VeiculoAquatico> VeiculosAquaticos { get; set; }

    public DbSet<Personagem_ASVTracao> Personagens_ASVTracoes { get; set; }
    public DbSet<Personagem_VeiculoTerrestre> Personagens_VeiculosTerrestres { get; set; }
    public DbSet<Personagem_VeiculoAquatico> Personagens_VeiculosAquaticos { get; set; }
    public DbSet<Proficiencia_ASVTracao> Proficiencias_ASVTracoes { get; set; }
    public DbSet<Proficiencia_VeiculoTerrestre> Proficiencias_VeiculosTerrestres { get; set; }
    public DbSet<Proficiencia_VeiculoAquatico> Proficiencias_VeiculosAquaticos { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //IdAntecedente, Nome, Traco, Ideal, Vinculo, Defeito, Habilidade, Proficiencia, IdiomaQtd, Equipamento, ProfArma, ProfArmadura, ProfItem
        {
            modelBuilder.Entity<Antecedente>().HasData(
           //1, Ac??lito, -, -, -, -, -, -, 2, -
           new Antecedente
           {
               IdAntecedente = 1,
               Nome = "Ac??lito",
               Traco = "1 Eu idolatro um her??i particular da minha f??, e constantemente me refiro a seus feitos e exemplos. \n2 Eu consigo encontrar semelhan??as mesmo entre os inimigos mais violentos, com empatia e sempre trabalhando pela paz. \n3 Eu vejo press??gios em cada evento e a????o. Os deuses est??o falando conosco, n??s apenas temos de ouvi-los. \n4 Nada pode abalar minha atitude otimista. \n5 Eu cito (corretamente ou n??o) textos sagrados e prov??rbios em quase qualquer situa????o. \n6 Eu sou tolerante (ou intolerante) a qualquer outra f??, e respeito (ou condeno) a adora????o a outros deuses. \n7 Eu aprecio comida requintada, bebidas e a elite entre o alto escal??o de meu templo. Uma vida dura me irrita. \n8 Eu passei tanto tempo no templo que possuo pouca pr??tica em lidar com as pessoas mundo a fora.",
               Ideal = "1 Tradi????o. As tradi????es ancestrais de adora????o e sacrif??cio devem ser preservadas e perpetradas. (Leal) \n2 Caridade. Eu sempre tento ajudar aqueles em necessidade, n??o importando o custo pessoal. (Bom) \n3 Mudan??a. N??s devemos ajudar a conduzir as mudan??as que os deuses est??o constantemente trabalhando para o mundo. (Ca??tico) \n4 Poder. Eu espero que um dia eu consiga chegar ao topo na hierarquia da minha religi??o. (Leal) \n5 F??. Eu acredito que minha divindade guia minhas a????es. Eu tenho f?? que, se eu trabalhar duro, coisas boas acontecer??o. (Leal) \n6 Aspira????o. Eu busco ser digno da gra??a do meu deus ao corresponder minhas a????es aos seus ensinamentos. (Qualquer)",
               Vinculo = "1 Eu morreria para recuperar uma rel??quia ancestral de minha f??, perdida h?? muito tempo. \n2 Eu ainda terei minha vingan??a contra o templo corrupto que me acusou de heresia. \n3 Eu devo minha vida ao sacerdote que me acolheu quando meus pais morreram. \n4 Tudo o que fa??o, fa??o pelo povo. \n5 Eu farei qualquer coisa para proteger o templo que sirvo. \n6 Eu busco guardar um texto sagrado que meus inimigos dizem ser her??tico e tentam destru??-lo.",
               Defeito = "1 Eu julgo os outros severamente, e a mim mesmo mais ainda. \n2 Eu deposito muita confian??a naqueles que det??m o poder na hierarquia de meu templo. \n3 Minha devo????o ?? muitas vezes me cega perante aqueles que professam a f?? do meu deus. \n4 Meu pensamento ?? inflex??vel. \n5 Eu suspeito de estranhos e sempre espero o pior deles. \n6 Depois de escolher um objetivo, eu fico obcecado em cumpri-lo, at?? mesmo em detrimento de qualquer outra coisa em minha vida.",
               Habilidade = "CARACTER??STICA: ABRIGO DOS FI??IS \nComo um ac??lito, voc?? det??m o respeito daqueles que compartilham de sua f??, e voc?? pode realizar cerim??nias de sua divindade. Voc?? e seus companheiros de aventura podem at?? receber cura e caridade de um templo, santu??rio ou outro posto de sua f??, embora devam fornecer quaisquer componentes materiais necess??rios para as magias. Aqueles que compartilham de sua religi??o v??o garantir a voc?? (mas apenas voc??), custeando um estilo de vida modesto. Voc?? tamb??m pode possuir la??os com um templo espec??fico devotado ?? sua divindade ou pante??o, e fixar resid??ncia nele. Pode ser o templo que voc?? est?? acostumado a servir, se ainda tiver boas rela????es com ele, ou um templo no qual voc?? encontrou um novo lar. Enquanto frequentar as redondezas desse templo, voc?? pode solicitar os sacerdotes para assisti-lo, desde que essa assist??ncia n??o seja de alguma forma perigosa e que voc?? sempre esteja em uma boa rela????o com seu templo.",
               Proficiencia = "Intui????o, Religi??o",
               IdiomaQtd = 2,
               Equipamento = "Um s??mbolo sagrado (um presente dado quando voc?? entrou no templo), um livro de preces ou uma conta de ora????es, 5 varetas de incenso, vestimentas, um conjunto de roupas comuns e uma algibeira contendo 15 po",
           },
           //2, Artes??o de Guilda, -, -, -, -, -, -, 1, -
           new Antecedente
           {
               IdAntecedente = 2,
               Nome = "Artes??o de Guilda",
               Traco = "1 Eu acredito que tudo que valha a pena fazer, vale a pena ser feito direito. Eu n??o posso evitar ??? Eu sou perfeccionista. \n2 Eu sou um esnobe que olha de cima a baixo aqueles que n??o sabem apreciar artes requintadas. \n3 Eu sempre quero aprender como as coisas funcionam e o que deixa as pessoas motivadas. \n4 Eu sou cheio de aforismos espirituosos e tenho um proverbio para cada ocasi??o.\n5 Eu sou grosso com as pessoas que n??o tem o mesmo comprometimento que eu com o trabalho duro e honesto. \n6 Eu gosto de falar longamente sobre minha profiss??o. \n7 Eu n??o gasto meu dinheiro facilmente e vou barganhar incansavelmente para conseguir o melhor acordo poss??vel. \n8 Eu sou bem conhecido pelo meu trabalho e quero ter certeza que todos o apreciam. Eu sempre fico surpreso quando conhe??o pessoas que n??o ouviram falar de mim.",
               Ideal = "1 Comunidade. ?? dever de todo cidad??o civilizado fortalecer os elos da comunidade e a seguran??a da civiliza????o. (Leal) \n2 Generosidade. Meus talentos me foram dados para que eu pudesse us??-los para beneficiar o mundo. (Bom) \n3 Liberdade. Todos deveriam ser livres para perseguir seus pr??prios meios de vida. (Ca??tico) \n4 Gan??ncia. Eu s?? estou aqui pelo dinheiro. (Mau)\n5 Povo. Eu sou cometido com o povo com quem me importo, n??o com ideias. (Neutro) \n6 Aspira????o. Eu trabalho duro para ser o melhor no meu of??cio. (Qualquer)",
               Vinculo = "1 A oficina onde aprendi meu neg??cio ?? o local mais importante do mundo pra mim. \n2 Eu criei um trabalho incr??vel para algu??m, mas descobri que ele n??o era merecedor de receb??-lo. Ainda estou ?? procura de algu??m que seja merecedor. \n3 Eu tenho uma grande d??vida para com minha guilda por fazer de mim a pessoa que sou hoje. \n4 Eu busco riqueza para conseguir o amor de algu??m.\n5 Um dia eu voltarei para a minha guilda e provarei que sou o maior artes??o dentre eles. \n6 Eu irem me vingar das for??as malignas que destru??ram meu local de neg??cios e arruinaram meu estilo de vida.",
               Defeito = "1 Eu farei de tudo para p??r minha m??os em algo raro ou inestim??vel. \n2 Eu rapidamente presumo que algu??m est?? tentando me trapacear. \n3 Ningu??m nunca poder?? saber que eu, certa vez, roubei dinheiro dos cofres da guilda. \n4 Eu nunca estou satisfeito com o que tenho ??? eu sempre quero mais.\n5 Eu mataria para adquirir um t??tulo de nobreza. \n6 Eu sou terrivelmente invejoso com qualquer um que possa ofuscar meu of??cio. Todo lugar que eu vou, estou cercado de rivais. ",
               Habilidade = "CARACTER??STICA: ASSOCIADOS DA GUILDA \nComo um membro cativo e respeitado da guilda, voc?? pode contar com certos benef??cios que a sociedade garante. Seus camaradas, membros da guilda, ir??o prov??lo com hospedagem e comida, se necess??rio, e pagar??o pelo seu funeral se preciso for. Em algumas cidades e vilas, um sal??o da guilda oferece um local central para conhecer outros membros de profiss??o, podendo ser um bom lugar para se conhecer patr??es, aliados e empregados em potencial. Guildas, muitas vezes, det??m tremendos poderes pol??ticos. Se voc?? for acusado de um crime, sua guilda ir?? ampar??-lo se uma boa defesa puder ser apresentada para provar sua inoc??ncia ou se o crime for justific??vel. Voc?? pode, tamb??m, ter acesso a figuras pol??ticas poderosas atrav??s da guilda, se voc?? for um membro bem posicionado. Tais conex??es devem exigir doa????es de dinheiro ou itens m??gicos para os cofres da guilda. Voc?? deve pagar cotas de 5 po por m??s a guilda. Se voc?? n??o pagar, voc?? ir?? contrair uma d??vida para permanecer nas boas gra??as da guilda.",
               Proficiencia = "Intui????o, Persuas??o. \nUm tipo de ferramenta de artes??o",
               IdiomaQtd = 1,
               Equipamento = "Um conjunto de ferramentas de artes??o (?? sua escolha), uma carta de apresenta????o da sua guilda, um conjunto de roupas de viajante e uma algibeira com 15 po"
           },
           //3, Artista, -, -, -, -, -, -, 0, -
           new Antecedente
           {
               IdAntecedente = 3,
               Nome = "Artista",
               Traco = "1 Eu conhe??o uma hist??ria relevante de praticamente todas as situa????es. \n2 Sempre que eu chego em um lugar novo, eu coleto os rumores locais e espalho fofocas. \n3 Eu sou um rom??ntico incorrig??vel, sempre em busca daquele ???algu??m especial.??? \n4 Ningu??m fica com raiva de mim ou perto de mim por muito tempo, j?? que eu posso acabar com qualquer tipo de tens??o. \n5 Eu amo um bom insulto, at?? os direcionados a mim. \n6 Eu fico sentido se eu n??o for o centro das aten????es. \n7 Eu n??o vou me contentar com nada menos que a perfei????o. \n8 Eu mudo de ??nimo ou de pensamento t??o r??pido quando mudo eu mudo de nota em uma can????o.",
               Ideal = "1 Beleza. Quando eu atuo, eu torno o mundo um lugar melhor. (Bom) \n2 Tradi????o. As hist??rias, lendas e can????es do passado nunca devem ser esquecidas, pois elas nos ensinam quem n??s somos. (Leal) \n3 Criatividade. O mundo precisa de novas ideias e a????es ousadas. (Ca??tico) \n4 Gan??ncia. Eu s?? estou aqui pelo dinheiro e pela fama. (Mau) \n5 Povo. Eu gosto de ver os sorrisos nos rostos das pessoas quando eu atuo. Isso ?? tudo que importa. (Neutro) \n6 Honestidade. A arte deve refletir a alma; ela deve vir de dentro e revelar quem realmente somos. (Qualquer)",
               Vinculo = "1 Meu instrumento ?? meu bem mais valioso e ele me lembra de algu??m que eu amo. \n2 Algu??m roubou meu precioso instrumento e, algum dia, eu vou peg??-lo de volta. \n3 Eu quero ser famoso, custe o que custar. \n4 Eu idolatro um her??i dos contos antigos e mensuro meus feitos baseados nessa personalidade. \n5 Eu vou fazer tudo para provar que sou superior eu meu odiado rival. \n6 Eu faria qualquer coisa pelos membros da minha antiga trupe.",
               Defeito = "1 Eu farei de tudo para ganhar fama e renome. \n2 Eu viro um idiota quando vejo um rosto bonito. \n3 Um esc??ndalo me impede de voltar para casa novamente. Esse tipo de problema parece me perseguir por ai. \n4 Eu, certa vez, satirizei um nobre que ainda quer minha cabe??a. Foi um erro que eu adoraria repetir. \n5 Eu tenho problemas em esconder meus verdadeiros sentimentos. Minha l??ngua afiada me mete em confus??o. \n6 Apesar dos meus melhores esfor??os, meus amigos n??o me consideram confi??vel.",
               Habilidade = "CARACTER??STICA: PELA DEMANDA POPULAR \nVoc?? sempre encontra um lugar para atuar, geralmente em tavernas ou estalagens mas, possivelmente em circos, teatros ou at?? em cortes nobres. Em tais lugares, voc?? recebe alojamento e comida modesta ou de patr??es confort??veis, de gra??a (dependendo da qualidade do estabelecimento), contanto que voc?? atue a cada noite. Al??m disso, sua atua????o torna voc?? um tipo de figura local. Quando estranhos reconhecerem voc?? em uma cidade em que voc?? j?? tenha atuado, eles geralmente gostaram de voc??.",
               Proficiencia = "Acrobacia, Atua????o. \nKit de disfarce, um tipo de instrumento musical",
               IdiomaQtd = 0,
               Equipamento = "Um instrumento musical (?? sua escolha), um presente de um admirador (carta de amor, mecha de cabelo ou uma bijuteria), um traje e uma algibeira contendo 15 pe??as de ouro "
           },
           //4, Charlat??o, -, -, -, -, -, -, 0, -
           new Antecedente
           {
               IdAntecedente = 4,
               Nome = "Charlat??o",
               Traco = "1 Eu me apaixono e desapaixono facilmente, e estou sempre em busca de algu??m. \n2 Eu tenho uma piada para cada ocasi??o, especialmente ocasi??es em que o humor ?? inapropriado. \n3 Bajula????o ?? meu truque predileto para conseguir o que eu quero. \n4 Eu sou um jogador nato que n??o consegue resistir a se arriscar por uma poss??vel recompensa. \n5 Eu minto sobre quase tudo, mesmo quando n??o existe qualquer boa raz??o. \n6 Sarcasmo e insultos s??o minhas armas prediletas. \n7 Eu tenho v??rios s??mbolos sagrados comigo, e invoco a divindade que seja mais ??til em cada dado momento. \n8 Eu furto qualquer coisa que eu vejo que possa ter algum valor.",
               Ideal = "1 Independ??ncia. Sou um espirito livre ??? ningu??m me diz o que fazer. (Ca??tico) \n2 Justi??a. Eu nunca roubo de pessoas que n??o podem perder algumas moedas. (Leal) \n3 Caridade. Eu distribuo o dinheiro que adquiro com as pessoas que realmente precisam. (Bom) \n4 Criatividade. Eu nunca fa??o a mesma trapa??a duas vezes. (Ca??tico) \n5 Amizade. Bens materiais vem e v??o. Os la??os de amizade duram pra sempre. (Bom) \n6 Aspira????o. Eu estou determinado a fazer algo por mim mesmo. (Qualquer)",
               Vinculo = "1 Independ??ncia. Sou um espirito livre ??? ningu??m me diz o que fazer. (Ca??tico) \n2 Justi??a. Eu nunca roubo de pessoas que n??o podem perder algumas moedas. (Leal) \n3 Caridade. Eu distribuo o dinheiro que adquiro com as pessoas que realmente precisam. (Bom) \n4 Criatividade. Eu nunca fa??o a mesma trapa??a duas vezes. (Ca??tico) \n5 Amizade. Bens materiais vem e v??o. Os la??os de amizade duram pra sempre. (Bom) \n6 Aspira????o. Eu estou determinado a fazer algo por mim mesmo. (Qualquer)",
               Defeito = "1 N??o resisto um rostinho bonito. \n2 Estou sempre com dividas. Eu gasto meus lucros il??citos com luxurias decadentes mais r??pido do que os ganho... \n3 Estou convencido que ningu??m pode me enganar da forma que eu engano os outros. \n4 Eu sou ganancioso demais pra meu pr??prio bem. Eu n??o consigo resistir a me arriscar se tiver dinheiro envolvido. \n5 Eu n??o resisto a enganar pessoas que s??o mais poderosas que eu. \n6 Eu odeio admitir e vou me odiar por isso, mas, eu vou correr e salvar minha pr??pria pele se as coisas engrossarem.",
               Habilidade = "CARACTER??STICA: IDENTIDADE FALSA \nVoc?? criou uma segunda identidade que inclui documentos, conhecidos estabelecidos e disfarces que possibilitam que voc?? assuma essa persona. Al??m disso, voc?? pode forjar documentos, incluindo papeis oficiais e cartas pessoais, contanto que voc?? tenha visto um exemplo desse tipo de documento ou a caligrafia de quem voc?? est?? tentando copiar.",
               Proficiencia = "Engana????o, Prestidigita????o,  \nKit de disfarce, kit de falsifica????o ",
               IdiomaQtd = 0,
               Equipamento = "Um conjunto de roupas finas, um kit de disfarce, ferramentas de trapa??a, ?? sua escolha (dez garrafas tampadas preenchidas com l??quidos coloridos, um conjunto de dados viciados, um baralho de cartas marcadas ou um anel de sinete de um duque imagin??rio), e uma algibeira contendo 15 pe??as de ouro"
           },
           //5, Criminoso, -, -, -, -, -, -, 0, -
           new Antecedente
           {
               IdAntecedente = 5,
               Nome = "Criminoso",
               Traco = "1 Eu sempre tenho um plano para quando as coisas d??o errado. \n2 Eu estou sempre calmo, n??o importa a situa????o. Eu nunca levanto minha voz ou deixo minhas emo????es me controlarem. \n3 A primeira coisa que fa??o ao chegar a um novo local ?? decorar a localiza????o de coisas valiosas ??? ou onde essas coisas podem estar escondidas. \n4 Eu prefiro fazer um novo amigo a um novo inimigo. \n5 Eu sou incrivelmente receoso em confiar. Aqueles que parecem mais amig??veis geralmente t??m mais a esconder. \n6 Eu n??o presto aten????o aos riscos envolvidos em uma situa????o, nunca me alerte sobre as probabilidades de fracasso. \n7 A melhor maneira de me levar a fazer algo ?? dizendo que eu n??o posso fazer. \n8 Eu explodo ao menor insulto.",
               Ideal = "1 Honra. Eu n??o roubo de irm??os de profiss??o. (Leal) \n2 Liberdade. Correntes foram feitas para serem partidas, assim como aqueles que as forjaram. (Ca??tico) \n3 Caridade. Eu roubo dos ricos para dar aos que realmente precisam. (Bom) \n4 Gan??ncia. Eu farei qualquer coisa para me tornar rico. (Mal) \n5 Povo. Eu sou leal aos meus amigos, n??o a qualquer ideal, e todos sabem que posso viajar at?? o Estige por aqueles que me importo. (Neutro) \n6 Reden????o. H?? uma centelha de bondade em todo mundo. (Bom)",
               Vinculo = "1 Eu estou tentando quitar uma d??vida que tenho com um generoso benfeitor. \n2 Meus ganhos, honestos ou n??o, s??o para sustentar minha fam??lia. \n3 Algo importante foi roubado de mim, e eu vou recuper??-lo. \n4 Eu me tornarei o maior ladr??o que j?? existiu. \n5 Eu sou culpado por um terr??vel crime, espero algum dia poder me redimir. \n6 Algu??m que amo morreu por causa de um erro que cometi. Isso nunca acontecer?? novamente.",
               Defeito = "1 Quando vejo algo valioso, n??o consigo pensar em mais nada, al??m de roub??-lo. \n2 Quando confrontado com uma escolha entre dinheiro e amigo, eu bem que escolho o dinheiro. \n3 Se h?? um plano, eu vou esquec??-lo. Se eu n??o esquec??-lo, vou ignor??-lo. \n4 Eu tenho um 'tique' que revela se estou mentindo. \n5 Eu viro as costas e corro quando as coisas come??am a ficar ruins. \n6 Um inocente foi preso por um crime que eu cometi. Por mim tudo bem.",
               Habilidade = "CARACTER??STICA: CONTATO CRIMINAL \nVoc?? possui contatos de confian??a que agem como seus informantes em uma rede criminosa. Voc?? sabe como se comunicar com eles mesmo em grandes dist??ncias. Voc?? conhece em especial os mensageiros locais, mestres de caravana corruptos, e marinheiros escusos que podem transmitir seus recados. ",
               Proficiencia = "Engana????o, Furtividade, \nUm tipo de kit de jogo, ferramentas de ladr??o",
               IdiomaQtd = 0,
               Equipamento = "Um p?? de cabra, um conjunto de roupas escuras comuns com capuz e uma algibeira contendo 15 po "
           },
           //6, Eremita, -, -, -, -, -, -, 1, -
           new Antecedente
           {
               IdAntecedente = 6,
               Nome = "Eremita",
               Traco = "1 Eu fiquei tanto tempo isolado que raramente falo, preferindo gestos e grunhidos ocasionais. \n2 Eu sou absurdamente sereno, mesmo em face do desespero. \n3 O l??der da minha comunidade tem algo s??bio a dizer sobre cada t??pico, eu estou ansioso para partilhar dessa sabedoria. \n4 Eu sinto uma empatia tremenda por todos que sofrem. \n5 Eu estou alheio a etiqueta e expectativas sociais. \n6 Eu relaciono tudo que acontece comigo a um grande plano c??smico. \n7 Eu, muitas vezes, me perco em meus pensamentos e contempla????o me tornando alheio ao meu redor. \n8 Eu estou trabalhando em uma grande teoria filos??fica e adoro partilhar minhas ideias.",
               Ideal = "1 Bem Maior. Meus dons devem ser partilhados com todos, n??o usados em benef??cio pr??prio (Bom) \n2 L??gica. Emo????es n??o podem obscurecer meus sentidos do que ?? certo e verdade, ou meu pensamento l??gico. (Leal) \n3 Pensamento Livre. Questionamentos e curiosidade s??o os pilares do progresso. (Ca??tico) \n4 Poder. Isolamento e contempla????o s??o caminhos para poderes m??sticos e m??gicos. (Mau) \n5 Viva e Deixe Viver. Se intrometer nos assuntos dos outros s?? traz problemas. (Neutro) \n6 Autoconhecimento. Se voc?? conhece a si mesmo, n??o a mais nada para saber. (Qualquer)",
               Vinculo = "1 Nada ?? mais importante que os outros membros do eremit??rio, ordem ou associa????o. \n2 Eu entrei em reclus??o para me esconder daqueles que ainda devem estar me ca??ando. Algum dia irei confront??los. \n3 Eu ainda busco o esclarecimento que eu perseguia durante meu isolamento e continuo a me iludir. \n4 Eu entrei em reclus??o porque eu amava algu??m que eu n??o podia ter. \n5 Se minha descoberta vir ?? tona, ela poder?? trazer destrui????o ao mundo. \n6 Meu isolamento me deu grande discernimento sobre um grande mal que apenas eu posso destruir.",
               Defeito = "1 Agora que voltei ao mundo, eu desfruto de seus prazeres um pouco demais. \n2 Eu escondo nas sombras, pensamentos sanguin??rios que meu isolamento e medita????o n??o conseguiram apagar. \n3 Eu sou dogm??tico em meus pensamentos e filosofia. \n4 Eu deixo meu desejo de vencer discuss??es ofuscar amizades e harmonia. \n5 Eu me arrisco muito para descobrir um pouco de conhecimento perdido. \n6 Eu gosto de guardar segredos e n??o os partilho com ningu??m.",
               Habilidade = "CARACTER??STICA: DESCOBERTA \nA calma reclus??o da seu eremit??rio prolongado lhe deu acesso a descobertas ??nicas e poderosas. A natureza exata dessas revela????es depende da natureza da sua reclus??o. Poderia ser uma grande verdade sobre o cosmos, os deuses, os poderosos seres de outros planos ou as for??as da natureza. Poderia ser um local nunca visto por mais ningu??m. Voc?? pode ter descoberto um fato que a muito foi esquecido, ou desenterrado uma rel??quia do passado que poderia reescrever a hist??ria. Poderia ser uma informa????o que seria prejudicial para as pessoas respons??veis pelo seu exilio, consequentemente, a raz??o que fez voc?? voltar para a sociedade. Converse com o Mestre para determinar os detalhes da sua descoberta e o impacto na campanha.",
               Proficiencia = "Medicina, Religi??o,  \nKit de herbalismo",
               IdiomaQtd = 1,
               Equipamento = "Um estojo de pergaminho cheio de notas dos seus estudos e ora????es, um cobertor de inverno, um conjunto de roupas comuns, um kit de herbalismo e 5 po. "
           },
           //7, Forasteiro, -, -, -, -, -, -, 1, -
           new Antecedente
           {
               IdAntecedente = 7,
               Nome = "Forasteiro",
               Traco = "1 Eu fui guiado por uma sede de viagens que me levou a abandonas meu lar. \n2 Eu cuido dos meus amigos como se eles fossem filhotes rec??m-nascidos. \n3 Certa vez, eu corri quarenta quil??metros sem parar alertar meu cl?? da aproxima????o de uma horda orc. Eu faria de novo se fosse necess??rio. \n4 Eu tenho uma li????o pra cada situa????o, aprendida observando a natureza. \n5 Eu n??o vejo lugar para o povo rico e educado. Dinheiro e modos n??o v??o salv??-lo de um urso-coruja faminto. \n6 Estou sempre pegando coisas, distraidamente brincando com elas e, ??s vezes, quebrando-as. \n7 Eu me sinto muito mais confort??vel entre animais que entre pessoas. \n8 Eu fui, de fato, criado por lobos.",
               Ideal = "1 Mudan??a. A vida ?? como as esta????es, em constante mudan??a, e n??s devemos mudar com ela. (Ca??tico) \n2 Bem maior. ?? responsabilidade de todos trazer a maior felicidade para toda a tribo. (Bom) \n3 Honra. Se eu me desonrar, eu desonrarei todo o meu cl??. (Leal) \n4 For??a. O mais forte deve governar. (Mau) \n5 Natureza. O mundo natural ?? mais importante que todas as constru????es da civiliza????o. (Neutro) \n6 Gloria. Eu devo adquirir gloria em batalha, para mim e para meu cl??. (Qualquer)",
               Vinculo = "1 Minha fam??lia, cl?? ou tribo ?? a coisa mais importante na minha vida, mesmo quando eles est??o longe. \n2 Uma ofensa a natureza intocada do meu lar ?? uma ofensa a mim. \n3 Eu trarei uma f??ria terr??vel aos malfeitores que destru??ram minha terra natal. \n4 Eu sou o ??ltimo da minha tribo e cabe a mim garantir que seus nomes fa??am parte das lendas. \n5 Eu sofro de vis??es terr??veis de um desastre vindouro, e farei qualquer coisa para impedi-lo. \n6 ?? meu dever prover filhos para sustentar minha tribo.",
               Defeito = "1 Sou muito apaixonado por cerveja, vinho e outras bebidas. \n2 N??o existe lugar para precau????o em uma vida vivida ao m??ximo. \n3 Eu lembro de cada insulto que sofri e nutro um ressentimento silencioso contra qualquer um que j?? tenha me insultado \n4 Eu tenho dificuldade em confiar em membros de outras ra??as, tribos ou sociedades. \n5 A viol??ncia ?? minha resposta para quase todos os obst??culos. \n6 N??o espere que eu salve aqueles que n??o conseguem se virar sozinhos. ?? a lei da natureza que os fortes prosperem e os fracos pere??am.",
               Habilidade = "CARACTER??STICA: ANDARILHO Voc?? tem uma mem??ria excelente para mapas e geografia, e voc?? sempre pode recobrar o plano geral de terrenos, assentamentos ou outras caracter??sticas ao seu redor. Al??m disso, voc?? pode encontrar comida e ??gua fresca para voc?? a at?? cinco outras pessoas a cada dia, considerando que a terra ofere??a bagas, pequenas frutas, ??gua e similares.",
               Proficiencia = "Atletismo, Sobreviv??ncia, \nUm tipo de instrumento musical",
               IdiomaQtd = 1,
               Equipamento = "Um bord??o, uma armadilha de ca??a, um fetiche de um animal que voc?? matou, um conjunto de roupas de viajante e uma algibeira contendo 10 po"
           },
           //8, Her??i do Povo, -, -, -, -, -, -, 0, -
           new Antecedente
           {
               IdAntecedente = 8,
               Nome = "Her??i do Povo",
               Traco = "1 Eu julgo as pessoas por suas a????es, n??o por suas palavras. \n2 Se algu??m est?? em apuros, eu estou sempre pronto para ajudar. \n3 Quando eu fixo minha mente em algo, eu sigo esse caminho, n??o importa o que fique no caminho. \n4 Eu possuo um forte senso de justi??a e sempre tento encontrar a solu????o mais equilibrada para as discuss??es. \n5 Eu confio em minhas habilidades e farei o que for necess??rio para que os outros confiem tamb??m. \n6 Pensar ?? para os outros, eu prefiro agir. \n7 Eu abuso de palavras longas na tentativa de soar inteligente. \n8 Eu me entedio f??cil. Para onde devo ir para me encontrar com meu destino?",
               Ideal = "1 Respeito. As pessoas merecem ser tratadas com dignidade e respeito. (Bom) \n2 Justi??a. Ningu??m merece tratamento diferenciado perante a lei, muito menos estar acima dela. (Leal) \n3 Liberdade. N??o pode haver permiss??o para tiranos oprimirem o povo. (Ca??tico) \n4 For??a. Se eu ficar forte, eu posso pegar tudo o que eu quiser ??? o que eu desejar. (Mal) \n5 Sinceridade. N??o h?? nada de bom em fingir ser algo que n??o sou. (Neutro) \n6 Destino. Nada, nem ningu??m, pode me manter longe do meu chamado. (Qualquer)",
               Vinculo = "1 Eu tenho fam??lia, embora n??o fa??a a m??nima ideia de onde eles est??o, espero encontr??-los um dia. \n2 Eu trabalho a terra, eu amo a terra e eu vou defender a terra. \n3 Um nobre orgulhoso me deu uma bela surra, e eu vou ter minha vingan??a em qualquer valent??o que encontrar. \n4 Minhas ferramentas s??o s??mbolo de minha vida passada, eu as carregarei para nunca me esquecer de minhas origens. \n5 Eu devo proteger aqueles que n??o podem se defender. \n6 Gostaria que meu amor viesse comigo para seguir meu destino.",
               Defeito = "1 O tirano que comanda minha terra n??o vai parar at?? ver meu cad??ver. \n2 Eu estou convencido sobre o significado do meu destino, e cego aos riscos e falhas. \n3 As pessoas que me conhecem desde crian??a sabem de um vergonhoso segredo meu, eu n??o poderei voltar para casa nunca. \n4 Eu tenho uma fraqueza pelos v??cios da cidade, especialmente a bebedeira. \n5 Secretamente, eu acredito que as coisas estariam melhores se algum tirano comandasse a regi??o. \n6 Eu tenho dificuldades em confiar em meus aliados.",
               Habilidade = "CARACTER??STICA: HOSPITALIDADE R??STICA J?? que voc?? ascendeu da categoria de pessoas comuns at?? onde voc?? est?? agora, ?? f??cil se misturar a eles. Voc?? pode encontrar lugar entre os camponeses para se esconder, descansar ou se recuperar, a menos que isso ofere??a um risco direto a eles. Eles o esconder??o da lei e de qualquer um que venha perguntando por voc??, desde que n??o tenham que arriscar suas vidas. ",
               Proficiencia = "Adestrar Animais, Sobreviv??ncia, \nUm tipo de ferramenta de artes??o, ve??culos (terrestre)",
               IdiomaQtd = 0,
               Equipamento = " Um conjunto de ferramentas de artes??o (?? sua escolha), uma p??, um pote de ferro, um conjunto de roupas comuns e uma algibeira contendo 10 po "
           },
           //9, Marinheiro, -, -, -, -, -, -, 0, -
           new Antecedente
           {
               IdAntecedente = 9,
               Nome = "Marinheiro",
               Traco = "1 Meus amigos sabem que podem contar comigo pro que der e vier. \n2 Eu trabalho duro para que possa me divertir muito quando o trabalho estiver pronto. \n3 Eu gosto de navegar para novos portos e fazer novas amizades acompanhado de uma jarra de cerveja. \n4 Eu modifico alguns fatos para o bem de uma boa hist??ria. \n5 Pra mim, uma briga de taverna ?? uma ??tima forma de conhecer uma nova cidade. \n6 Eu nunca deixo passar uma aposta amig??vel. \n7 Meu vocabul??rio ?? t??o sujo quanto o covil de um otyugh. \n8 Eu gosto de trabalhos bem feitos, especialmente se eu puder convencer algu??m a faz??-los.",
               Ideal = "1 Respeito. A coisa que mantem um navio unido ?? o respeito m??tuo entre o capit??o e a tripula????o. (Bem) \n2 Justi??a. Todos n??s fazemos o trabalho, portanto, todos partilhamos os esp??lios. (Leal) \n3 Liberdade. O mar ?? liberdade ??? a liberdade de ir aonde quiser. (Ca??tico) \n4 Dom??nio. Eu sou um predador e os outros navios no mar s??o minhas presas. (Mau) \n5 Povo. Eu sou apegado aos meus companheiros de tripula????o, n??o a ideais. (Neutro) \n6 Aspira????o. Algum dia eu serei dono do meu pr??prio navio e tra??arei meu pr??prio destino. (Qualquer)",
               Vinculo = "1 Eu sou leal ao meu capit??o, primeiramente, o resto vem em segundo. \n2 O navio ?? o mais importante ??? tripulantes e capit??es vem e v??o. \n3 Eu sempre me lembrarei do meu primeiro navio. \n4 Em uma cidade portu??ria, eu tenho uma amante que quase me roubou do mar. \n5 Eu fui enganado na divis??o dos esp??lios e eu quero o que me ?? devido. \n6 Cru??is piratas mataram meu capit??o e companheiros de tripula????o, saquearam nosso navio e me deixaram para morrer. A vingan??a ser?? minha.",
               Defeito = "1 Eu sigo ordens, mesmo que eu ache que est??o erradas. \n2 Eu direi qualquer coisa para evitar trabalho extra. \n3 Certa vez, algu??m duvidou da minha coragem, eu nunca recuo, n??o importa o qu??o perigosa seja a situa????o. \n4 Quando come??o a beber, ?? dif??cil pra mim parar. \n5 Eu n??o resisto a uma sacolinha de moedas dando sopa ou outras bugigangas que encontro. \n6 Meu orgulho provavelmente levar?? a minha destrui????o.",
               Habilidade = "CARACTER??STICA: PASSAGEM DE NAVIO \nQuando voc?? precisar, voc?? pode conseguir passagem de gra??a em um navio para voc?? e seus companheiros de aventura. Voc?? precisa viajar no navio em que voc?? trabalhou ou em outro navio com o qual voc?? teve boas 139 rela????es (talvez um comandado por um ex-companheiro de tripula????o). Por ser um favor, voc?? n??o pode solicitar uma programa????o ou rota que atenda ?? todas as suas necessidades. Seu Mestre determina quanto tempo levar?? pra chegar aonde voc?? quer ir. Em troca da passagem gr??tis, espera-se que voc?? e seus companheiros ajudem a tripula????o durante a viagem. ",
               Proficiencia = "Atletismo, Percep????o, \nFerramentas de navegador, ve??culo (aqu??tico)",
               IdiomaQtd = 0,
               Equipamento = "Uma malagueta (clava), 15 metros de corda de seda, uma amuleto da sorte como um p?? de coelho ou uma pequena pedra com um furo no centro (ou voc?? pode rolar uma bugiganga da tabela Bugigangas no cap??tulo 5), um conjunto de trajes comuns e uma algibeira contendo 10 po "
           },
           //10, Nobre, -, -, -, -, -, -, 1, -
           new Antecedente
           {
               IdAntecedente = 10,
               Nome = "Nobre",
               Traco = "1 Minha bajula????o eloquente faz com que todos com quem eu converse se sintam a pessoa mais maravilhosa e importante do mundo. \n2 As pessoas comuns me amam por minha bondade e generosidade. \n3 Ningu??m pode duvidar, olhando para o meu porte real, que estou acima das massas plebeias. \n4 Eu tenho grande cuidado de sempre estar no meu melhor e seguir as ??ltimas modas. \n5 Eu n??o gosto de sujar minhas m??os, e eu n??o vou ser pego em acomoda????es inadequadas. \n6 Apesar da minha origem nobre, eu n??o estou acima dos outros. O sangue ?? um s??. \n7 Meu apoio, uma vez perdido, n??o volta. \n8 Se voc?? me ferir, eu irei esmag??-lo, arruinar seu nome, e salgar seus campos.",
               Ideal = "1 Respeito. O respeito a mim ?? devido por causa da minha posi????o, mas todas as pessoas, independentemente da posi????o merecem ser tratados com dignidade. (Bom) \n2 Responsabilidade. ?? o meu dever respeitar a autoridade daqueles acima de mim, assim como aqueles abaixo de mim devem me respeitar. (Leal) \n3 Independ??ncia. Devo provar que posso me cuidar sem os mimos da minha fam??lia. (Ca??tico) \n4 Poder. Se eu puder alcan??ar mais poder, ningu??m vai me dizer o que fazer. (Mau) \n5 Fam??lia. O sangue corre mais grosso que a ??gua. (Qualquer) \n6 Obriga????o Nobre. ?? o meu dever proteger e cuidar das pessoas abaixo de mim. (Bom)",
               Vinculo = "1 Eu vou encarar qualquer desafio para ganhar a aprova????o da minha fam??lia. \n2 A alian??a da minha casa com outra fam??lia nobre deve ser mantida a todo custo. \n3 Nada ?? mais importante do que os outros membros da minha fam??lia. \n4 Eu sou apaixonado pela herdeira de uma fam??lia que a minha fam??lia despreza. \n5 Minha lealdade ao meu soberano ?? inabal??vel. \n6 As pessoas comuns devem me ver como um her??i do povo.",
               Defeito = "\n1 Eu secretamente acredito que todos est??o abaixo de mim. \n2 Eu escondo um segredo verdadeiramente escandaloso que poderia arruinar minha fam??lia para sempre. \n3 Muitas vezes eu ou??o insultos e amea??as veladas em cada palavra dirigida a mim, e me irrito muito r??pido. \n4 Eu tenho um desejo insaci??vel por prazeres carnais. \n5 Na verdade, o mundo gira ao meu redor. \n6 Pelas minhas palavras e a????es, muitas vezes, envergonho minha fam??lia.",
               Habilidade = "CARACTER??STICA: POSI????O PRIVILEGIADA \nGra??as a sua origem nobre, as pessoas tendem a pensar o melhor de voc??. Voc?? ?? bem-vindo na alta sociedade e as pessoas assumem que voc?? tem o direito de estar onde est??. As pessoas comuns fazem todos os esfor??os para acomod??-lo e evitar seu desprazer, e outros nobres o tratam como um membro da mesma classe social. Voc?? pode conseguir uma audi??ncia com um nobre local se precisar. ",
               Proficiencia = "Hist??ria, Persuas??o, \nUm tipo de kit de jogos ",
               IdiomaQtd = 1,
               Equipamento = "Um conjunto de trajes finos, um anel de sinete, um pergaminho de linhagem e uma algibeira contendo 25 po"
           },
           //11, ??rf??o, -, -, -, -, -, -, 0, -
           new Antecedente
           {
               IdAntecedente = 11,
               Nome = "??rf??o",
               Traco = "1 Eu escondo peda??os de comida e bugigangas em meus bolsos. \n2 Eu pergunto um monte e coisas. \n3 Eu gosto de me espremer em locais pequenos onde ningu??m possa me alcan??ar. \n4 Eu durmo encostado em um muro ou ??rvore, abra??ado com todas as minhas posses. \n5 Eu como feito um porco e tenho maus modos. \n6 Eu acho que todos que s??o gentis comigo tem segundas inten????es. \n7 Eu n??o gosto de tomar banho. \n8 Eu digo na cara o que as outras pessoas insinuam ou escondem.",
               Ideal = "1 Respeito. Todas as pessoas, ricas ou pobres, merecem respeito. (Bom) \n2 Comunidade. N??s temos que tomar conta uns dos outros, porque ningu??m mais o far??. (Leal) \n3 Mudan??a. Os baixos se erguer??o e os altos ir??o tombar. A mudan??a ?? a natureza das coisas. (Ca??tico) \n4 Retribui????o. Os ricos precisam ver como a vida e morte ?? nas sarjetas. (Mau) \n5 Povo. Eu ajudo as pessoas que me ajudam ??? ?? isso que nos mantem vivos. (Neutro) \n6 Aspira????o. Eu vou provar que sou merecedor de uma vida melhor. (Qualquer)",
               Vinculo = "1 Minha cidade ou vila ?? meu lar, e eu vou lutar para defend??lo. \n2 Eu patrocino um orfanato para que outros n??o passem pelo que fui for??ado a passar. \n3 Eu devo minha sobreviv??ncia a outros ??rf??o que me ensinou a vida nas ruas. \n4 Eu tenho uma d??vida que nunca poderei pagar com uma pessoa que teve pena de mim. \n5 Eu sai da minha vida de pobreza roubando uma pessoa importante, eu sou procurado por isso. \n6 Ningu??m deveria ter suportar as dificuldades pelas quais passei.",
               Defeito = "1 Se eu estiver em desvantagem, eu vou fugir de uma briga. \n2 Ouro parece ser muito dinheiro pra mim, e eu faria praticamente qualquer coisa por mais dele. \n3 Eu nunca vou confiar em ningu??m plenamente, al??m de mim mesmo. \n4 Eu prefiro matar algu??m enquanto dorme que uma luta justa. \n5 N??o ?? roubo se eu preciso mais que outra pessoa. \n6 As pessoas que n??o podem se virar sozinhas, tem o que merecem.",
               Habilidade = "CARACTER??STICA: SEGREDOS DA CIDADE \nVoc?? conhece os padr??es secretos e o fluxo das cidades e pode encontrar passagens atrav??s da expans??o urbana que os outros deixariam passar. Quando voc?? n??o estiver em combate, voc?? (e os companheiros que voc?? guiar) podem viajar entre dois locais quaisquer na cidade com o dobro da velocidade normalmente permitida. ",
               Proficiencia = "Furtividade, Prestidigita????o, \nKit de disfarce, ferramentas de ladr??o ",
               IdiomaQtd = 0,
               Equipamento = "Uma faca pequena, um mapa da cidade em que voc?? cresceu, um rato de estima????o, um pequeno objeto para lembrar dos seus pais, um conjunto de roupas comuns e uma algibeira contendo 10 pe??as de ouro"
           },
           //12, S??bio, -, -, -, -, -, -, 2, -
           new Antecedente
           {
               IdAntecedente = 12,
               Nome = "S??bio",
               Traco = "1 Eu uso palavras polissil??bicas para endossar minha impress??o de grande erudi????o. \n2 Eu j?? li todos os livros das grandes bibliotecas ??? ou gosto de me vangloriar e dizer que li. \n3 Eu costumo ajudar os outros que n??o s??o t??o inteligentes quanto eu, e pacientemente explico tudo quantas vezes forem necess??rias. \n4 Nada para mim ?? melhor que um bom mist??rio. \n5 Eu voluntariamente escuto cada lado, e seus argumentos, antes de tomar uma decis??o final. \n6 Eu...falo...lentamente...ao...conversar...com idiotas...que tentam...se comparar...comigo. \n7 E sou horr??vel e estranho em situa????es sociais. \n8 Estou convencido de que todos tentam roubar os meus segredos de mim.",
               Ideal = "1 Conhecimento. O caminho para o poder e o auto aperfei??oamento ?? atrav??s do conhecimento. (Neutro) \n2 Beleza. O que ?? belo nos mostra o que est?? al??m disso perto do que ?? verdadeiro. (Bom) \n3 Logica. Emo????es n??o devem nublar seu pensamento l??gico. (Leal) \n4 Sem Limites. Nada pode apaziguar a possibilidade infinita de toda a exist??ncia. (Ca??tico) \n5 Poder. Conhecimento ?? o caminho para o poder e a domina????o. (Mau) \n6 Auto Aperfei??oamento. O objetivo de uma vida de estudos ?? a melhoria de si mesmo. (Qualquer)",
               Vinculo = "1 ?? meu dever proteger meus estudantes. \n2 Eu guardo um texto ancestral que cont??m terr??veis segredos que n??o podem cair em m??os erradas. \n3 Eu trabalho para preservar uma biblioteca, universidade, arquivo de escribas ou monast??rio. \n4 O trabalho a da minha vida ?? uma s??rie de tomos relatando um campo de conhecimento espec??fico. \n5 Eu venho procurando a minha vida inteira pela resposta de certa quest??o. \n6 Eu vendi minha alma por conhecimento. Espero realizar grandes feitos para ganh??-la de volta.",
               Defeito = "1 Eu me distraio facilmente com a promessa de informa????o. \n2 Muitas pessoas gritam e correm quando veem um corruptor. Eu paro e tomo notas de sua anatomia. \n3 Desvendar um mist??rio ancestral pode muito bem valer o pre??o e uma civiliza????o. \n4 E prefiro solu????es ??bvias a complicadas. \n5 Eu falo sem antes pensar em minhas palavras, invariavelmente insultando outros. \n6 Eu n??o consigo guardar um segredo para salvar minha vida. Ou a vida de qualquer outra pessoa.",
               Habilidade = "CARACTER??STICA: PESQUISADOR \nQuando tentar obter ou recuperar um fragmento de conhecimento que voc?? n??o saiba, voc?? descobre aonde e com quem pode obter essa informa????o. Normalmente ela ser?? adquirida em bibliotecas, arquivos de escribas, universidade ou outros s??bios e pessoas aptas. Seu Mestre pode decidir que o conhecimento que busca est?? escondido em algum lugar quase inacess??vel, ou ?? simplesmente imposs??vel de se obter. Desvendar os 142 segredos mais profundos do multiverso pode requerer uma campanha inteira. ",
               Proficiencia = "Arcanismo, Hist??ria",
               IdiomaQtd = 2,
               Equipamento = "Um vidro de tinta escura, uma pena, uma faca pequena, uma carta de um falecido colega perguntando a voc?? algo que voc?? nunca ter?? a chance de responder, um conjunto de roupas comuns e uma algibeira contendo 10 po "
           },
           //13, Soldado, -, -, -, -, -, -, 0, -
           new Antecedente
           {
               IdAntecedente = 13,
               Nome = "Soldado",
               Traco = "1 Eu sou sempre polido e respeitoso. \n2 Eu sou assombrado pelas mem??rias da guerra. N??o consigo tirar aquelas imagens da minha cabe??a. \n3 Eu perdi muitos amigos, e sou muito devagar para fazer novos. \n4 Eu tenho muitas hist??rias de inspira????o e cautela da ??poca de minha experi??ncia militar que s??o relevantes em todas as situa????es de combate. \n5 Eu n??o consigo encarar um c??o infernal sem vacilar. \n6 Eu gosto de ser forte e de quebrar coisas. \n7 Eu tenho um senso de humor grosseiro. \n8 Eu enfrento os problemas de frente. Uma solu????o direta ?? o melhor caminho para o sucesso.",
               Ideal = "1 Bem Maior. Nosso destino ?? dar nossas vidas em defesa de terceiros. (Bom) \n2 Responsabilidade. Eu fa??o o que tenho que fazer e obede??o apenas a autoridade. (Leal) \n3 Independ??ncia. Quando pessoas seguem ordens cegas elas apoiam um tipo de tirania. (Ca??tico) \n4 For??a. A vida ?? como uma guerra, o mais forte vence. (Mau) \n5 Viva e Deixa Viver. Ideais n??o valem a pena se voc?? matar, ou for ?? guerra por eles. (Neutro) \n6 Aspira????o. Minha cidade, na????o ou meu povo, s??o tudo o que importa para mim. (Qualquer)",
               Vinculo = "1 Eu ainda daria a minha vida pelas pessoas com quem servi. \n2 Algu??m salvou minha vida no campo de batalha. Desde aquele dia eu nunca deixo nenhum amigo para tr??s. \n3 Minha honra ?? minha vida. \n4 Eu nunca esquecerei a destruidora derrota que minha companhia sofreu ou os inimigos que a causaram. \n5 Aqueles que lutam ao meu lado s??o aqueles por quem vale a pena morrer. \n6 Eu luto por aqueles que n??o podem lutar por si mesmos.",
               Defeito = "1 O inimigo monstruoso que enfrentei em uma batalha ainda me deixa tremendo de medo. \n2 Eu tenho pouco respeito por aqueles que n??o se provam bons combatentes. \n3 Eu cometi um terr??vel erro em batalha, o que custou muitas vidas ??? eu farei de tudo para manter esse erro em segredo. \n4 Meu ??dio por meus inimigos ?? cego e irracional. \n5 Eu obede??o a lei, mesmo se a lei trouxer a ang??stia. \n6 Eu prefiro comer minha armadura a admitir que estou errado.",
               Habilidade = "CARACTER??STICA: PATENTE MILITAR \nVoc?? possui uma patente militar da sua ??poca como soldado. Soldados leais ?? sua antiga organiza????o reconhecem sua autoridade e influ??ncia, e o prestam defer??ncia se forem de uma patente mais baixa. Voc?? pode invocar sua patente para exercer influ??ncia sobre soldados, e requisitar equipamentos simples ou cavalos para uso tempor??rio. Voc?? tamb??m pode ganhar acesso a acampamentos militares aliados, e fortalezas onde usa patente ?? reconhecida. ",
               Proficiencia = "Atletismo, Intimida????o ",
               IdiomaQtd = 0,
               Equipamento = "Uma ins??gnia de patente, um fetiche obtido de um inimigo ca??do (uma adaga, l??mina partida ou tira de estandarte), um conjunto de dados de osso ou baralho, um conjunto de roupas comuns e uma algibeira contendo 10 po "
           }
           );
        }
        //IdTipoArma, Tipo
        {
            modelBuilder.Entity<TipoArma>().HasData(
            //1, Arma Simples Corpo-a-Corpo
            new TipoArma
            {
                IdTipoArma = 1,
                Tipo = "Arma Simples Corpo-a-Corpo"
            },
            //2, Arma Simples ?? Dist??ncia
            new TipoArma
            {
                IdTipoArma = 2,
                Tipo = "Arma Simples ?? Dist??ncia"
            },
            //3, Arma Marcial Corpo-a-Corpo
            new TipoArma
            {
                IdTipoArma = 3,
                Tipo = "Arma Marcial Corpo-a-Corpo"
            },
            //4, Arma Marcial ?? Dist??ncia
            new TipoArma
            {
                IdTipoArma = 4,
                Tipo = "Arma Marcial ?? Dist??ncia"
            }
            );

            //IdArma, DadoDano, Propriedade, Nome, Peso, Preco, IdTipoArma

            modelBuilder.Entity<Arma>().HasData(
            //1, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 1,
                DadoDano = "1d4 perfurante",
                Propriedade = "Acuidade, leve, arremesso (dist??ncia 6/18)",
                Nome = "Adaga",
                Peso = "0.5 Kg",
                Preco = "2 Pe??as de Ouro",
                IdTipoArma = 1
            },
            //2, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 2,
                DadoDano = "1d6 perfurante",
                Propriedade = "Arremesso (dist??ncia 9/36)",
                Nome = "Azagaia",
                Peso = "1 Kg",
                Preco = "5 Pe??as de Prata",
                IdTipoArma = 1
            },
            //3, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 3,
                DadoDano = "1d6 concuss??o",
                Propriedade = "Vers??til (1d8)",
                Nome = "Bord??o",
                Peso = "2 Kg",
                Preco = "2 Pe??as de Prata",
                IdTipoArma = 1
            },
            //4, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 4,
                DadoDano = "1d8 concuss??o",
                Propriedade = "Pesada, duas m??os",
                Nome = "Clava Grande",
                Peso = "5 Kg",
                Preco = "2 Pe??as de Prata",
                IdTipoArma = 1
            },
            //5, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 5,
                DadoDano = "1d4 cortante",
                Propriedade = "Leve",
                Nome = "Foice Curta",
                Peso = "1 Kg",
                Preco = "1 Pe??a de Ouro",
                IdTipoArma = 1
            },
            //6, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 6,
                DadoDano = "1d6 perfurante",
                Propriedade = "Arremesso (dist??ncia 6/18), vers??til (1d8)",
                Nome = "Lan??a",
                Peso = "1.5 Kg",
                Preco = "1 Pe??a de Ouro",
                IdTipoArma = 1
            },
            //7, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 7,
                DadoDano = "1d6 concuss??o",
                Propriedade = "",
                Nome = "Ma??a",
                Peso = "2 Kg",
                Preco = "5 Pe??as de Ouro",
                IdTipoArma = 1
            },
            //8, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 8,
                DadoDano = "1d6 cortante",
                Propriedade = "Leve, arremesso (dist??ncia 6/18)",
                Nome = "Machadinha",
                Peso = "1 Kg",
                Preco = "5 Pe??as de Ouro",
                IdTipoArma = 1
            },
            //9, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 9,
                DadoDano = "1d4 concuss??o",
                Propriedade = "Leve, arremesso (dist??ncia 6/18)",
                Nome = "Martelo Leve",
                Peso = "1 Kg",
                Preco = "2 Pe??as de Ouro",
                IdTipoArma = 1
            },
            //10, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 10,
                DadoDano = "1d4 concuss??o",
                Propriedade = "Leve",
                Nome = "Porrete",
                Peso = "1 Kg",
                Preco = "1 Pe??a de Prata",
                IdTipoArma = 1
            },
            //11, -, -, -, -, -, 2
            new Arma
            {
                IdArma = 11,
                DadoDano = "1d6 perfurante",
                Propriedade = "Muni????o (dist??ncia 24/96), duas m??os",
                Nome = "Arco Curto",
                Peso = "1 Kg",
                Preco = "25 Pe??as de Ouro",
                IdTipoArma = 2
            },
            //12, -, -, -, -, -, 2
            new Arma
            {
                IdArma = 12,
                DadoDano = "1d8 perfurante",
                Propriedade = "Muni????o (dist??ncia 24/96), regarga, duas m??os",
                Nome = "Beste Leve",
                Peso = "2.5 Kg",
                Preco = "25 Pe??as de Ouro",
                IdTipoArma = 2
            },
            //13, -, -, -, -, -, 2
            new Arma
            {
                IdArma = 13,
                DadoDano = "1d4 perfurante",
                Propriedade = "Acuidade, arremesso (dist??ncia 6/18)",
                Nome = "Dardo",
                Peso = "0.1 Kg",
                Preco = "5 Pe??as de Cobre",
                IdTipoArma = 2
            },
            //14, -, -, -, -, -, 2
            new Arma
            {
                IdArma = 14,
                DadoDano = "1d4 concuss??o",
                Propriedade = "Muni????o (dist??ncia 9/36)",
                Nome = "Funda",
                Peso = "-",
                Preco = "1 Pe??a de Prata",
                IdTipoArma = 2
            },
            //15, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 15,
                DadoDano = "1d10 cortante",
                Propriedade = "Pesada, alcance, duas m??os",
                Nome = "Alabarda",
                Peso = "3 Kg",
                Preco = "20 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //16, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 16,
                DadoDano = "1d6 cortante",
                Propriedade = "Acuidade, leve",
                Nome = "Cimitarra",
                Peso = "1.5 Kg",
                Preco = "25 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //17, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 17,
                DadoDano = "1d4 cortante",
                Propriedade = "Acuidade, alcance",
                Nome = "Chicote",
                Peso = "1.5 Kg",
                Preco = "2 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //18, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 18,
                DadoDano = "1d6 perfurante",
                Propriedade = "Acuidade, leve",
                Nome = "Espada Curta",
                Peso = "1 Kg",
                Preco = "10 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //19, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 19,
                DadoDano = "2d6 cortante",
                Propriedade = "Pesada, duas m??os",
                Nome = "Espada Grande",
                Peso = "3 Kg",
                Preco = "50 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //20, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 20,
                DadoDano = "1d8 cortante",
                Propriedade = "Vers??til (1d10)",
                Nome = "Espada Longa",
                Peso = "1.5 Kg",
                Preco = "15 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //21, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 21,
                DadoDano = "1d10 cortante",
                Propriedade = "Pesada, alcance, duas m??os",
                Nome = "Glaive",
                Peso = "3 Kg",
                Preco = "20 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //22, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 22,
                DadoDano = "1d12 perfurante",
                Propriedade = "Alcance, especial",
                Nome = "Lan??a de Montaria",
                Peso = "3 Kg",
                Preco = "3 Kg",
                IdTipoArma = 3
            },
            //23, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 23,
                DadoDano = "1d8 perfurante",
                Propriedade = "",
                Nome = "Ma??a Estrela",
                Peso = "2 Kg",
                Preco = "15 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //24, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 24,
                DadoDano = "1d12 cortante",
                Propriedade = "Pesada, duas m??os",
                Nome = "Machado Grande",
                Peso = "3.5 Kg",
                Preco = "30 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //25, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 25,
                DadoDano = "1d8 cortante",
                Propriedade = "Vers??til (1d10)",
                Nome = "Macado de Batalha",
                Peso = "2 Kg",
                Preco = "10 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //26, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 26,
                DadoDano = "2d6 concuss??o",
                Propriedade = "Pesada, duas m??os",
                Nome = "Malho",
                Peso = "5 Kg",
                Preco = "10 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //27, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 27,
                DadoDano = "1d8 concuss??o",
                Propriedade = "",
                Nome = "Mangual",
                Peso = "1 Kg",
                Preco = "10 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //28, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 28,
                DadoDano = "1d8 concuss??o",
                Propriedade = "Vers??til (1d10)",
                Nome = "Martelo de Guerra",
                Peso = "1 Kg",
                Preco = "15 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //29, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 29,
                DadoDano = "1d8 perfurante",
                Propriedade = "",
                Nome = "Picareta de Guerra",
                Peso = "1 Kg",
                Preco = "5 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //30, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 30,
                DadoDano = "1d8 perfurante",
                Propriedade = "Acuidade",
                Nome = "Rapieira",
                Peso = "1 Kg",
                Preco = "25 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //31, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 31,
                DadoDano = "1d6 perfurante",
                Propriedade = "Arremesso (6/18), vers??til(1d8)",
                Nome = "Tridente",
                Peso = "2 Kg",
                Preco = "5 Pe??as de Ouro",
                IdTipoArma = 3
            },
            //32, -, -, -, -, -, 4
            new Arma
            {
                IdArma = 32,
                DadoDano = "1d8 perfurante",
                Propriedade = "Muni????o (dist??ncia 45/180), pesada, duas m??os",
                Nome = "Arco Longo",
                Peso = "1 Kg",
                Preco = "50 Pe??as de Ouro",
                IdTipoArma = 4
            },
            //33, -, -, -, -, -, 4
            new Arma
            {
                IdArma = 33,
                DadoDano = "1d6 perfurante",
                Propriedade = "Muni????o (dist??ncia 9/36), leve, recarga",
                Nome = "Besta de M??o",
                Peso = "1.5 Kg",
                Preco = "75 Pe??as de Ouro",
                IdTipoArma = 4
            },
            //34, -, -, -, -, -, 4
            new Arma
            {
                IdArma = 34,
                DadoDano = "1d10 perfurante",
                Propriedade = "Muni????o (dist??ncia 30/120), pesada, recarga, duas m??os",
                Nome = "Besta Pesada",
                Peso = "4.5 Kg",
                Preco = "50 Pe??as de Ouro",
                IdTipoArma = 4
            },
            //35, -, -, -, -, -, 4
            new Arma
            {
                IdArma = 35,
                DadoDano = "",
                Propriedade = "Especial, arremesso (dist??ncia 1.4/4.5)",
                Nome = "Rede",
                Peso = "1.5 Kg",
                Preco = "1 Pe??a de Ouro",
                IdTipoArma = 4
            },
            //36, -, -, -, -, -, 4
            new Arma
            {
                IdArma = 36,
                DadoDano = "1 perfurante",
                Propriedade = "Muni????o (dist??ncia 7.5/30), recarga",
                Nome = "Zarabatana",
                Peso = "0.5 Kg",
                Preco = "10 Pe??as de Ouro",
                IdTipoArma = 4
            }
            );
        }
        //IdTipoArmadura, Tipo
        {
            modelBuilder.Entity<TipoArmadura>().HasData(
            //1, Armadura Leve
            new TipoArmadura
            {
                IdTipoArmadura = 1,
                Tipo = "Armadura Leve"
            },
            //2, Armadura M??dia
            new TipoArmadura
            {
                IdTipoArmadura = 2,
                Tipo = "Armadura M??dia"
            },
            //3, Armadura Pesada
            new TipoArmadura
            {
                IdTipoArmadura = 3,
                Tipo = "Armadura Pesada"
            },
            //4, Escudo
            new TipoArmadura
            {
                IdTipoArmadura = 4,
                Tipo = "Escudo"
            }
            );
        }
        //IdArmadura, ClassedeArmadura, ModificiadorDestrezaMaximo, Forca, Furtividade, Nome, Peso, Preco, IdTipoArmadura
        {
            modelBuilder.Entity<Armadura>().HasData(
            //1, 11, null, null, true, Acolchoada, -, -, 1 
            new Armadura
            {
                IdArmadura = 1,
                ClassedeArmadura = 11,
                ModificadorDestrezaMaximo = null,
                Forca = null,
                Furtividade = true,
                Nome = "Acolchoada",
                Peso = "4 Kg",
                Preco = "5 Pe??as de Ouro",
                IdTipoArmadura = 1
            },
            //2, 11, null, null, true, Couro, -, -, 1 
            new Armadura
            {
                IdArmadura = 2,
                ClassedeArmadura = 11,
                ModificadorDestrezaMaximo = null,
                Forca = null,
                Furtividade = false,
                Nome = "Couro",
                Peso = "5 Kg",
                Preco = "10 Pe??as de Ouro",
                IdTipoArmadura = 1
            },
            //3, 12, null, null, false, Couro Batido, -, -, 1 
            new Armadura
            {
                IdArmadura = 3,
                ClassedeArmadura = 12,
                ModificadorDestrezaMaximo = null,
                Forca = null,
                Furtividade = false,
                Nome = "Couro Batido",
                Peso = "6.5 Kg",
                Preco = "45 Pe??as de Ouro",
                IdTipoArmadura = 1
            },
            //4, 12, 2, null, false, Gib??o de Peles, -, -, 2 
            new Armadura
            {
                IdArmadura = 4,
                ClassedeArmadura = 12,
                ModificadorDestrezaMaximo = 2,
                Forca = null,
                Furtividade = false,
                Nome = "Gib??o de Peles",
                Peso = "6 Kg",
                Preco = "10 Pe??as de Ouro",
                IdTipoArmadura = 2
            },
            //5, 13, 2, null, false, Camis??o de Malha, -, -, 2 
            new Armadura
            {
                IdArmadura = 5,
                ClassedeArmadura = 13,
                ModificadorDestrezaMaximo = 2,
                Forca = null,
                Furtividade = false,
                Nome = "Camis??o de Malha",
                Peso = "10 Kg",
                Preco = "30 Pe??as de Ouro",
                IdTipoArmadura = 2
            },
            //6, 14, 2, null, true, Brunea, -, -, 2 
            new Armadura
            {
                IdArmadura = 6,
                ClassedeArmadura = 14,
                ModificadorDestrezaMaximo = 2,
                Forca = null,
                Furtividade = true,
                Nome = "Brunea",
                Peso = "22.5 Kg",
                Preco = "50 Pe??as de Ouro",
                IdTipoArmadura = 2
            },
            //7, 14, 2, null, true, Peitoral, -, -, 2
            new Armadura
            {
                IdArmadura = 7,
                ClassedeArmadura = 14,
                ModificadorDestrezaMaximo = 2,
                Forca = null,
                Furtividade = true,
                Nome = "Peitoral",
                Peso = "10 Kg",
                Preco = "400 Pe??as de Ouro",
                IdTipoArmadura = 2
            },
            //8, 15, 2, null, true, Meia-Armadura, -, -, 2 
            new Armadura
            {
                IdArmadura = 8,
                ClassedeArmadura = 15,
                ModificadorDestrezaMaximo = 2,
                Forca = null,
                Furtividade = true,
                Nome = "Meia-Armadura",
                Peso = "20 Kg",
                Preco = "750 Pe??as de Ouro",
                IdTipoArmadura = 2
            },
            //9, 14, 0, null, true, Cota de An??is, -, -, 3
            new Armadura
            {
                IdArmadura = 9,
                ClassedeArmadura = 14,
                ModificadorDestrezaMaximo = 0,
                Forca = null,
                Furtividade = true,
                Nome = "Cota de An??is",
                Peso = "20 Kg",
                Preco = "30 Pe??as de Ouro",
                IdTipoArmadura = 3
            },
            //10, 16, 0, 13, true, Cota de Malha, -, -, 3
            new Armadura
            {
                IdArmadura = 10,
                ClassedeArmadura = 16,
                ModificadorDestrezaMaximo = 0,
                Forca = 13,
                Furtividade = true,
                Nome = "Cota de Malha",
                Peso = "27.5 Kg",
                Preco = "75 Pe??as de Ouro",
                IdTipoArmadura = 3
            },
            //11, 17, 0, 15, true, Cota de Talas, -, -, 3
            new Armadura
            {
                IdArmadura = 11,
                ClassedeArmadura = 17,
                ModificadorDestrezaMaximo = 0,
                Forca = 15,
                Furtividade = true,
                Nome = "Cota de Talas",
                Peso = "30 Kg",
                Preco = "200 Pe??as de Ouro",
                IdTipoArmadura = 3
            },
            //12, 18, 0, 15, true, Placas, -, -, 3
            new Armadura
            {
                IdArmadura = 12,
                ClassedeArmadura = 18,
                ModificadorDestrezaMaximo = 0,
                Forca = 15,
                Furtividade = true,
                Nome = "Placas",
                Peso = "32.5 Kg",
                Preco = "1500 Pe??as de Ouro",
                IdTipoArmadura = 3
            },
            //13, 2, 0, null, true, Escudo, -, -, 4
            new Armadura
            {
                IdArmadura = 13,
                ClassedeArmadura = 2,
                ModificadorDestrezaMaximo = 0,
                Forca = null,
                Furtividade = true,
                Nome = "Escudo",
                Peso = "3 Kg",
                Preco = "10 Pe??as de Ouro",
                IdTipoArmadura = 4
            }
            );
        }
        //IdListaMagia, Nome
        {
            modelBuilder.Entity<ListaMagia>().HasData(
            //1, Magias de Bardo
            new ListaMagia
            {
                IdListaMagia = 1,
                Nome = "Magias de Bardo"
            },
            //2, Magias de Bruxo
            new ListaMagia
            {
                IdListaMagia = 2,
                Nome = "Magias de Bruxo"
            },
            //3, Magias de Cl??rigo
            new ListaMagia
            {
                IdListaMagia = 3,
                Nome = "Magias de Cl??rigo"
            },
            //4, Magias de Dr??ida
            new ListaMagia
            {
                IdListaMagia = 4,
                Nome = "Magias de Druida"
            },
            //5, Magias de Feiticeiro
            new ListaMagia
            {
                IdListaMagia = 5,
                Nome = "Magias de Feiticeiro"
            },
            //6, Magias de Paladino
            new ListaMagia
            {
                IdListaMagia = 6,
                Nome = "Magias de Paladino"
            },
            //7, Magias de Patrulheiro
            new ListaMagia
            {
                IdListaMagia = 7,
                Nome = "Magias de Patrulheiro"
            },
            //8, Magias de Mago
            new ListaMagia
            {
                IdListaMagia = 8,
                Nome = "Magias de Mago"
            }
            );
        }
        //IdClasse, DadoVida, Nome, Equipamento, Profici??ncia, IdListaMagia
        {
            modelBuilder.Entity<Classe>().HasData(
            //1, 12, B??rbaro, -, -, null
            new Classe
            {
                IdClasse = 1,
                DadoVida = 12,
                Nome = "B??rbaro",
                Equipamento = "(a) um machado grande ou (b) qualquer arma marcial corpo-a-corpo ??? (a) dois machados de m??o ou (b) qualquer arma simples ??? Um pacote de aventureiro e quatro azagaias",
                Proficiencia = "Armaduras: Armaduras leves, armaduras m??dias e escudos Armas: Armas simples, armas marciais Ferramentas: Nenhuma Testes de Resist??ncia: For??a, Constitui????o Per??cias: Escolha duas dentre Adestrar Animais, Atletismo, Intimida????o, Natureza, Percep????o e Sobreviv??ncia",
                IdListaMagia = null,
                Forca = true,
                Destreza = false,
                Constituicao = true,
                Inteligencia = false,
                Sabedoria = false,
                Carisma = false
                // ProfArma = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36},
                // ProfArmadura = {1, 2, 3, 4, 5, 6, 7, 8, 13}
            },
            //2, 8, Bardo, -, -, 1
            new Classe
            {
                IdClasse = 2,
                DadoVida = 8,
                Nome = "Bardo",
                Equipamento = "(a) uma rapieira, (b) uma espada longa ou (c) qualquer arma simples ??? (a) um pacote de diplomata ou (b) um pacote de artista ??? (a) um lute ou (b) qualquer outro instrumento musical ??? Armadura de couro e uma adaga",
                Proficiencia = "Armaduras: Armaduras leves Armas: Armas simples, bestas de m??o, espadas longas, rapieiras, espadas curtas Ferramentas: Tr??s instrumentos musicais, ?? sua escolha Testes de Resist??ncia: Destreza, Carisma Per??cias: Escolha tr??s quaisquer ",
                IdListaMagia = 1,
                Forca = false,
                Destreza = true,
                Constituicao = false,
                Inteligencia = false,
                Sabedoria = false,
                Carisma = true

                // ProfArmadura = {1, 2, 3},
                // ProfArma = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 18, 20, 30, 33}
            },
            //3, 8, Bruxo, -, -, 2
            new Classe
            {
                IdClasse = 3,
                DadoVida = 8,
                Nome = "Bruxo",
                Equipamento = "(a) uma besta leve e 20 virotes ou (b) qualquer arma simples ??? (a) uma bolsa de componentes ou (b) um foco arcano ??? (a) um pacote de estudioso ou (b) um pacote de explorador ??? Armadura de couro, qualquer arma simples e duas adagas",
                Proficiencia = "Armaduras: Armaduras leves Armas: Armas simples Ferramentas: Nenhuma Testes de Resist??ncia: Sabedoria, Carisma Per??cias: Escolha duas dentre Arcanismo, Engana????o, Hist??ria, Intimida????o, Investiga????o, Natureza e Religi??o ",
                IdListaMagia = 2,
                Forca = false,
                Destreza = false,
                Constituicao = false,
                Inteligencia = false,
                Sabedoria = true,
                Carisma = true
                // ProfArmadura = {1, 2, 3},
                // ProfArma = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14}
            },
            //4, 8, Cl??rigo, -, -, 3
            new Classe
            {
                IdClasse = 4,
                DadoVida = 8,
                Nome = "Cl??rigo",
                Equipamento = "(a) uma ma??a ou (b) um martelo de guerra (se for proficiente) ??? (a) brunea, (b) armadura de couro ou (c) cota de malha (se for proficiente) ??? (a) um besta leve e 20 virotes ou (b) qualquer arma simples ??? (a) um pacote de sacerdote ou (b) um pacote de aventureiro ??? Um escudo e um s??mbolo sagrado",
                Proficiencia = "Armaduras: Armaduras leves, armaduras m??dias, escudos Armas: Todas as armas simples Testes de Resist??ncia: Sabedoria, Carisma Per??cias: Escolha duas dentre Hist??ria, Intui????o, Medicina, Persuas??o e Religi??o",
                IdListaMagia = 3,
                Forca = false,
                Destreza = false,
                Constituicao = false,
                Inteligencia = false,
                Sabedoria = true,
                Carisma = true
                // ProfArmadura = {1, 2, 3, 4, 5, 6, 7, 8, 13},
                // ProfArma = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14}
            },
            //5, 8, Dr??ida, -, -, 4
            new Classe
            {
                IdClasse = 5,
                DadoVida = 8,
                Nome = "Druida",
                Equipamento = "(a) um escudo de madeira ou (b) qualquer arma simples (a) uma cimitarra ou (b) qualquer arma corpo-a-corpo simples (a) um pacote de estudioso ou (b) um pacote de explorador ??? Armadura de couro, um pacote de aventureiro e um foco dru??dico",
                Proficiencia = "(a) uma besta leve e 20 virotes ou (b) qualquer arma simples ??? (a) uma bolsa de componentes ou (b) um foco arcano ??? (a) um pacote de explorador ou (b) um pacote de aventureiro",
                IdListaMagia = 4,
                Forca = false,
                Destreza = false,
                Constituicao = false,
                Inteligencia = true,
                Sabedoria = true,
                Carisma = false
                // ProfArmadura = {1, 2, 3, 4, 5, 6, 7, 8, 13},
                // ProfArma = {4, 1, 13, 2, 7, 3, 16, 5, 14, 22, 6}
            },
            //6, 6, Feiticeiro, -, -, 5
            new Classe
            {
                IdClasse = 6,
                DadoVida = 6,
                Nome = "Feiticeiro",
                Equipamento = "(a) uma besta leve e 20 virotes ou (b) qualquer arma simples ??? (a) uma bolsa de componentes ou (b) um foco arcano ??? (a) um pacote de explorador ou (b) um pacote de aventureiro",
                Proficiencia = "Armaduras: Nenhuma Armas: Adagas, dardos, fundas, bord??es e bestas leves Ferramentas: Nenhuma Testes de Resist??ncia: Constitui????o, Carisma Per??cias: Escolha duas dentre Arcanismo, Engana????o, Intui????o, Intimida????o, Persuas??o e Religi??o",
                IdListaMagia = 5,
                Forca = false,
                Destreza = false,
                Constituicao = true,
                Inteligencia = false,
                Sabedoria = false,
                Carisma = true
                // ProfArma = {1, 13, 14, 3, 12}
            },
            //7, 10, Guerreiro, -, -, null
            new Classe
            {
                IdClasse = 7,
                DadoVida = 10,
                Nome = "Guerreiro",
                Equipamento = "(a) cota de malha ou (b) gib??o de peles, arco longo e 20 flechas ??? (a) uma arma marcial e um escudo ou (b) duas armas marciais ??? (a) uma besta leve e 20 virotes ou (b) dois machados de arremesso ??? (a) um pacote de aventureiro ou (b) um pacote de explorador",
                Proficiencia = "Armaduras: Todas as armaduras, escudos Armas: Armas simples, armas marciais Ferramentas: nenhum Testes de Resist??ncia: For??a, Constitui????o Per??cias: Escolha duas dentre Acrobacia, Adestrar Animais, Atletismo, Hist??ria, Intui????o, Intimida????o, Percep????o e Sobreviv??ncia ",
                IdListaMagia = null,
                Forca = true,
                Destreza = false,
                Constituicao = true,
                Inteligencia = false,
                Sabedoria = false,
                Carisma = false
                // ProfArmadura = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
                // ProfArma = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36}
            },
            //8, 8, Ladino, -, -, null
            new Classe
            {
                IdClasse = 8,
                DadoVida = 8,
                Nome = "Ladino",
                Equipamento = "(a) uma rapieira ou (b) uma espada longa ??? (a) um arco curto e uma aljava com 20 flechas ou (b) uma espada curta ??? (a) um pacote de assaltante ou (b) um pacote de aventureiro ou (c) um pacote de explorador ??? Armadura de couro, duas adagas e ferramentas de ladr??o",
                Proficiencia = "(a) uma arma marcial e um escudo ou (b) duas armas marciais ??? (a) cinco azagaias ou (b) qualquer arma simples corpoa-corpo ??? (a) um pacote de sacerdote ou (b) um pacote de aventureiro ??? Cota de malha e um s??mbolo sagrado",
                IdListaMagia = null,
                Forca = false,
                Destreza = true,
                Constituicao = false,
                Inteligencia = true,
                Sabedoria = false,
                Carisma = false
                // ProfArmadura = {1, 2, 3},
                // ProfArma = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 18, 20, 30, 33}
            },
            //9, 6, Mago, -, -, 8
            new Classe
            {
                IdClasse = 9,
                DadoVida = 6,
                Nome = "Mago",
                Equipamento = "(a) uma arma marcial e um escudo ou (b) duas armas marciais ??? (a) cinco azagaias ou (b) qualquer arma simples corpoa-corpo ??? (a) um pacote de sacerdote ou (b) um pacote de aventureiro ??? Cota de malha e um s??mbolo sagrado",
                Proficiencia = "Armaduras: Nenhuma Armas: Adagas, dardos, fundas, bord??es, bestas leves Ferramentas: Nenhuma Testes de Resist??ncia: Intelig??ncia, Sabedoria Per??cias: Escolha duas dentre Arcanismo, Hist??ria, Intui????o, Investiga????o, Medicina e Religi??o",
                IdListaMagia = 8,
                Forca = false,
                Destreza = false,
                Constituicao = false,
                Inteligencia = true,
                Sabedoria = true,
                Carisma = false
                // ProfArma = {1, 13, 14, 3, 12}
            },
            //10, 8, Monge, -, -, null
            new Classe
            {
                IdClasse = 10,
                DadoVida = 8,
                Nome = "Monge",
                Equipamento = "(a) uma arma marcial e um escudo ou (b) duas armas marciais ??? (a) cinco azagaias ou (b) qualquer arma simples corpoa-corpo ??? (a) um pacote de sacerdote ou (b) um pacote de aventureiro ??? Cota de malha e um s??mbolo sagrado",
                Proficiencia = "Armaduras: Todas as armaduras, escudos Armas: Armas simples, armas marciais Ferramentas: Nenhum Testes de Resist??ncia: Sabedoria, Carisma Per??cias: Escolha duas dentre Atletismo, Intui????o, Intimida????o, Medicina, Persuas??o e Religi??o",
                IdListaMagia = null,
                Forca = true,
                Destreza = true,
                Constituicao = false,
                Inteligencia = false,
                Sabedoria = false,
                Carisma = false
                // ProfArma = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 18}
            },
            //11, 10, Paladino, -, -, 6
            new Classe
            {
                IdClasse = 11,
                DadoVida = 10,
                Nome = "Paladino",
                Equipamento = "(a) uma arma marcial e um escudo ou (b) duas armas marciais ??? (a) cinco azagaias ou (b) qualquer arma simples corpoa-corpo ??? (a) um pacote de sacerdote ou (b) um pacote de aventureiro ??? Cota de malha e um s??mbolo sagrado",
                Proficiencia = "Armaduras: Todas as armaduras, escudos Armas: Armas simples, armas marciais Ferramentas: Nenhum Testes de Resist??ncia: Sabedoria, Carisma Per??cias: Escolha duas dentre Atletismo, Intui????o, Intimida????o, Medicina, Persuas??o e Religi??o",
                IdListaMagia = 6,
                Forca = false,
                Destreza = false,
                Constituicao = false,
                Inteligencia = false,
                Sabedoria = true,
                Carisma = true
                // ProfArmadura = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
                // ProfArma = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36}
            },
            //12, 10, Patrulheiro, -, -, 7
            new Classe
            {
                IdClasse = 12,
                DadoVida = 10,
                Nome = "Patrulheiro",
                Equipamento = "(a) brunea ou (b) armadura de couro ??? (a) duas espadas curtas ou (b) duas armas simples corpo-a-corpo ??? (a) um pacote de explorador ou (b) um pacote de aventureiro ??? Um arco longo e uma aljava com 20 flechas",
                Proficiencia = "Armaduras: Armaduras leves, armaduras m??dias, escudos Armas: Armas simples, armas marciais Ferramentas: Nenhuma 117 Testes de Resist??ncia: For??a, Destreza Per??cias: Escolha tr??s dentre Adestrar Animais, Atletismo, Furtividade, Intui????o, Investiga????o, Natureza, Percep????o e Sobreviv??ncia",
                IdListaMagia = 7,
                Forca = true,
                Destreza = true,
                Constituicao = false,
                Inteligencia = false,
                Sabedoria = false,
                Carisma = false
                // ProfArmadura = {1, 2, 3, 4, 5, 6, 7, 8, 13},
                // ProfArma = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36}
            }
            );
        }
        //IdTracodeClasse, Nome, HabilidadeTracodeClasse
        {
            modelBuilder.Entity<TracodeClasse>().HasData(
            //1, F??ria, -
            new TracodeClasse
            {
                IdTracodeClasse = 1,
                Nome = "F??ria",
                HabilidadeTracodeClasse = "Em batalha, voc?? luta com uma ferocidade primitiva. No seu turno, voc?? pode entrar em f??ria com uma a????o b??nus. \nEnquanto estiver em f??ria, voc?? recebe os seguintes benef??cios se voc?? n??o estiver vestindo uma armadura pesada: *Voc?? tem vantagem em testes de For??a e testes de resist??ncia de For??a. *Quando voc?? desferir um ataque com arma corpo-acorpo usando For??a, voc?? recebe um b??nus nas jogadas de dano que aumenta ?? medida que voc?? adquire n??veis de b??rbaro, como mostrado na coluna Dano de F??ria na tabela O B??rbaro. *Voc?? possui resist??ncia contra dano de concuss??o, cortante e perfurante. Se voc?? for capaz de conjurar magias, voc?? n??o poder?? conjur??-las ou se concentrar nelas enquanto estiver em f??ria. Sua f??ria dura por 1 minuto. Ela termina prematuramente se voc?? cair inconsciente ou se seu turno acabar e voc?? n??o tiver atacado nenhuma criatura hostil desde seu ??ltimo turno ou n??o tiver sofrido dano nesse per??odo. Voc?? tamb??m pode terminar sua f??ria no seu turno com uma a????o b??nus. Quando voc?? tiver usado a quantidade de f??rias mostrada para o seu n??vel de b??rbaro na coluna F??rias da tabela O B??rbaro, voc?? precisar?? terminar um descanso longo antes de poder entrar em f??ria novamente. "
            },
            //2, Defesa sem Armadura, -
            new TracodeClasse
            {
                IdTracodeClasse = 2,
                Nome = "Defesa sem Armadura",
                HabilidadeTracodeClasse = "Quando voc?? n??o estiver vestindo qualquer armadura, sua Classe de Armadura ser?? 10 + seu modificador de Destreza + seu modificador de Constitui????o. Voc?? pode usar um escudo e continuar a receber esse benef??cio. "
            },
            //3, Ataque Descuidado, -
            new TracodeClasse
            {
                IdTracodeClasse = 3,
                Nome = "Ataque Descuidado",
                HabilidadeTracodeClasse = "A partir do 2?? n??vel, voc?? pode desistir de toda preocupa????o com sua defesa para atacar com um desespero feroz. Quando voc?? fizer o seu primeiro ataque no turno, voc?? pode decidir atacar descuidadamente. Fazer isso lhe concede vantagem nas jogadas de ataque com armas corpo-a-corpo usando For??a durante seu turno, por??m, as jogadas de ataques feitas contra voc?? possuem vantagem at?? o in??cio do seu pr??ximo turno."
            },
            //4, Sentido do Perigo, -
            new TracodeClasse
            {
                IdTracodeClasse = 4,
                Nome = "Sentido de Perigo",
                HabilidadeTracodeClasse = "No 2?? n??vel, voc?? adquire um sentido sobrenatural de quando as coisas pr??ximas n??o est??o como deveriam, concedendo a voc?? uma chance maior quando estiver evitando perigos. Voc?? possui vantagem em testes de resist??ncia de Destreza contra efeitos que voc?? possa ver, como armadilhas e magias. Para receber esse benef??cio voc?? n??o pode estar cego, surdo ou incapacitado. "
            },
            //5, Caminho Primitivo, -
            new TracodeClasse
            {
                IdTracodeClasse = 5,
                Nome = "Caminho Primitivo",
                HabilidadeTracodeClasse = "No 3?? n??vel, voc?? escolhe um caminho que molda a natureza da sua f??ria. Escolha o Caminho do Furioso ou o Caminho do Guerreiro Tot??mico, ambos detalhados no final da descri????o de classe. Sua escolha lhe conceder?? caracter??sticas no 3?? n??vel e novamente no 6??, 10?? e 14?? n??veis. "
            },
            //6, Incremento no Valor de Habilidade, -
            new TracodeClasse
            {
                IdTracodeClasse = 6,
                Nome = "Incremento no Valor de Habilidade",
                HabilidadeTracodeClasse = "Quando voc?? atinge o 4?? n??vel e novamente no 8??, 12??, 16?? e 19?? n??vel, voc?? pode aumentar um valor de habilidade, ?? sua escolha, em 2 ou voc?? pode aumentar dois valores de habilidade, ?? sua escolha em 1. Como padr??o, voc?? n??o pode elevar um valor de habilidade acima de 20 com essa caracter??stica."
            },
            //7, Ataque Extra, -
            new TracodeClasse
            {
                IdTracodeClasse = 7,
                Nome = "Ataque Extra",
                HabilidadeTracodeClasse = "A partir do 5?? n??vel, voc?? pode atacar duas vezes, ao inv??s de uma, sempre que voc?? realizar a a????o de Ataque no seu turno. "
            },
            //8, Movimento R??pido, -
            new TracodeClasse
            {
                IdTracodeClasse = 8,
                Nome = "Movimento R??pido",
                HabilidadeTracodeClasse = "Come??ando no 5?? n??vel, seu deslocamento aumenta em 3 metros enquanto voc?? n??o estiver vestindo uma armadura pesada."
            },
            //9, Instinto Selvagem
            new TracodeClasse
            {
                IdTracodeClasse = 9,
                Nome = "Instinto Selvagem",
                HabilidadeTracodeClasse = "No 7?? n??vel, seu instinto est?? t??o apurado que voc?? recebe vantagem nas jogadas de iniciativa. Al??m disso, se voc?? estiver surpreso no come??o de um combate e n??o estiver incapacitado, voc?? pode agir normalmente no seu primeiro turno, mas apenas se voc?? entrar em f??ria antes de realizar qualquer outra coisa neste turno. "

            },
            //10, Cr??tico Brutal, -
            new TracodeClasse
            {
                IdTracodeClasse = 10,
                Nome = "Cr??tico Brutal",
                HabilidadeTracodeClasse = "A partir do 9?? n??vel, voc?? pode rolar um dado de dano de arma adicional quando estiver determinando o dano extra de um acerto cr??tico com uma arma corpo-a-corpo. Isso aumenta para dois dados adicionais no 13?? n??vel e tr??s dados adicionais no 17?? n??vel."
            },
            //11, F??ria Implac??vel, -
            new TracodeClasse
            {
                IdTracodeClasse = 11,
                Nome = "F??ria Implac??vel",
                HabilidadeTracodeClasse = "A partir do 11?? n??vel, sua f??ria pode manter voc?? lutando independente da gravidade dos seus ferimentos. Se voc?? cair para 0 pontos de vida enquanto estiver em f??ria e n??o morrer, voc?? pode realizar um teste de resist??ncia de Constitui????o CD 10. Se voc?? for bem sucedido, voc?? volta para 1 ponto de vida ao inv??s disso. Cada vez que voc?? utilizar essa caracter??stica ap??s a primeira, a CD aumenta em 5. Assim que voc?? terminar um descanso curto ou longo a CD volta para 10"
            },
            //12, F??ria Persistente, -
            new TracodeClasse
            {
                IdTracodeClasse = 12,
                Nome = "F??ria Persistente",
                HabilidadeTracodeClasse = "A partir do 15?? n??vel, sua f??ria ?? t??o brutal que ela s?? termina prematuramente se voc?? cair inconsciente ou se voc?? decidir termin??-la. "
            },
            //13, For??a Indom??vel, -
            new TracodeClasse
            {
                IdTracodeClasse = 13,
                Nome = "For??a Indom??vel",
                HabilidadeTracodeClasse = "A partir do 18?? n??vel, se o total de um teste de For??a seu for menor que o seu valor de For??a, voc?? pode usar esse valor no lugar do resultado. "
            },
            //14, Campe??o Primitivo, -
            new TracodeClasse
            {
                IdTracodeClasse = 14,
                Nome = "Campe??o Primitivo",
                HabilidadeTracodeClasse = "No 20?? n??vel, voc?? incorpora os poderes da natureza. Seus valores de For??a e Constitui????o aumentam em 4. Seu m??ximo para esses valores agora ?? 24."
            },
            //15, Conjura????o
            new TracodeClasse
            {
                IdTracodeClasse = 15,
                Nome = "Conjura????o",
                HabilidadeTracodeClasse = "Voc?? aprendeu a desembara??ar e remodelar o decido da realidade em harmonia com os seus desejos e m??sica. Suas magias s??o parte do seu vasto repert??rio, magia que voc?? pode entoar em diferentes situa????es. Veja o cap??tulo 10 para as regras gerais de conjura????o e o cap??tulo 11 para a lista de magias de bardo. TRUQUES Voc?? conhece dois truques, ?? sua escolha da lista de magias de bardo. Voc?? aprende truques de bardo adicionais, ?? sua escolha em n??veis mais altos, como mostrado na coluna Truques Conhecidos da tabela O Bardo. A tabela O Bardo mostra quantos espa??os de magia de 1?? n??vel e superiores voc?? possui dispon??veis para conjura????o. Para conjurar uma dessas magias, voc?? deve gastar uma espa??o de magia do n??vel da magia ou superior. Voc?? recobra todos os espa??os de magia gastos quando voc?? completa um descanso longo. Por exemplo, se voc?? quiser conjurar a magia de 1?? n??vel curar ferimentos e voc?? tiver um espa??o de magia de 1?? n??vel e um de 2?? n??vel dispon??veis, voc?? poder?? conjurar curar ferimentos usando qualquer dos dois espa??os. MAGIAS CONHECIDAS DE 1?? N??VEL E SUPERIORES Voc?? conhece quatro magias de 1?? n??vel, ?? sua escolha, da lista de magias de bardo. A coluna Magias Conhecidas na tabela O Bardo mostra quando voc?? aprende mais magias de bardo, ?? sua escolha. Cada uma dessas magias deve ser de um n??vel a que voc?? tenha acesso, como mostrado na tabela. Por exemplo, quando voc?? alcan??a o 3?? n??vel da classe, voc?? pode aprender uma nova magia de 1?? ou 2?? n??vel. Al??m disso, quando voc?? adquire um n??vel nessa classe, voc?? pode escolher uma magia de bardo que voc?? conhe??a e substitu??-la por outra magia da lista de magias de bardo, que tamb??m deve ser de um n??vel ao qual voc?? tenha espa??os de magia. HABILIDADE DE CONJURA????O Sua habilidade de conjura????o ?? Carisma para suas magias de bardo, portanto, voc?? usa seu Carisma sempre que alguma magia se referir ?? sua habilidade de conjurar magias. Al??m disso, voc?? usa o seu modificador de Carisma para definir a CD dos testes de resist??ncia para as magias de bardo que voc?? conjura e quando voc?? realiza uma jogada de ataque com uma magia. CD para suas magias = 8 + b??nus de profici??ncia + seu modificador de Carisma Modificador de ataque de magia = seu b??nus de profici??ncia + seu modificador de Carisma CONJURA????O DE RITUAL Voc?? pode conjurar qualquer magia de bardo que voc?? conhe??a como um ritual se ela possuir o descritor ritual. FOCO DE CONJURA????O Voc?? pode usar um instrumento musical (encontrado no cap??tulo 5) como foco de conjura????o das suas magias de bardo. "
            },
            //16, Inspiracao de Bardo (d6)
            new TracodeClasse
            {
                IdTracodeClasse = 16,
                Nome = "Inspira????o de Bardo (d6)",
                HabilidadeTracodeClasse = "Voc?? pode inspirar os outros atrav??s de palavras animadoras ou m??sica. Para tanto, voc?? usa uma a????o b??nus no seu turno para escolher uma outra criatura, que n??o seja voc?? mesmo, a at?? 18 metros de voc?? que possa ouvi-lo. Essa criatura ganha um dado de Inspira????o de Bardo, um d6. Uma vez, nos pr??ximos 10 minutos, a criatura poder?? rolar o dado e adicionar o valor rolado a um teste de habilidade, jogada de ataque ou teste de resist??ncia que ela fizer. A criatura pode esperar at?? rolar o d20 antes de decidir usar o dado de Inspira????o de Bardo, mas deve decidir antes do Mestre dizer se a rolagem foi bem ou mal sucedida. Quando o dado de Inspira????o de Bardo for rolado, ele ?? gasto. Uma criatura pode ter apenas um dado de Inspira????o de Bardo por vez. Voc?? pode usar essa caracter??stica um n??mero de vezes igual ao seu modificador de Carisma (no m??nimo uma vez). Voc?? recupera todos os usos quando termina um descanso longo. Seu dado de Inspira????o de Bardo muda quando voc?? atinge certos n??veis na classe. O dado se torna um d8 no 5?? n??vel, um d10 no 10?? n??vel e um d12 no 15?? n??vel."
            },
            //17, Versatilidade
            new TracodeClasse
            {
                IdTracodeClasse = 17,
                Nome = "Versatilidade",
                HabilidadeTracodeClasse = "A partir do 2?? n??vel, voc?? pode adicionar metade do seu b??nus de profici??ncia, arredondado para baixo, em qualquer teste de habilidade que voc?? fizer que ainda n??o possua seu b??nus de profici??ncia. "
            },
            //18. Can????o de Descanso
            new TracodeClasse
            {
                IdTracodeClasse = 18,
                Nome = "Can????o de Descanso",
                HabilidadeTracodeClasse = "A partir do 2?? n??vel, voc?? pode usar m??sica ou ora????o calmantes para ajudar a revitalizar seus aliados feridos durante um descanso curto. Se voc?? ou qualquer criatura amig??vel que puder ouvir sua atua????o recuperar pontos de vida no fim do descanso curto ao gastar um ou mais Dados de Vida, cada uma dessas criaturas recupera 1d6 pontos de vida adicionais. Os pontos de vida adicionais aumentam quando voc?? alcan??a determinados n??veis na classe: para 1d8 no 9?? n??vel, para 1d10 no 13?? n??vel e para 1d12 no 17?? n??vel. "
            },
            //19, Col??gio de Bardo
            new TracodeClasse
            {
                IdTracodeClasse = 19,
                Nome = "Col??gio de Bardo",
                HabilidadeTracodeClasse = "No 3?? n??vel, voc?? investiga as t??cnicas avan??adas de um col??gio de bardo, ?? sua escolha: o Col??gio do Conhecimento ou o Col??gio da Bravura, ambos detalhados no final da descri????o da classe. Sua escolha lhe concede caracter??sticas no 3?? n??vel e novamente no 6?? e 14?? n??vel."
            },
            //20, Aptid??o
            new TracodeClasse
            {
                IdTracodeClasse = 20,
                Nome = "Aptid??o",
                HabilidadeTracodeClasse = "No 3?? n??vel, escolha duas das per??cias em que voc?? ?? proficiente. Seu b??nus de profici??ncia ?? dobrado em teste de habilidade que voc?? fizer que utilize qualquer das per??cias escolhidas. No 10?? n??vel, voc?? escolhe mais duas per??cias em que ?? proficiente para ganhar esse benef??cio. "
            },
            //21, Fonte de Inspira????o
            new TracodeClasse
            {
                IdTracodeClasse = 21,
                Nome = "Fonte de Inspira????o",
                HabilidadeTracodeClasse = "Come??ando no momento em que voc?? atinge o 5?? n??vel, voc?? recupera todas as utiliza????es gastas da sua Inspira????o de Bardo quando voc?? termina um descanso curto ou longo. "
            },
            //22, Can????o de Prote????o
            new TracodeClasse
            {
                IdTracodeClasse = 22,
                Nome = "Can????o de Prote????o",
                HabilidadeTracodeClasse = "No 6?? n??vel, voc?? adquire a habilidade de usar notas musicais ou palavras de poder para interromper efeito de influ??ncia mental. Com uma a????o, voc?? pode come??ar uma atua????o que dura at?? o fim do seu pr??ximo turno. Durante esse tempo, voc?? e qualquer criatura amig??vel a at?? 9 metros de voc?? ter?? vantagem em testes de resist??ncia para n??o ser amedrontado ou enfeiti??ado. Uma criatura deve ser capaz de ouvir voc?? para receber esse benef??cio. A atua????o termina prematuramente se voc?? for incapacitado ou silenciado ou se voc?? termin??-la voluntariamente (n??o requer a????o)"
            },
            //23, Segredos M??gicos
            new TracodeClasse
            {
                IdTracodeClasse = 23,
                Nome = "Segredos M??gicos",
                HabilidadeTracodeClasse = "No 10?? n??vel, voc?? usurpou conhecimento m??gico de um vasto espectro de disciplinas. Escolha duas magias de qualquer classe, incluindo essa. A magia que voc?? escolher deve ser de um n??vel que voc?? possa conjurar, como mostrado na tabela O Bardo, ou um truque. As magias escolhidas contam como magias de bardo para voc?? e j?? est??o inclu??das no n??mero da coluna Magias Conhecidas da tabela O Bardo. Voc?? aprende duas magias adicionais de qualquer classe no 14?? n??vel e novamente no 18?? n??vel."
            },
            //24, Inspira????o Superior
            new TracodeClasse
            {
                IdTracodeClasse = 24,
                Nome = "Inspira????o Superior",
                HabilidadeTracodeClasse = "No 20?? n??vel, quando voc?? rolar iniciativa e n??o tiver nenhum uso restante de Inspira????o de Bardo, voc?? recupera um uso."
            },
            //25, Patrono Transcendental
            new TracodeClasse
            {
                IdTracodeClasse = 25,
                Nome = "Patrono Transcendental",
                HabilidadeTracodeClasse = "No 1?? n??vel, voc?? conclui uma barganha com um ser transcendental, ?? sua escolha: a Arquifada, o Corruptor ou o Grande Antigo, cada um deles ?? detalhado no final da descri????o da classe. Sua escolha lhe confere tra??os no 1?? n??vel e novamente no6??, 10?? e 14?? n??vel."
            },
            //26, Magia de Pacto
            new TracodeClasse
            {
                IdTracodeClasse = 26,
                Nome = "Magia de Pacto",
                HabilidadeTracodeClasse = "Sua pesquisa arcana e a magia outorgada a voc?? por seu patrono, lhe concedem uma gama de magias. Veja o cap??tulo 10 para as regras gerais de conjura????o e o cap??tulo 11 para a lista de magias de bruxo. TRUQUES Voc?? conhece dois truques, ?? sua escolha, da lista de magias de bruxo. Voc?? aprende truques de bruxo adicionais, ?? sua escolha, em n??veis mais altos, como mostrado na coluna Truques Conhecidos da tabela O Bruxo. ESPA??OS DE MAGIA A tabela O Bruxo mostra quantos espa??os de magia voc?? possui. A tabela tamb??m mostra qual o n??vel desses espa??os; todos os seus espa??os de magia s??o do mesmo n??vel. Para conjurar uma magia de bruxo de 1?? n??vel ou superior, voc?? deve gastar uma espa??o de magia. Voc?? recobra todos os espa??os de magia gastos quando voc?? completa um descanso curto ou longo. Por exemplo, quando voc?? atingir o 5?? n??vel, voc?? ter?? dois espa??os de magia de 3?? n??vel. Para conjurar a magia de 1?? n??vel onda trovejante, voc?? deve gastar um desses espa??os e voc?? a conjura como uma magia de 3?? n??vel. MAGIAS CONHECIDAS DE 1?? N??VEL E SUPERIORES No 1?? n??vel, voc?? conhece duas magias de 1?? n??vel, ?? sua escolha da lista de magias de bruxo. A coluna Magias Conhecidas na tabela O Bruxo mostra quando voc?? aprende mais magias de bruxo, ?? sua escolha, de 1?? n??vel ou superior. Cada uma dessas magias deve ser de um n??vel a que voc?? tenha acesso, como mostrado na tabela na coluna de N??vel de Magia para o seu n??vel. Quando voc?? alcan??a o 6?? n??vel, por exemplo, voc?? aprende uma nova magia de bruxo, que pode ser de 1??, 2?? ou 3?? n??vel. Al??m disso, quando voc?? adquire um n??vel nessa classe, voc?? pode escolher uma magia de bruxo que voc?? conhe??a e substitu??-la por outra magia da lista de magias de bruxo, que tamb??m deve ser de um n??vel ao qual voc?? tenha espa??os de magia. HABILIDADE DE CONJURA????O Sua habilidade de conjura????o ?? Carisma para suas magias de bruxo, portanto, voc?? usa seu Carisma sempre que alguma magia se referir ?? sua habilidade de conjurar magias. Al??m disso, voc?? usa o seu modificador de Carisma para definir a CD dos testes de resist??ncia para as magias de bruxo que voc?? conjura e quando voc?? realiza uma jogada de ataque com uma magia. CD para suas magias = 8 + b??nus de profici??ncia + seu modificador de Carisma Modificador de ataque de magia = seu b??nus de profici??ncia + seu modificador de Carisma FOCO DE CONJURA????O Voc?? pode usar um foco arcano (encontrado no cap??tulo 5) como foco de conjura????o das suas magias de bruxo. "
            },
            //27, Invoca????es M??sticas
            new TracodeClasse
            {
                IdTracodeClasse = 27,
                Nome = "Invoca????es M??sticas",
                HabilidadeTracodeClasse = "Durante seus estudos sobre conhecimento oculto, voc?? descobriu as invoca????es m??sticas, fragmentos de conhecimento proibido que infundiram voc?? com habilidade m??gica permanente. No 2?? n??vel, voc?? ganha duas invoca????es m??sticas, ?? sua escolha. Suas op????es de invoca????o est??o detalhadas no final da descri????o dessa classe. Quando voc?? atinge certos n??vel de bruxo, voc?? adquire novas invoca????es ?? sua escolha, como mostrado na coluna Invoca????es Conhecidas na tabela O Bruxo. Al??m disso, quando voc?? adquire um novo n??vel nessa classe, voc?? pode escolher uma invoca????o que voc?? conhe??a e substitu??-la por outra invoca????o que voc?? possa aprender nesse n??vel. "
            },
            //28, D??diva do Pacto
            new TracodeClasse
            {
                IdTracodeClasse = 28,
                Nome = "D??diva de Pacto",
                HabilidadeTracodeClasse = "No 3?? n??vel, seu patrono transcendental lhe confere um dom por seus leais servi??os. Voc?? adquire uma das caracter??sticas a seguir, ?? sua escolha."
            },
            //29, Arcana M??stica
            new TracodeClasse
            {
                IdTracodeClasse = 29,
                Nome = "Arcana M??stica",
                HabilidadeTracodeClasse = "No 11?? n??vel, seu patrono confere a voc?? um segredo m??gico conhecido como arcana. Escolha uma magia de 6?? n??vel da lista de magias de bruxo como sua arcana. Voc?? pode conjurar essa magia arcana uma vez sem gastar um espa??o de magia. Voc?? deve terminar um descanso longo antes de poder fazer isso novamente. Em n??vel altos, voc?? adquire mais magias de bruxo de sua escolha que podem ser conjuradas dessa forma: uma magia de 7?? n??vel no 13?? n??vel, uma magia de 8?? n??vel no 15?? n??vel e uma magia de 9?? n??vel no 17?? n??vel. Voc?? recupera todos os usos de sua Arcana M??stica quando voc?? termina um descanso longo."
            },
            //30 Mestre M??stico
            new TracodeClasse
            {
                IdTracodeClasse = 30,
                Nome = "Mestre M??stico",
                HabilidadeTracodeClasse = "No 20?? n??vel, voc?? pode recarregar sua reserva interior de poder m??stico quando suplicar ao seu patrono para recuperar espa??os de magia gastos. Voc?? pode gastar 1 minuto suplicando pela ajuda do seu patrono para recuperar todos os espa??os de magia gastos da sua caracter??stica Magia de Pacto. Uma vez que voc?? recuperou espa??os de magia com essa caracter??stica, voc?? deve terminar um descanso longo antes de faz??-lo novamente. "
            }
            );
        }
        //IdArquetipo, Nome, HabilidadeArquetipo
        {
            modelBuilder.Entity<Arquetipo>().HasData(
                //1, Caminho do Furioso
                new Arquetipo
                {
                    IdArquetipo = 1,
                    Nome = "Caminho do Furioso",
                    HabilidadeArquetipo = "CAMINHO DO FURIOSO Para alguns b??rbaros, a f??ria ?? um meio para um fim ??? esse fim ?? a viol??ncia. O Caminho do Furioso ?? um caminho de f??ria livre, entumecido em sangue. A medida que voc?? entra na f??ria de um furioso, voc?? vibra no caos da batalha, despreocupado com a sua pr??pria sa??de ou bem-estar. FRENESI Come??ando no momento que voc?? escolhe esse caminho no 3?? n??vel, voc?? pode entrar num frenesi quando estiver em f??ria. Se voc?? desejar, pela dura????o da sua f??ria, voc?? pode realizar um ??nico ataque corpo-a-corpo com arma, com uma a????o b??nus, em cada um de seus turnos ap??s esse. Quando sua f??ria acabar, voc?? sofrer?? um n??vel de exaust??o (como descrito no ap??ndice A). F??RIA INCONSCIENTE A partir do 6?? n??vel, voc?? n??o pode ser enfeiti??ado ou amedrontado enquanto estiver em f??ria. Se voc?? estava enfeiti??ado ou amedrontado quando entrou em f??ria, o efeito ?? suspenso pela dura????o da f??ria. PRESEN??A INTIMIDANTE A partir do 10?? n??vel, voc?? pode usar sua a????o para amedrontar algu??m com sua presen??a intimidante. Quando o fizer, escolha uma criatura que voc?? possa ver a 9 metros. Se a criatura puder ver ou ouvir voc??, ela deve ser bem sucedida num teste de resist??ncia de Sabedoria (CD igual a 8 + seu b??nus de profici??ncia + seu modificador de Carisma) ou ficara com medo de voc?? at?? o fim do seu pr??ximo turno. Nos turnos seguintes, voc?? pode usar sua a????o para estender a dura????o desse efeito na criatura amedrontada at?? o in??cio do seu pr??ximo turno. Esse efeito termina se a criatura terminar seu turno fora da sua linha de vis??o ao a mais de 18 metros de voc??. Se a criatura for bem sucedida no teste de resist??ncia, voc?? n??o poder?? usar essa caracter??stica nessa criatura novamente por 24 horas. RETALIA????O A partir do 14?? n??vel, quando voc?? sofrer dano de uma criatura que esteja a at?? 1,5 metro de voc??, voc?? pode usar sua rea????o para realizar um ataque corpo-a-corpo com arma contra essa criatura. "
                },
                //2, Caminho do Guerreiro Tot??mico
                new Arquetipo
                {
                    IdArquetipo = 2,
                    Nome = "Caminho do Guerreiro Tot??mico",
                    HabilidadeArquetipo = "O Caminho do Guerreiro Tot??mico ?? uma jornada espiritual, ?? partir do momento que o b??rbaro aceita um espirito animal como seu guia, protetor e inspira????o. Em batalha, seu espirito tot??mico preenche voc?? com for??a sobrenatural, adicionando combust??vel m??gico a sua f??ria b??rbara. A maioria das tribos b??rbaras consideram que um animal tot??mico possui parentesco a um cl?? em particular. Em tais casos, ?? incomum a um indiv??duo possuir mais de um espirito animal tot??mico, apesar de existirem exce????es. CONSELHEIRO ESPIRITUAL Seu caminho ?? buscar a sintonia com o mundo natural, concedendo a voc?? uma afinidade com as bestas. A partir do 3?? n??vel, quando voc?? toma esse caminho, voc?? recebe a habilidade de conjurar as magias sentido bestial e falar com animais, mas apenas na forma de rituais, como descrito no cap??tulo 10. TOTEM ESPIRITUAL A partir do 3?? n??vel, quando voc?? adota esse caminho, voc?? escolhe um totem espiritual e ganha suas caracter??sticas. Voc?? deve fazer ou adquirir um objeto f??sico como totem ??? um amuleto ou adorno similar ??? que incorpora o pelo ou penas, garras, dente ou ossos do animal tot??mico. Se voc?? quiser, voc?? tamb??m adquire pequenos atributos f??sicos que o assemelham ao seu totem espiritual. Por exemplo, se voc?? tiver o totem espiritual do urso, voc?? seria incomumente peludo e de pele grossa, ou se o seu totem for a ??guia, seu olhos teriam um brilho amarelado. Seu totem animal deve ser um animal relacionado aos listados aqui, mas pode ser um mais apropriado a sua terra natal. Por exemplo, voc?? poderia escolher falc??o ou abutre ao inv??s de ??guia. ??guia. Quando estiver em f??ria e n??o estiver vestindo uma armadura pesada, as outras criaturas ter??o desvantagem nas jogadas de ataque de oportunidade contra voc?? e voc?? pode usar a a????o de Disparada como uma a????o b??nus no seu turno. O espirito da ??guia torna voc?? um predador que pode vagar pelo meio da briga com facilidade. Lobo. Quando estiver em f??ria, seus amigos tem vantagem nas jogadas de ataque corpo-a-corpo realizadas contra qualquer criatura a 1,5 metro de voc?? que seja hostil a voc??. O espirito do lobo transforma voc?? em um l??der de ca??a. Urso. Quando em f??ria, voc?? adquire resist??ncia a todos os tipos de dano, exceto dano ps??quico. O espirito do urso torna voc?? vigoroso o suficiente para permanecer de p?? diante de qualquer castigo. ASPECTO DA BESTA No 6?? n??vel, voc?? adquire um benef??cio m??stico baseado no totem que voc?? escolheu. Voc?? pode escolher o mesmo animal que selecionou no 3?? n??vel ou um diferente. ??guia. Voc?? ganha a vis??o agu??ada de uma ??guia. Voc?? pode ver a at?? 1,6 km sem dificuldade, sendo capaz de discernir at?? os menores detalhes quando estiver olhando para algo a menos de 30 metros de voc??. Al??m disso, penumbra n??o imp??em desvantagem nos seus testes de Sabedoria (Percep????o). Lobo. Voc?? ganha a sensibilidade predat??ria de um lobo. Voc?? pode rastrear outras criaturas quando estiver viajando a passo r??pido e voc?? pode se mover furtivamente quando estiver viajando a passo normal (veja o cap??tulo 8 para as regras de passo de viagem). Urso. Voc?? ganha a for??a de um urso. Sua capacidade de carga (incluindo carga m??xima e capacidade de erguer) ?? dobrada e voc?? tem vantagem em testes de For??a realizados para empurrar, puxar, erguer ou quebrar objetos. ANDARILHO ESPIRITUAL No 10?? n??vel, voc?? pode conjurar a magia comunh??o com a natureza, mas apenas como um ritual. Quando o fizer, uma vers??o espiritual de um dos animais que voc?? escolheu como Totem Espiritual ou Aspecto da Besta aparece para voc?? para transmitir a informa????o que voc?? busca. SINTONIA TOT??MICA No 14?? n??vel, voc?? ganha um benef??cio magico baseado em um totem animal, ?? sua escolha. Voc?? pode escolher o mesmo animal que selecionou anteriormente ou um diferente. ??guia. Quando estiver em f??ria, voc?? adquire um deslocamento de voo igual ao seu deslocamento de caminhada. Esse benef??cio funciona apenas em pequenos explos??es: voc?? cai se terminar seu turno no ar e n??o tiver nada em que possa se agarrar. Lobo. Quando estiver em f??ria, voc?? pode usar uma a????o b??nus no seu turno para derrubar uma criatura Grande ou menor no ch??o quando voc?? atingi-la com um ataque corpo-a-corpo com arma. Urso. Quando estiver em f??ria, qualquer criatura a at?? 1,5 metro de voc?? que for hostil a voc?? ter?? desvantagem nas jogadas de ataque contra outros alvos al??m de voc?? ou outro personagem com essa caracter??stica. Um inimigo ?? imune a esse efeito se ele n??o puder ver ou ouvir voc?? ou caso ele n??o possa ser amedrontado. "
                },
                //3, Col??gio do Conhecimento
                new Arquetipo
                {
                    IdArquetipo = 3,
                    Nome = "Col??gio do Conhecimento",
                    HabilidadeArquetipo = "Bardos do Col??gio do Conhecimento conhecem algo sobre a maioria das coisas, coletando peda??os de conhecimento de fontes t??o diversas quanto tomos eruditos ou contos de camponeses. Quer seja cantando baladas populares em taverna, quer seja elaborando composi????es para cortes reais, esses bardos usam seus dons para manter a audi??ncia enfeiti??ada. Quando os aplausos acabam, os membros da audi??ncia v??o estar se questionando se tudo que eles creem ?? verdade, desde sua cren??a no sacerd??cio do templo local at?? sua lealdade ao rei. A fidelidade desses bardos reside na busca pela beleza e verdade, n??o na lealdade a um monarca ou em seguir os dogmas de uma divindade. Um nobre que mantem um bardo desses como seu arauto ou conselheiro, sabe que o bardo prefere ser honesto que pol??tico. Os membros do col??gio se re??nem em bibliotecas e, as vezes, em faculdades de verdade, completas com salas de aula e dormit??rios, para partilhar seu conhecimento uns com os outros. Eles tamb??m se encontram em festivais ou em assuntos de estado, onde eles podem expor corrup????o, desvendar mentiras e zombar da superestima de figuras de autoridade. PROFICI??NCIA ADICIONAL Quando voc?? se junta ao Col??gio do Conhecimento no 3?? n??vel, voc?? ganha profici??ncia em tr??s per??cias, ?? sua escolha. PALAVRAS DE INTERRUP????O Tamb??m no 3?? n??vel, voc?? aprende como usar sua perspic??cia para distrair, confundir e, de outras formas, atrapalhar a confian??a e compet??ncia de outros. Quando uma criatura que voc?? pode ver a at?? 18 metros de voc?? realizar uma jogada de ataque, um teste de habilidade ou uma jogada de dano, voc?? pode usar sua rea????o para gastar um uso de Inspira????o de Bardo, rolando o dado de Inspira????o de Bardo e subtraindo o n??mero rolado da rolagem da criatura. Voc?? escolhe usar essa caracter??stica depois da criatura fazer a rolagem, mas antes do Mestre determinar se a jogada de ataque ou teste de habilidade foi bem ou mal sucedido, ou antes da criatura causar dano. A criatura ser?? imune se n??o puder ouvir ou se n??o puder ser enfeiti??ada. SEGREDOS M??GICOS ADICIONAIS No 6?? n??vel, voc?? aprende duas magias, ?? sua escolha, de qualquer classe. As magias que voc?? escolher devem ser de um n??vel que voc?? possa conjurar, como mostrado na tabela O Bardo, ou um truque. As magias escolhidas contam como magias de bardo pra voc??, mas n??o contam no n??mero de magias de bardo que voc?? conhece. PER??CIA INIGUAL??VEL A partir do 14?? n??vel, quando voc?? fizer um teste de habilidade, voc?? pode gastar um uso de Inspira????o de Bardo. Role o dado de Inspira????o de Bardo e adicione o n??mero rolado ao seu teste de habilidade. Voc?? pode escolher fazer isso depois de rolar o dado do teste de habilidade, mas antes do Mestre dizer se foi bem ou mal sucedido. "
                },
                //4, Col??gio da Bravura
                new Arquetipo
                {
                    IdArquetipo = 4,
                    Nome = "Col??gio da Bravura",
                    HabilidadeArquetipo = "Os bardos do Col??gio da Bravura s??o escaldos destemidos de quem os contos mantem viva a mem??ria dos grandes her??is do passado, dessa forma inspirando uma nova gera????o de her??is. Esses bardos se re??nem em sal??es de hidromel ou ao redor de fogueiras para cantar os feitos dos grandiosos, tanto do passado quanto do presente. Eles viajam pelos lugares para testemunhar grandes eventos em primeira m??o e para garantir que a mem??ria desses eventos n??o se perca nesse mundo. Com suas can????es, eles inspiram outros a alcan??ar o mesmo patamar de realiza????es dos antigos her??is. PROFICI??NCIA ADICIONAL Quando voc?? se junta ao Col??gio da Bravura no 3?? n??vel, voc?? adquire profici??ncia com armadura m??dias, escudos e armas marciais. INSPIRA????O EM COMBATE Tamb??m no 3?? n??vel, voc?? aprende a inspirar os outros em batalha. Uma criatura que possuir um dado de Inspira????o de Bardo seu, pode rolar esse dado e adicionar o n??mero rolado a uma jogada de dano que ele tenha acabado de fazer. Alternativamente, quando uma jogada de ataque for realizada contra essa criatura, ela pode usar sua rea????o para rolar o dado de Inspira????o de Bardo e adicionar o n??mero rolado a sua CA contra esse ataque, depois da rolagem ser feita, mas antes de saber se errou ou acertou. ATAQUE EXTRA A partir do 6?? n??vel, voc?? pode atacar duas vezes, ao inv??s de uma, sempre que voc?? realizar a a????o de Ataque no seu turno. MAGIA DE BATALHA No 14?? n??vel, voc?? dominou a arte de tecer a conjura????o e usar armas em um ato harmonioso. Quando voc?? usar sua a????o para conjurar uma magia de bardo, voc?? pode realizar um ataque com arma com uma a????o b??nus."
                },
                //5, Pacto da Corrente
                new Arquetipo
                {
                    IdArquetipo = 5,
                    Nome = "Pacto da Corrente",
                    HabilidadeArquetipo = "PACTO DA CORRENTE Voc?? aprende a magia convocar familiar e pode conjur??-la como um ritual. Essa magia n??o conta no n??mero de magias que voc?? conhece. Quando voc?? conjura essa magia, voc?? pode escolher uma das formas convencionais para o seu familiar ou uma das seguintes formas especiais: diabrete, pseudodrag??o, quasit ou sprite. Al??m disso, quando voc?? realiza a a????o de Ataque, voc?? pode renunciar s um dos seus ataques para permitir que seu familiar realize um ataque, com a rea????o dele"
                },
                //6, Pacto da L??mina
                new Arquetipo
                {
                    IdArquetipo = 6,
                    Nome = "Pacto da L??mina",
                    HabilidadeArquetipo = "Voc?? pode usar sua a????o para criar uma arma de pactom em sua m??o vazia. Voc?? escolhe a forma que essa arma corpo-a-corpo tem a cada vez que voc?? a cria (veja as op????es de arma no cap??tulo 5). Voc?? ?? proficiente com ela enquanto a empunhar. Essa arma conta como sendo m??gica com os prop??sitos de ultrapassar resist??ncia e imunidade a ataques e danos n??o-m??gicos. Sua arma de pacto desaparece se ela estiver a mais de 1,5 metro de voc?? por 1 minuto ou mais. Ela tamb??m desaparece se voc?? usar essa caracter??stica novamente, se voc?? dissipar a arma (n??o requer a????o) ou se voc?? morrer. Voc?? pode transformar uma arma m??gica em sua arma de pacto ao realizar um ritual especial enquanto empunha a arma. Voc?? precisa de 1 hora para concluir o ritual, que pode ser realizado durante um descanso curto. Voc?? pode dissipar a arma, guardando-a em um espa??o extradimensional, e ela reaparece toda vez que voc?? criar sua arma de pacto. A arma deixa de ser sua arma de pacto se voc?? morrer, se voc?? realizar um ritual de 1 hora com outra arma diferente ou se voc?? realizar um ritual de 1 hora para romper seu elo com ela. A arma aparece aos seus p??s se ela estiver no espa??o extradimensional quando o elo for quebrado."
                },
                //7, Pacto do Tomo
                new Arquetipo
                {
                    IdArquetipo = 7,
                    Nome = "Pacto do Tomo",
                    HabilidadeArquetipo = "Seu patrono lhe deu um grim??rio chamado Livro das Sombras. Quando voc?? adquire essa caracter??stica, escolha tr??s truques da lista de magias de qualquer classe. Enquanto o livro estiver com voc??, voc?? poder?? conjurar esses truques ?? vontade. Eles n??o contam no n??mero de truques que voc?? conhece. Esses truques s??o considerados magias de bruxo para voc?? e n??o precisam ser da mesma lista de magia. Se voc?? perder seu Livro das Sombras, voc?? pode realizar uma cerim??nia de 1 hora para receber um substituto do seu patrono. Essa cerim??nia pode ser realizada durante um descanso curto ou longo e destr??i o livro anterior. O livro se torna cinzas quando voc?? morre"
                },
                //8, A Arquifada
                new Arquetipo
                {
                    IdArquetipo = 8,
                    Nome = "A Arquifada",
                    HabilidadeArquetipo = "Seu patrono ?? um senhor ou senhora das fadas, uma criatura lend??ria que det??m segredos que foram esquecidos antes das ra??as mortais nascerem. As motiva????es desses seres s??o, muitas vezes, inescrut??veis e, as vezes, exc??ntricas e podem envolver esfor??os para adquirir grandes poderes m??gicos ou resolu????o de desaven??as antigas. Incluem-se dentre esses seres o Pr??ncipe do Frio; a Rainha do Ar e Trevas, regente da Corte do Crep??sculo; Titania da Corte do Ver??o; seu c??njuge, Oberon, o Senhor Verdejante; Hyrsam, o Pr??ncipe dos Tolos; e bruxas antigas. LISTA DE MAGIA EXPANDIDA A Arquifada permite que voc?? escolha magias de uma lista expandida quando voc?? for aprender magias de bruxo. As seguintes magias s??o adicionadas a sua lista de magias de bruxo. MAGIAS EXPANDIDAS DA ARQUIFADA N??vel de Magia Magias 1?? fogo das fadas, sono 2?? acalmar emo????es, for??a fantasmag??rica 3?? piscar, ampliar plantas 4?? dominar besta, invisibilidade maior 5?? dominar pessoa, similaridade PRESEN??A FE??RICA A partir do 1?? n??vel, seu patrono concede a voc?? a habilidade de projetar a sedu????o e temeridade da presen??a da fada. Com uma a????o, voc?? pode fazer com que cada criatura num cubo de 3 metros centrado em voc??, fa??a um teste de resist??ncia de Sabedoria com uma CD igual a de sua magia de bruxo. As criaturas que falharem no teste ficaram enfeiti??adas ou amedrontadas por voc?? (?? sua escolha) at?? o in??cio do seu pr??ximo turno. Quando voc?? usar essa caracter??stica, voc?? n??o poder?? utiliz??-la novamente antes de realizar um descanso curto ou longo. N??VOA DE FUGA A partir do 6?? n??vel, voc?? pode desaparecer em uma lufada de n??voa em resposta a alguma ofensa. Quando voc?? sofrer dano, voc?? pode usar sua rea????o para ficar invis??vel e se teletransportar a at?? 18 metros para um espa??o desocupado que voc?? possa ver. Voc?? permanece invis??vel at?? o in??cio do seu pr??ximo turno ou at?? realizar um ataque ou conjurar uma magia. Ap??s usar essa caracter??sticas, voc?? n??o poder?? utiliz??-la novamente at?? terminar um descanso curto ou longo. DEFESA SEDUTORA A partir do 10?? n??vel, seu patrono ensina voc?? como voltar as magias de efeito mental dos seus inimigos contra eles. Voc?? n??o pode ser enfeiti??ado e, quando outra criatura tenta enfeiti????-lo, voc?? pode usar sua rea????o para tentar reverter o encanto de volta aquela criatura. A criatura deve ser bem sucedida num teste de resist??ncia de Sabedoria contra a CD da sua magia de bruxo ou ficara enfeiti??ado por 1 minuto ou at?? a criatura sofrer dano. DEL??RIO SOMBRIO Come??ando no 14?? n??vel, voc?? pode imergir uma criatura num reino ilus??rio. Com um a????o, escolha uma criatura que voc?? possa ver a at?? 18 metros de voc??. Ela deve ser bem sucedida num teste de resist??ncia de Sabedoria contra a CD da sua magia de bruxo. Se ela falhar, ela ficar?? enfeiti??ada ou amedrontada por voc?? (?? sua escolha) por 1 minuto ou at?? voc?? quebrar sua concentra????o (como se voc?? estivesse se concentrando em uma magia). Esse efeito termina prematuramente se a criatura sofrer dano. At?? que essa ilus??o termine, a criatura acredita que est?? perdida num reino enevoado, a apar??ncia desse reino fica a seu crit??rio. A criatura s?? pode ver e ouvir a si mesma, a voc?? e a sua ilus??o. Voc?? deve terminar um descanso curto ou longo antes de poder usar essa caracter??stica novamente. "
                }
            );

            //IdHabilidadeRacial, Nome, Descri????o

            modelBuilder.Entity<HabilidadeRacial>().HasData(
            //1, Vis??o no Escuro
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 1,
                Nome = "Vis??o no Escuro",
                Descricao = "Acostumado ?? vida subterr??nea ou ??s florestas crepusculares e ao c??u noturno, voc?? tem uma vis??o superior no escuro e na penumbra. Voc?? enxerga na penumbra a at?? 18 metros como se fosse luz plena, e no escuro como se fosse na penumbra. Voc?? n??o pode discernir cores no escuro, apenas tons de cinza."
            },
            //2, Resili??ncia An??
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 2,
                Nome = "Resili??ncia An??",
                Descricao = "Voc?? possui vantagem em testes de resist??ncia contra venenos e resist??ncia contra dano de veneno"
            },
            //3, Treinamento An??o em Combate
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 3,
                Nome = "Treinamento An??o em Combate",
                Descricao = "Voc?? tem profici??ncia com machados de batalha, machadinhas,martelos leves e martelos de guerra."
            },
            //4, Profici??ncia com Ferramentas
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 4,
                Nome = "Profici??ncia com Ferramentas",
                Descricao = "Voc?? tem profici??ncia em uma ferramenta de artes??o ?? sua escolha entre: ferramentas de ferreiro, suprimentos de cervejeiro ou ferramentas de pedreiro. "
            },
            //5, Especializa????o em Rochas
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 5,
                Nome = "Especializa????o em Rochas",
                Descricao = "Sempre que voc?? realizar um teste de Intelig??ncia (Hist??ria) relacionado ?? origem de um trabalho em pedra, voc?? ?? considerado proficiente na per??cia Hist??ria e adiciona o dobro do seu b??nus de profici??ncia ao teste, ao inv??s do seu b??nus de profici??ncia normal."
            },
            //6, Tenacidade An??
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 6,
                Nome = "Tenacidade An??",
                Descricao = "Seu m??ximo de pontos de vida aumentam em 1, e cada vez que o an??o da colina sobe um n??vel, ele recebe 1 ponto de vida adicional."
            },
            //7, Treinamento an??o com Armaduras
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 7,
                Nome = "Treinamento An??o com Armaduras",
                Descricao = "Voc?? adquire profici??ncia em armaduras leves e m??dias. "
            },
            //8, Sentidos Agu??ados
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 8,
                Nome = "Sentidos Agu??ados",
                Descricao = "Voc?? tem profici??ncia na per??cia Percep????o."
            },
            //9, Ancestral Fe??rico
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 9,
                Nome = "Ancestral Fe??rico",
                Descricao = "Voc?? tem vantagem nos testes de resist??ncia para resistir a ser enfeiti??ado e magias n??o podem coloc??-lo para dormir. "
            },
            //11, Transe
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 11,
                Nome = "Transe",
                Descricao = "Elfos n??o precisam dormir. Ao inv??s disso, eles meditam profundamente, permanecendo semiconscientes, durante 4 horas por dia. (A palavra em idioma comum para tal medita????o ?? 'transe'.) Enquanto medita, um elfo ?? capaz de sonhar de certo modo. Esses sonhos na verdade s??o exerc??cios mentais que se tornam reflexos atrav??s de anos de pr??tica. Depois de descansar dessa forma, voc?? ganha os mesmos benef??cios que um humano depois de 8 horas de sono."
            },
            //12 Treinamento ??lfico com Armas
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 12,
                Nome = "Treinamento ??lfico com Armas",
                Descricao = "Voc?? possui profici??ncia com espadas longas, espadas curtas, arcos longos e arcos curtos. "
            },
            //13, Truque
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 13,
                Nome = "Truque",
                Descricao = "Voc?? conhece um truque, ?? sua escolha, da lista de truques do mago. Intelig??ncia ?? a habilidade usado para conjurar este truque. "
            },
            //14, Idioma Adicional
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 14,
                Nome = "Idioma Adicional",
                Descricao = " Voc?? pode falar, ler e escrever um idioma adicional ?? sua escolha."
            },
            //15, P??s Ligeiros
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 15,
                Nome = "P??s Ligeiros",
                Descricao = "Seu deslocamento base de caminhada aumenta para 10,5 metros."
            },
            //16, M??scara da Natureza
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 16,
                Nome = "M??scara da Natureza",
                Descricao = "Voc?? pode tentar se esconder mesmo quando voc?? est?? apenas levemente obscurecido por folhagem, chuva forte, neve caindo, n??voa ou outro fen??meno natural. "
            },
            //17, Vis??o no Escuro Superior
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 17,
                Nome = "Vis??o no Escuro Superior",
                Descricao = " Sua vis??o no escuro tem alcance de 36 metros de raio"
            },
            //18, Sensibilidade ?? Luz Solar
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 18,
                Nome = "Sensibilidade ?? Luz Solar",
                Descricao = "Voc?? possui desvantagem nas jogadas de ataque e testes de Sabedoria (Percep????o) relacionados a vis??o quando voc??, o alvo do seu ataque, ou qualquer coisa que voc?? est?? tentando perceber, esteja sob luz solar direta. "
            },
            //19, Magia Drow
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 19,
                Nome = "Magia Drow",
                Descricao = ". Voc?? possui o truque globos de luz. Quando voc?? alcan??a o 3?? n??vel, voc?? pode conjurar a magia fogo das fadas. Quando voc?? alcan??a o 5?? n??vel, voc?? pode conjurar escurid??o. Voc?? precisa terminar um descanso longo para poder conjurar as magias desse tra??o novamente. Carisma ?? sua habilidade chave para conjurar essas magias. "
            },
            //20, Treinamento Drow com Armas
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 20,
                Nome = "Treinamento Drow com Armas",
                Descricao = "Voc?? possui profici??ncia com rapieiras, espadas curtas e bestas de m??o. "
            },
            //21, Sortudo
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 21,
                Nome = "Sortudo",
                Descricao = "Quando voc?? obtiver um 1 natural em uma jogada de ataque, teste de habilidade ou teste de resist??ncia, voc?? pode jogar de novo o dado e deve utilizar o novo resultado"
            },
            //22, Bravura
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 22,
                Nome = "Bravura",
                Descricao = "Voc?? tem vantagem em testes de resist??ncia contra ficar amedrontado"
            },
            //23, Agilidade Halfling
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 23,
                Nome = "Agilidade Halfling",
                Descricao = "Voc?? pode mover-se atrav??s do espa??o de qualquer criatura que for de um tamanho maior que o seu"
            },
            //24, Furtividade Natural
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 24,
                Nome = "Furtividade Natural",
                Descricao = "Voc?? pode tentar se esconder mesmo quando possuir apenas a cobertura de uma criatura que for no m??nimo um tamanho maior que o seu"
            },
            //25, Resili??ncia dos Robustos
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 25,
                Nome = "Resili??ncia dos Robustos",
                Descricao = "Voc?? tem vantagem em testes de resist??ncia contra veneno e tem resist??ncia contra dano de veneno"
            },
            //26, Ancestral Drac??nico
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 26,
                Nome = "Ancestral Drac??nico",
                Descricao = "Voc?? possui um ancestral drac??nico. Escolha um tipo de drag??o da tablea Ancestral Drac??nico. sua arma de sopro e resist??ncia a dano s??o determinadas pelo tipo de drag??o, como mostrado na tabela"
            },
            //27, Arma de Sopro
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 27,
                Nome = "Arma de Sopro",
                Descricao = "Voc?? pode usar uma a????o para exalar energia destrutiva. Seu ancestral drac??nico determina o tamanho, formado e tipo de dano que voc?? expele.Quando voc?? usa sua arma de sopro, cada criatura na ??rea exalada deve realizar um teste de resist??ncia, o tipo do teste ?? determinado pelo seu ancestral drac??nico. A CD do teste de resist??ncia ?? 8 + seu modificador de Constitui????o + seu b??nus de profici??ncia. Uma criatura sofre 2d6 de dano num fracasso e metade desse dano num sucesso. O dano aumenta para 3d6 no 6?? n??vel, 4d6 no 11?? n??vel e 5d6 no 16?? n??vel. Depois de usar sua arma de sopro, voc?? n??o poder?? utiliz??-la novamente at?? completar um descanso curto ou longo. "
            },
            //28, Resist??ncia a Dano
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 28,
                Nome = "Resist??ncia a Dano",
                Descricao = "Voc?? possui resist??ncia ao tipo de dano associado ao seu ancestral drac??nico"
            },
            //29, Esperteza Gn??mica
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 29,
                Nome = "Esperteza Gn??mica",
                Descricao = "Voc?? possui vantagem em todos os testes de resist??ncia de Intelig??ncia, Sabedoria e Carisma contra magia"
            },
            //30, Ilusionista Nato
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 30,
                Nome = "Ilusionista Nato",
                Descricao = "Voc?? conhece o truque ilus??o menor. Intelig??ncia ?? a sua habilidade usada para cunjur??-la"
            },
            //31, Falar com Bestas Pequenas
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 31,
                Nome = "Falar com Bestas Pequenas",
                Descricao = "Atrav??s de sons e gestos, voc?? pode comunicar ideias simples para Bestas pequenas ou menores. Gnomos da floresta amam os animais e normalmente possuem esquilos, doninhas, coelhos, toupeiras, pica-paus e outras criaturas como amados animais de estima????o. "
            },
            //32, Conhecimento de Art??fice
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 32,
                Nome = "Conhecimento de Art??fice",
                Descricao = "Toda vez que voc?? fizer um teste de Intelig??ncia (Hist??ria) relacionado a itens m??gicos, objetos alqu??micos ou mecanismos tecnol??gicos, voc?? pode adicionar o dobro do seu b??nus de profici??ncia, ao inv??s de qualquer b??nus de profici??ncia que voc?? normalmente use. "
            },
            //33, Engenhoqueiro
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 33,
                Nome = "Engenhoqueiro",
                Descricao = "Voc?? possui profici??ncia com ferramentas de artes??o (ferramentas de engenhoqueiro). Usando essas ferramentas, voc?? pode gastar 1 hora e 10 po em materiais para construir um mecanismo Mi??do (CA 5, 1 pv). O mecanismo para de funcionar ap??s 24 horas (a n??o ser que voc?? gaste 1 hora reparando-o para manter o mecanismo funcionando), ou quando voc?? usa sua a????o para desmantel??-lo; nesse momento, voc?? pode recuperar o material usado para cri??-lo. Voc?? pode ter at?? tr??s desses mecanismos ativos ao mesmo tempo. Quando voc?? criar um mecanismo, escolha uma das seguintes op????es: Brinquedo Mec??nico. Esse brinquedo ?? um animal, monstro ou pessoa mec??nica, como um sapo, rato, p??ssaro, drag??o ou soldado. Quando colocado no ch??o, o brinquedo se move 1,5 metro pelo ch??o em cada um dos seus turnos em uma dire????o aleat??ria. Ele faz barulhos apropriados a criatura que ele representa. Isqueiro Mec??nico. O mecanismo produz uma miniatura de chama, que voc?? pode usar para acender uma vela, tocha ou fogueira. Usar o mecanismo requer sua a????o. Caixa de M??sica. Quando aberta, essa caixa de m??sica toca uma can????o a um volume moderado. A caixa para de tocar quando alcan??a o fim da m??sica ou quando ?? fechada."
            },
            //34, Versatilidade em Per??cia
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 34,
                Nome = "Versatilidade em Per??cia",
                Descricao = "Voc?? ganha profici??ncia em duas per??cias, ?? sua escolha"
            },
            //35, Amea??ador
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 35,
                Nome = "Amea??ador",
                Descricao = "Voc?? adquire profici??ncia na per??cia Intimida????o"
            },
            //36, Resist??ncia Implac??vel
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 36,
                Nome = "Resist??ncia Implac??vel",
                Descricao = "Quando voc?? ?? reduzido a 0 pontos de vida mas n??o ?? completamente morto, voc?? pode voltar para 1 ponto de vida. voc?? n??o pode usar essa caracter??stica novamente at?? completar um descanso longo."
            },
            //37, Ataques Selvagens
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 37,
                Nome = "Ataques Selvagens",
                Descricao = "Quando voc?? atinge um ataque cr??tico com uma arma corpo-a-corpo, voc?? pode rolar um dos dados de dano da arma mais uma vez e adicion??-lo ao dano extra causado pelo cr??tico"
            },
            //38, Resist??ncia Infernal
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 38,
                Nome = "Resist??ncia Infernal",
                Descricao = "Voc?? possui resist??ncia a dano do fogo"
            },
            //39, Legado Infernal
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 39,
                Nome = "Legado Infernal",
                Descricao = "Voc?? conhece o truque taumaturgia. Quando voc?? atingir o 3?? n??vel, voc?? poder?? conjurar a magia repreens??o infernal como uma magia de 2?? n??vel. Quando voc?? atingir o 5?? n??vel, voc?? tamb??m poder?? conjurar a magia escurid??o. Voc?? precisa terminar um descanso longo para poder usar as magias desse tra??o novamente. Sua habilidade de conjura????o para essas magias ?? Carisma. "
            }
        );
        }
        //IdTipoIdioma, Tipo
        {
            modelBuilder.Entity<TipoIdioma>().HasData(
            //1, Padr??o
            new TipoIdioma
            {
                IdTipoIdioma = 1,
                Tipo = "Padr??o"
            },
            //2, Ex??tico
            new TipoIdioma
            {
                IdTipoIdioma = 2,
                Tipo = "Ex??tico"
            }
        );
        }
        //IdIdioma, Nome, FaladoPor, Alfabeto, IdTipoIdioma
        {
            modelBuilder.Entity<Idioma>().HasData(
            //1, An??o, An??es, An??o, 1
            new Idioma
            {
                IdIdioma = 1,
                Nome = "An??o",
                FaladoPor = "An??es",
                Alfabeto = "An??o",
                IdTipoIdioma = 1
            },
            //2, Comum, Humanos, Comum, 1
            new Idioma
            {
                IdIdioma = 2,
                Nome = "Comum",
                FaladoPor = "Humanos",
                Alfabeto = "Comum",
                IdTipoIdioma = 1
            },
            //3, ??lfico, Elfos, ??lfico, 1
            new Idioma
            {
                IdIdioma = 3,
                Nome = "??lfico",
                FaladoPor = "Elfos",
                Alfabeto = "??lfico",
                IdTipoIdioma = 1
            },
            //4, Gigante, Ogros e gigantes, An??o, 1
            new Idioma
            {
                IdIdioma = 4,
                Nome = "Gigante",
                FaladoPor = "Ogros, gigantes",
                Alfabeto = "An??o",
                IdTipoIdioma = 1
            },
            //5, Gn??mico, Gnomos, An??o, 1
            new Idioma
            {
                IdIdioma = 5,
                Nome = "Gn??mico",
                FaladoPor = "Gnomos",
                Alfabeto = "An??o",
                IdTipoIdioma = 1
            },
            //6, Goblin, Goblinoides, An??o, 1
            new Idioma
            {
                IdIdioma = 6,
                Nome = "Goblin",
                FaladoPor = "Goblinoides",
                Alfabeto = "An??o",
                IdTipoIdioma = 1
            },
            //7, Halfling, Halfling, Comum, 1
            new Idioma
            {
                IdIdioma = 7,
                Nome = "Halfling",
                FaladoPor = "Halfings",
                Alfabeto = "Comum",
                IdTipoIdioma = 1
            },
            //8, Orc, Orcs, An??o, 1
            new Idioma
            {
                IdIdioma = 8,
                Nome = "Orc",
                FaladoPor = "Orcs",
                Alfabeto = "An??o",
                IdTipoIdioma = 1
            },
            //9, Abissal, Dem??nios, Infernal, 2
            new Idioma
            {
                IdIdioma = 9,
                Nome = "Abissal",
                FaladoPor = "Dem??nios",
                Alfabeto = "Infernal",
                IdTipoIdioma = 2
            },
            //10, Celestial, Celestiais, Celestial, 2
            new Idioma
            {
                IdIdioma = 10,
                Nome = "Celestial",
                FaladoPor = "Celestiais",
                Alfabeto = "Celestial",
                IdTipoIdioma = 2
            },
            //11, Dialeto Subterr??neo, Devoradores de Mente e Observadores, -, 2
            new Idioma
            {
                IdIdioma = 11,
                Nome = "Dialeto Subterr??neo",
                FaladoPor = "Devoradores de mente, Observadores",
                Alfabeto = "-",
                IdTipoIdioma = 2
            },
            //12, Drac??nico, Drag??es e Draconatos, Drac??nico, 2
            new Idioma
            {
                IdIdioma = 12,
                Nome = "Drac??nico",
                FaladoPor = "Drag??es, Draconatos",
                Alfabeto = "Drac??nico",
                IdTipoIdioma = 2
            },
            //13, Infernal, Diabos, Infernal, 2
            new Idioma
            {
                IdIdioma = 13,
                Nome = "Infernal",
                FaladoPor = "Diabos",
                Alfabeto = "Infernal",
                IdTipoIdioma = 2
            },
            //14, Primordial, Elementais, An??o, 2
            new Idioma
            {
                IdIdioma = 14,
                Nome = "Primordial",
                FaladoPor = "Elementais",
                Alfabeto = "An??o",
                IdTipoIdioma = 2
            },
            //15, Silvestre, Criaturas fe??ricas, ??lfico, 2
            new Idioma
            {
                IdIdioma = 15,
                Nome = "Silvestre",
                FaladoPor = "Criaturas fe??ricas",
                Alfabeto = "??lfico",
                IdTipoIdioma = 2
            },
            //16, Subcomum, Comerciantes do Subterr??neo, ??lfico, 2
            new Idioma
            {
                IdIdioma = 16,
                Nome = "Subcomum",
                FaladoPor = "Comerciantes do Subterr??neo",
                Alfabeto = "??lfico",
                IdTipoIdioma = 2
            }
        );
        }
        //IdItem, Nome, Peso, Preco, Descricao
        {
            modelBuilder.Entity<Item>().HasData(
            //1, ??baco, -, -, -
            new Item
            {
                IdItem = 1,
                Nome = "??baco",
                Peso = "1 Kg",
                Preco = "2 Pe??as de Ouro",
                Descricao = ""
            },
            //2, ??cido (vidro), -, -, -
            new Item
            {
                IdItem = 2,
                Nome = "??cido (vidro)",
                Peso = "0.5 Kg",
                Preco = "25 Pe??as de Ouro",
                Descricao = ""
            },
            //3, ??gua Benta (fresco), -, -, -
            new Item
            {
                IdItem = 3,
                Nome = "??gua Benta (frasco)",
                Peso = "0.5 Kg",
                Preco = "25 Pe??as de Ouro",
                Descricao = "Usando uma a????o, voc?? pode espalhar o conte??do desse frasco em uma criatura a at?? 1,5 metro de voc?? ou arremessar a at?? 6 metros, quebrando o frasco com o impacto. Em ambos os casos, voc?? deve realizar um ataque ?? dist??ncia contra uma criatura alvo, tratando a ??gua benta como uma arma improvisada. Se o alvo for um corruptor ou morto-vivo, ele sofre 2d6 de dano radiante. Um cl??rigo ou paladino pode criar ??gua benta realizando um ritual especial. O ritual leva 1 hora para ser realizado, consome 25 po de prata em p?? e exige que se gaste um espa??o de magia de 1?? n??vel. "
            },
            //4, Algema, -, -, -
            new Item
            {
                IdItem = 4,
                Nome = "Algemas",
                Peso = "2 Kg",
                Preco = "2 Pe??as de Ouro",
                Descricao = " Essas algemas de metal podem prender uma criatura Pequena ou M??dia. Escapar das algemas exige sucesso em um teste de Destreza CD 20. Quebr??-las exige um teste de For??a CD 20 bem sucedido. Cada conjunto de algemas vem com uma chave. Sem a chave, uma criatura proficiente com ferramentas de ladr??o pode abrir a fechadura das algemas com um sucesso em um teste de Destreza CD 15. As algemas t??m 15 pontos de vida. "
            },
            //5, Algibeira, -, -, -
            new Item
            {
                IdItem = 5,
                Nome = "Algibeira",
                Peso = "0.5 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = " Uma bolsa de pano ou couro que pode armazenar at?? 20 muni????es de funda ou 50 muni????es de zarabatana, entre outras coisas. Para armazenar componentes de magia, veja bolsa de componentes, tamb??m descrita nessa se????o. "
            },
            //6, Aljava, -, -, -
            new Item
            {
                IdItem = 6,
                Nome = "Aljava",
                Peso = "0.5 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = " Uma aljava pode guardar at?? 20 flechas."
            },
            //7, Ampulheta, -, -, -
            new Item
            {
                IdItem = 7,
                Nome = "Ampulheta",
                Peso = "0.5 Kg",
                Preco = "25 Pe??as de Ouro",
                Descricao = ""
            },
            //8, Ant??doto, -, -, -
            new Item
            {
                IdItem = 8,
                Nome = "Ant??doto",
                Peso = "0.5 Kg",
                Preco = "50 Pe??as de Ouro",
                Descricao = "Uma criatura que beber o l??quido desse vidro tem vantagem em testes de resist??ncia contra venenos por 1 hora. O ant??doto n??o confere nenhum benef??cio para mortos-vivos ou constructos. "
            },
            //9, Apito de advert??ncia, -, -, -
            new Item
            {
                IdItem = 9,
                Nome = "Apito de advert??ncia",
                Peso = "0.5 Kg",
                Preco = "25 Pe??as de Ouro",
                Descricao = ""
            },
            //10, Ar??ete port??til, -, -, -
            new Item
            {
                IdItem = 10,
                Nome = "Ar??ete port??til",
                Peso = "17.5 Kg",
                Preco = "4 Pe??as de Ouro",
                Descricao = "Voc?? pode usar um ar??ete port??til para quebrar portas. Ao fazer isso, voc?? ganha um b??nus de +4 no teste de For??a. Outra criatura pode ajud??-lo a usar o ar??ete, o que concede vantagem no teste. "
            },
            //11, Armadilha de ca??a, -, -, -
            new Item
            {
                IdItem = 11,
                Nome = "Armadilha de ca??a",
                Peso = "12.5 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = "Quando voc?? usa sua a????o para arm??-la, essa armadilha forma um anel de a??o com dentes serrilhados. Eles se fecham quando uma criatura pisa sobre uma placa de press??o no seu centro. A armadilha ?? fixada por uma pesada corrente em um objeto fixo e im??vel, como uma ??rvore ou um cravo enterrado no ch??o. Uma criatura que pisar na placa de press??o deve ser bem sucedida em um teste de resist??ncia de Destreza CD 13 ou sofrer?? 1d4 de dano perfurante e para de se mover. Da?? em diante, at?? que a criatura se liberte da armadilha, seu movimento ?? limitado ao comprimento da corrente (tipicamente 1 metro de comprimento). A criatura presa pode usar sua a????o para fazer um teste de For??a CD 13 e se libertar, ou outra criatura no alcance pode fazer o teste para libert??-la. Cada fracasso no teste causa 1 de dano perfurante ?? criatura presa. "
            },
            //12, Arp??u, -, -, -
            new Item
            {
                IdItem = 12,
                Nome = "Arp??u",
                Peso = "2 Kg",
                Preco = "2 Pe??as de Ouro",
                Descricao = ""
            },
            //13, Balan??a de mercador, -, -, -
            new Item
            {
                IdItem = 13,
                Nome = "Balan??a de mercador",
                Peso = "1.5 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = "Trata-se de uma pequena balan??a, pratos e um sortimento adequado de pesos de at?? 1 kg. Com ela, voc?? pode medir o peso exato de pequenos objetos, como metais preciosos brutos ou bens comerciais, para ajudar a determinar seu valor. "
            },
            //14, Balde, -, -, -
            new Item
            {
                IdItem = 14,
                Nome = "Balde",
                Peso = "1.5 Kg",
                Preco = "5 Pe??as de Cobre",
                Descricao = ""
            },
            //15, Barril, -, -, -
            new Item
            {
                IdItem = 15,
                Nome = "Barril",
                Peso = "35 Kg",
                Preco = "2 Pe??as de Ouro",
                Descricao = ""
            },
            //16, Ba??, -, -, -
            new Item
            {
                IdItem = 16,
                Nome = "Ba??",
                Peso = "12.5 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //17, Bolsa de componentes, -, -, -
            new Item
            {
                IdItem = 17,
                Nome = "Bolsa de componentes",
                Peso = "1 Kg",
                Preco = "25 Pe??as de Ouro",
                Descricao = "Trata-se de uma pequena bolsa de couro ?? prova d'??gua que pode ser fixada em um cinto. Ela possui compartimentos para armazenar todos os componentes materiais e outros itens especiais que voc?? precisa para lan??ar suas magias, exceto os componentes que possuem um custo espec??fico (conforme indicado na descri????o da magia)."
            },
            //18, Caixa de Fogo, -, -, -
            new Item
            {
                IdItem = 18,
                Nome = "Caixa de Fogo",
                Peso = "0.5 Kg",
                Preco = "5 Pe??as de Prata",
                Descricao = "Esse pequeno recipiente det??m uma pederneira, isqueiro e um pavio (um pano geralmente seco embebido em ??leo) usado para acender uma fogueira. Us??-lo para acender uma tocha ??? ou qualquer outra coisa exposta a um combust??vel abundante ??? leva uma a????o. Acender qualquer outro fogo leva 1 minuto "
            },
            //19, Caneca, -, -, -
            new Item
            {
                IdItem = 19,
                Nome = "Caneca",
                Peso = "0.5 Kg",
                Preco = "2 Pe??as de Cobre",
                Descricao = ""
            },
            //20, Caneta Tinteiro, -, -, -
            new Item
            {
                IdItem = 20,
                Nome = "Caneta Tinteiro",
                Peso = "",
                Preco = "2 Pe??as de Cobre",
                Descricao = ""
            },
            //21, Cantil, -, -, -
            new Item
            {
                IdItem = 21,
                Nome = "Cantil",
                Peso = "2.5 Kg",
                Preco = "2 Pe??as de Prata",
                Descricao = ""
            },
            //22, Cesto, -, -, -
            new Item
            {
                IdItem = 22,
                Nome = "Cesto",
                Peso = "1 Kg",
                Preco = "4 Pe??as de Prata",
                Descricao = ""
            },
            //23, Cobertor de inverno, -, -, -
            new Item
            {
                IdItem = 23,
                Nome = "Cobertor de inverno",
                Peso = "1.5 Kg",
                Preco = "5 Pe??as de Prata",
                Descricao = ""
            },
            //24, Corda de c??nhamo (15 metros), -, -, -
            new Item
            {
                IdItem = 24,
                Nome = "Corda de c??nhamo (15 metros)",
                Peso = "5 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //25, Corda de seda (15 metros), -, -, -
            new Item
            {
                IdItem = 25,
                Nome = "Corda de seda (15 metros)",
                Peso = "2.5 Kg",
                Preco = "10 Pe??as de Ouro",
                Descricao = ""
            },
            //26, Corrente (3 metros), -, -, -
            new Item
            {
                IdItem = 26,
                Nome = "Corrente",
                Peso = "5 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //27, Equipamento de pescaria, -, -, -
            new Item
            {
                IdItem = 27,
                Nome = "Equipamento de pescaria",
                Peso = "2 Kg",
                Preco = "1 Pe??a Ouro",
                Descricao = ""
            },
            //28, Escada (3 metros)
            new Item
            {
                IdItem = 28,
                Nome = "Escadas",
                Peso = "12.5 Kg",
                Preco = "1 Pe??a Prata",
                Descricao = ""
            },
            //29, Esferas (sacola com 1000)
            new Item
            {
                IdItem = 29,
                Nome = "Esferas (sacola com 1000)",
                Peso = "1 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //30, Espelho de a??o
            new Item
            {
                IdItem = 30,
                Nome = "Espelho de a??o",
                Peso = "0.25 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //31, Estrepes (bolsa com 20)
            new Item
            {
                IdItem = 31,
                Nome = "Estrepes (bolsa com 20)",
                Peso = "1 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //32 Fechadura
            new Item
            {
                IdItem = 32,
                Nome = "Fechadura",
                Peso = "0.5 Kg",
                Preco = "10 Pe??as de Ouro",
                Descricao = ""
            },
            //33 Bast??o (Foco Arcano)
            new Item
            {
                IdItem = 33,
                Nome = "Bast??o",
                Peso = "1 Kg",
                Preco = "10 Pe??as de Ouro",
                Descricao = ""
            },
            //34, Cajado (Foco Arcano)
            new Item
            {
                IdItem = 34,
                Nome = "Cajado",
                Peso = "2 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //35, Cristal (Foco Arcano)
            new Item
            {
                IdItem = 35,
                Nome = "Cristal",
                Peso = "0.5 Kg",
                Preco = "10 Pe??as de Ouro",
                Descricao = ""
            },
            //36, Orbe (Foco Arcano)
            new Item
            {
                IdItem = 36,
                Nome = "Orbe",
                Peso = "1.5 Kg",
                Preco = "20 Pe??as de Ouro",
                Descricao = ""
            },
            //37, Varinha (Foco Arcano)
            new Item
            {
                IdItem = 37,
                Nome = "Varinha",
                Peso = "0.5 Kg",
                Preco = "10 Pe??as de Ouro",
                Descricao = ""
            },
            //38, Cajado de madeira (Foco Dru??dico)
            new Item
            {
                IdItem = 38,
                Nome = "Cajado de madeira",
                Peso = "2 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //39, Ramo de visco (Foco Dru??dico)
            new Item
            {
                IdItem = 39,
                Nome = "Ramo de visco",
                Peso = "-",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //40, Totem (Foco Dru??dico)
            new Item
            {
                IdItem = 40,
                Nome = "Totem",
                Peso = "-",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //41, Varinha de teixo (Foco Dru??dico)
            new Item
            {
                IdItem = 41,
                Nome = "Varinha de teixo",
                Peso = "0.5 Kg",
                Preco = "10 Pe??as de Ouro",
                Descricao = ""
            },
            //42, Fogo alqu??mico (frasco)
            new Item
            {
                IdItem = 42,
                Nome = "Fogo alqu??mico (frasco)",
                Peso = "0.5 Kg",
                Preco = "50 Pe??as de Ouro",
                Descricao = ""
            },
            //43, Frasco
            new Item
            {
                IdItem = 43,
                Nome = "Frasco",
                Peso = "1 Kg",
                Preco = "2 Pe??as de Cobre",
                Descricao = ""
            },
            //44, Garrafa de vidro
            new Item
            {
                IdItem = 44,
                Nome = "Garrafa de vidro",
                Peso = "1 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //45, Giz (1 pe??a)
            new Item
            {
                IdItem = 45,
                Nome = "Giz (1 pe??a)",
                Peso = "-",
                Preco = "1 Pe??a de Cobre",
                Descricao = ""
            },
            //46, Grim??rio
            new Item
            {
                IdItem = 46,
                Nome = "Grim??rio",
                Peso = "1.5 Kg",
                Preco = "50 Pe??as de Ouro",
                Descricao = ""
            },
            //47, Jarra
            new Item
            {
                IdItem = 47,
                Nome = "Jarra",
                Peso = "2 Kg",
                Preco = "4 Pe??as de Cobre",
                Descricao = ""
            },
            //48, Kit de escalada
            new Item
            {
                IdItem = 48,
                Nome = "Kit de escalada",
                Peso = "6 Kg",
                Preco = "25 Pe??as de Ouro",
                Descricao = ""
            },
            //49, Kit de primeiros-socorros
            new Item
            {
                IdItem = 49,
                Nome = "Kit de primeiros-socorros",
                Peso = "1.5 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //50, L??mpada
            new Item
            {
                IdItem = 50,
                Nome = "L??mpada",
                Peso = "0.5 Kg",
                Preco = "5 Pe??as de Prata",
                Descricao = ""
            },
            //51, Lanterna coberta
            new Item
            {
                IdItem = 51,
                Nome = "Lanterna coberta",
                Peso = "1 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //52, Lanterna furta-fogo
            new Item
            {
                IdItem = 52,
                Nome = "Lanterna furta-fogo",
                Peso = "1 Kg",
                Preco = "10 Pe??as de Ouro",
                Descricao = ""
            },
            //53, Lente de aumento
            new Item
            {
                IdItem = 53,
                Nome = "Lente de aumento",
                Peso = "-",
                Preco = "100 Pe??as de Ouro",
                Descricao = ""
            },
            //54, Livro
            new Item
            {
                IdItem = 54,
                Nome = "Livro",
                Peso = "2.5 Kg",
                Preco = "25 Pe??as de Ouro",
                Descricao = ""
            },
            //55, Luneta
            new Item
            {
                IdItem = 55,
                Nome = "Luneta",
                Peso = "0.5 Kg",
                Preco = "1000 Pe??as de Ouro",
                Descricao = ""
            },
            //56, Manto
            new Item
            {
                IdItem = 56,
                Nome = "Manto",
                Peso = "2 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //57, Marreta
            new Item
            {
                IdItem = 57,
                Nome = "Marreta",
                Peso = "5 Kg",
                Preco = "2 Pe??as de Ouro",
                Descricao = ""
            },
            //58, Martelo
            new Item
            {
                IdItem = 58,
                Nome = "Martelo",
                Peso = "1.5 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //59, Mochila
            new Item
            {
                IdItem = 59,
                Nome = "Mochila",
                Peso = "2.5 Kg",
                Preco = "2 Pe??as de Ouro",
                Descricao = ""
            },
            //60 Balas de Funda (20) (Muni????o)
            new Item
            {
                IdItem = 60,
                Nome = "Balas de Funda (20)",
                Peso = "0.75 Kg",
                Preco = "4 Pe??as de Cobre",
                Descricao = ""
            },
            //61 Flechas (20) (Muni????o)
            new Item
            {
                IdItem = 61,
                Nome = "Flechas (20)",
                Peso = "0.5 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //62, Virotes (20) (Muni????o)
            new Item
            {
                IdItem = 62,
                Nome = "Virotes (20)",
                Peso = "0.75 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //63, Zarabatana (20) (Muni????o)
            new Item
            {
                IdItem = 63,
                Nome = "Zarabatana (20)",
                Peso = "0.5 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //64, ??leo (frasco)
            new Item
            {
                IdItem = 64,
                Nome = "??leo (frasco)",
                Peso = "0.5 Kg",
                Preco = "1 Pe??a de Prata",
                Descricao = ""
            },
            //65, P??
            new Item
            {
                IdItem = 65,
                Nome = "P??",
                Peso = "2.5 Kg",
                Preco = "2 Pe??as de Ouro",
                Descricao = ""
            },
            //66, Panela de Ferro
            new Item
            {
                IdItem = 66,
                Nome = "Panela de Ferro",
                Peso = "5 Kg",
                Preco = "2 Pe??as de Ouro",
                Descricao = ""
            },
            //67, Papel (uma folha)
            new Item
            {
                IdItem = 67,
                Nome = "Papel (uma folha)",
                Peso = "-",
                Preco = "2 Pe??as de Prata",
                Descricao = ""
            },
            //68, Parafina
            new Item
            {
                IdItem = 68,
                Nome = "Parafina",
                Peso = "-",
                Preco = "5 Pe??as de Prata",
                Descricao = ""
            },
            //69, P?? de cabra
            new Item
            {
                IdItem = 69,
                Nome = "P?? de cabra",
                Peso = "2.5 Kg",
                Preco = "2 Pe??as de Ouro",
                Descricao = ""
            },
            //70, Pedra de amolar
            new Item
            {
                IdItem = 70,
                Nome = "Pedra de amolar",
                Peso = "-",
                Preco = "1 Pe??a de Cobre",
                Descricao = ""
            },
            //71, Perfume (frasco)
            new Item
            {
                IdItem = 71,
                Nome = "Perfume (frasco)",
                Peso = "-",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //72, Pergaminho (uma folha)
            new Item
            {
                IdItem = 72,
                Nome = "Pergaminho (uma folha",
                Peso = "-",
                Preco = "1 Pe??a de Prata",
                Descricao = ""
            },
            //73, Picareta de Minerador
            new Item
            {
                IdItem = 73,
                Nome = "Picareta de minerador",
                Peso = "5 Kg",
                Preco = "2 Pe??as de Ouro",
                Descricao = ""
            },
            //74, P??ton
            new Item
            {
                IdItem = 74,
                Nome = "P??ton",
                Peso = "-",
                Preco = "5 Pe??as de Cobre",
                Descricao = ""
            },
            //75, Po????o de Cura
            new Item
            {
                IdItem = 75,
                Nome = "Po????o de Cura",
                Peso = "0.25 Kg",
                Preco = "50 Pe??as de Ouro",
                Descricao = ""
            },
            //76, Porta mapas ou pergaminhos
            new Item
            {
                IdItem = 76,
                Nome = "Porta mapas ou pergaminhos",
                Peso = "0.5 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //77, Porta virotes
            new Item
            {
                IdItem = 77,
                Nome = "Porta virotes",
                Peso = "0.5 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //78, Pregos de ferro (10)
            new Item
            {
                IdItem = 78,
                Nome = "Pregos de ferro (10)",
                Peso = "2.5 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //79, Ra????es de viagem (1 dia)
            new Item
            {
                IdItem = 79,
                Nome = "Ra????es de viagem (1 dia)",
                Peso = "1 Kg",
                Preco = "5 Pe??as de Prata",
                Descricao = ""
            },
            //80, Robes
            new Item
            {
                IdItem = 80,
                Nome = "Robes",
                Peso = "2 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //81, Roldana e polia
            new Item
            {
                IdItem = 81,
                Nome = "Roldana e polia",
                Peso = "2.5 Kg",
                Preco = "2 Pe??as de Ouro",
                Descricao = ""
            },
            //82, Roupas comuns
            new Item
            {
                IdItem = 82,
                Nome = "Roupas comuns",
                Peso = "1.5 Kg",
                Preco = "5 Pe??as de Prata",
                Descricao = ""
            },
            //83, Roupas de viajante
            new Item
            {
                IdItem = 83,
                Nome = "Roupas de viajante",
                Peso = "2 Kg",
                Preco = "2 Pe??as de Ouro",
                Descricao = ""
            },
            //84, Roupas de entretenimento
            new Item
            {
                IdItem = 84,
                Nome = "Roupas de entretenimento",
                Peso = "2 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //85, Roupas finas
            new Item
            {
                IdItem = 85,
                Nome = "Roupas finas",
                Peso = "3 Kg",
                Preco = "15 Pe??as de Ouro",
                Descricao = ""
            },
            //86, Sab??o
            new Item
            {
                IdItem = 86,
                Nome = "Sab??o",
                Peso = "-",
                Preco = "1 Pe??as de Cobre",
                Descricao = ""
            },
            //87, Saco
            new Item
            {
                IdItem = 87,
                Nome = "Saco",
                Peso = "0.25 Kg",
                Preco = "1 Pe??a de Cobre",
                Descricao = ""
            },
            //88, Saco de dormir
            new Item
            {
                IdItem = 88,
                Nome = "Saco de dormir",
                Peso = "3.5 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //89, Amuleto (S??mbolo Sagrado)
            new Item
            {
                IdItem = 89,
                Nome = "Amuleto",
                Peso = "0.5 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //90 Emblema (S??mbolo Sagrado)
            new Item
            {
                IdItem = 90,
                Nome = "Emblema",
                Peso = "-",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //91 Relic??rio (S??mbolo Sagrado)
            new Item
            {
                IdItem = 91,
                Nome = "Relic??rio",
                Peso = "1 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //92, Sinete
            new Item
            {
                IdItem = 92,
                Nome = "Sinete",
                Peso = "-",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //93, Sino
            new Item
            {
                IdItem = 93,
                Nome = "Sino",
                Peso = "-",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //94, Tenda para duas pessoas
            new Item
            {
                IdItem = 94,
                Nome = "Tenda para duas pessoas",
                Peso = "10 Kg",
                Preco = "2 Pe??as de Ouro",
                Descricao = ""
            },
            //95, Tocha
            new Item
            {
                IdItem = 95,
                Nome = "Tocha",
                Peso = "0.5 Kg",
                Preco = "1 Pe??a de Cobre",
                Descricao = ""
            },
            //96, Tinta (frasco de 30ml)
            new Item
            {
                IdItem = 96,
                Nome = "Tinta (frasco de 30 ml)",
                Peso = "-",
                Preco = "10 Pe??as de Ouro",
                Descricao = ""
            },
            //97, Vara (3 metros)
            new Item
            {
                IdItem = 97,
                Nome = "Vara (3 metros)",
                Peso = "3.5 Kg",
                Preco = "5 Pe??as de Cobre",
                Descricao = ""
            },
            //98, Vela
            new Item
            {
                IdItem = 98,
                Nome = "Vela",
                Peso = "-",
                Preco = "1 Pe??a de Cobre",
                Descricao = ""
            },
            //99, Veneno b??sico (frasco)
            new Item
            {
                IdItem = 99,
                Nome = "Veneno b??sico (frasco)",
                Peso = "-",
                Preco = "100 Pe??as de Ouro",
                Descricao = ""
            },
            //100, Ferramentas de carpinteiro
            new Item
            {
                IdItem = 100,
                Nome = "Ferramentas de carpinteiro",
                Peso = "3 Kg",
                Preco = "8 Pe??as de Ouro",
                Descricao = ""
            },
            //101, Ferramentas de cart??grafo
            new Item
            {
                IdItem = 101,
                Nome = "Ferramentas de cart??grafo",
                Peso = "3 Kg",
                Preco = "15 Pe??as de Ouro",
                Descricao = ""
            },
            //102, Ferramentas de costureiro
            new Item
            {
                IdItem = 102,
                Nome = "Ferramentas de costureiro",
                Peso = "2.5 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //103, Ferramentas de entalhador
            new Item
            {
                IdItem = 103,
                Nome = "Ferramentas de entalhador",
                Peso = "2.5 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //104, Ferramentas de ferreiro
            new Item
            {
                IdItem = 104,
                Nome = "Ferramentas de ferreiro",
                Peso = "4 Kg",
                Preco = "20 Pe??as de Ouro",
                Descricao = ""
            },
            //105, Ferramentas de funileiro
            new Item
            {
                IdItem = 105,
                Nome = "Ferramentas de funileiro",
                Peso = "5 Kg",
                Preco = "50 Pe??as de Ouro",
                Descricao = ""
            },
            //106, Ferramentas de joalheiro
            new Item
            {
                IdItem = 106,
                Nome = "Ferramentas de joalheiro",
                Peso = "1 Kg",
                Preco = "25 Pe??as de Ouro",
                Descricao = ""
            },
            //107, Ferramentas de oleiro
            new Item
            {
                IdItem = 107,
                Nome = "Ferramentas de oleiro",
                Peso = "1.5 Kg",
                Preco = "10 Pe??as de Ouro",
                Descricao = ""
            },
            //108, Ferramentas de pedreiro
            new Item
            {
                IdItem = 108,
                Nome = "Ferramentas de pedreiro",
                Peso = "4 Kg",
                Preco = "10 Pe??as de Ouro",
                Descricao = ""
            },
            //109, Ferramentas de pintor
            new Item
            {
                IdItem = 109,
                Nome = "Ferramentas de pintor",
                Peso = "2.5 Kg",
                Preco = "10 Pe??as de Ouro",
                Descricao = ""
            },
            //110, Ferramentas de sapaterio
            new Item
            {
                IdItem = 110,
                Nome = "Ferramentas de sapateiro",
                Peso = "2.5 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //111, Ferramentas de vidreiro
            new Item
            {
                IdItem = 111,
                Nome = "Ferramentas de vidreiro",
                Peso = "2.5 Kg",
                Preco = "30 Pe??as de Ouro",
                Descricao = ""
            },
            //112, Suprimentos de alquimista
            new Item
            {
                IdItem = 112,
                Nome = "Suprimentos de alquimista",
                Peso = "4 Kg",
                Preco = "50 Pe??as de Ouro",
                Descricao = ""
            },
            //113, Supreimentos de cervejeiro
            new Item
            {
                IdItem = 113,
                Nome = "Suprimentos de cervejeiro",
                Peso = "4.5 Kg",
                Preco = "20 Pe??as de Ouro",
                Descricao = ""
            },
            //114, Suprimentos de caligrafia
            new Item
            {
                IdItem = 114,
                Nome = "Suprimentos de caligrafia",
                Peso = "2.5 Kg",
                Preco = "10 Pe??as de Ouro",
                Descricao = ""
            },
            //115, Utens??lios de cozinheiro(Ferramentas de artes??o)
            new Item
            {
                IdItem = 115,
                Nome = "Utens??lios de cozinheiro",
                Peso = "4 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //116, Ferramentas de navega????o
            new Item
            {
                IdItem = 116,
                Nome = "Ferramentas de navega????o",
                Peso = "1 Kg",
                Preco = "25 Pe??as de Ouro",
                Descricao = ""
            },
            //117, Ferramentas de ladr??o
            new Item
            {
                IdItem = 117,
                Nome = "Ferramentas de ladr??o",
                Peso = "0.5 Kg",
                Preco = "25 Pe??as de Ouro",
                Descricao = ""
            },
            //118, Ala??de (Instrumento musical)
            new Item
            {
                IdItem = 118,
                Nome = "Ala??de",
                Peso = "1 Kg",
                Preco = "35 Pe??as de Ouro",
                Descricao = ""
            },
            //119, Flauta (Instrumento musical)
            new Item
            {
                IdItem = 119,
                Nome = "Flauta",
                Peso = "0.5 Kg",
                Preco = "2 Pe??as de Ouro",
                Descricao = ""
            },
            //120, Flauta de p?? (Instrumento musical)
            new Item
            {
                IdItem = 120,
                Nome = "Flauta de p??",
                Peso = "1 Kg",
                Preco = "12 Pe??as de Ouro",
                Descricao = ""
            },
            //121, Gaita de foles (Instrumento musical)
            new Item
            {
                IdItem = 121,
                Nome = "Gaita de foles",
                Peso = "3 Kg",
                Preco = "30 Pe??as de Ouro",
                Descricao = ""
            },
            //122, Lira (Instrumento musical)
            new Item
            {
                IdItem = 122,
                Nome = "Lira",
                Peso = "1 Kg",
                Preco = "30 Pe??as de Ouro",
                Descricao = ""
            },
            //123, Obo?? (Instrumento musical)
            new Item
            {
                IdItem = 123,
                Nome = "Obo??",
                Peso = "0.5 Kg",
                Preco = "2 Pe??as de Ouro",
                Descricao = ""
            },
            //124, Tambor (Instrumento musical)
            new Item
            {
                IdItem = 124,
                Nome = "Tambor",
                Peso = "1.5 Kg",
                Preco = "6 Pe??as de Ouro",
                Descricao = ""
            },
            //125, Trombeta (Instrumento musical)
            new Item
            {
                IdItem = 125,
                Nome = "Trombeta",
                Peso = "1 Kg",
                Preco = "3 Pe??as de Ouro",
                Descricao = ""
            },
            //126, Violino (Instrumento musical)
            new Item
            {
                IdItem = 126,
                Nome = "Violino",
                Peso = "3 Kg",
                Preco = "30 Pe??as de Ouro",
                Descricao = ""
            },
            //127, Xilofone (Instrumento musical)
            new Item
            {
                IdItem = 127,
                Nome = "Xilofone",
                Peso = "5 Kg",
                Preco = "25 Pe??as de Ouro",
                Descricao = ""
            },
            //128, Kit de disfarce
            new Item
            {
                IdItem = 128,
                Nome = "Kit de disfarce",
                Peso = "1.5 Kg",
                Preco = "25 Pe??as de Ouro",
                Descricao = ""
            },
            //129, Kit de falsifica????o
            new Item
            {
                IdItem = 129,
                Nome = "Kit de falsifica????o",
                Peso = "2.5 Kg",
                Preco = "15 Pe??as de Ouro",
                Descricao = ""
            },
            //130, Kit de herbalismo
            new Item
            {
                IdItem = 130,
                Nome = "Kit de herbalismo",
                Peso = "1.5 Kg",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //131, Baralho de cartas (Kit de jogo)
            new Item
            {
                IdItem = 131,
                Nome = "Baralho de cartas",
                Peso = "-",
                Preco = "5 Pe??as de Prata",
                Descricao = ""
            },
            //132, Conjunto de dados (Kit de jogo)
            new Item
            {
                IdItem = 132,
                Nome = "Conjunto de dados",
                Peso = "-",
                Preco = "1 Pe??a de Prata",
                Descricao = ""
            },
            //133, Jogo dos tr??s drag??es (Kit de jogo)
            new Item
            {
                IdItem = 133,
                Nome = "Jogo dos tr??s drag??es",
                Peso = "-",
                Preco = "5 Pe??as de Ouro",
                Descricao = ""
            },
            //134, Xadrez do drag??o (Kit de jogo)
            new Item
            {
                IdItem = 134,
                Nome = "Xadrez do drag??o",
                Peso = "0.25 Kg",
                Preco = "1 Pe??a de Ouro",
                Descricao = ""
            },
            //135, Kit de venenos
            new Item
            {
                IdItem = 135,
                Nome = "Kit de venenos",
                Peso = "1 Kg",
                Preco = "50 Pe??as de Ouro",
                Descricao = ""
            },
            //136, Pacote de Artista
            new Item
            {
                IdItem = 136,
                Nome = "Pacote de Artista",
                Peso = "-",
                Preco = "40 Pe??as de Ouro",
                Descricao = "Mochila; saco de dormir; duas fantasias; 5 velas; 5 dias de ra????es; cantil; kit de disfarce"
            },
            //137, Pacote de Assaltante
            new Item
            {
                IdItem = 137,
                Nome = "Pacote de Assaltante",
                Peso = "-",
                Preco = "16 Pe??as de Ouro",
                Descricao = "Mochila; saco com 1000 esferas de metal; 3 metros de linha; sino; 5 velas; p?? de cabra; martelo; 10 p??tons; lanterna coberta; 2 fascos de ??leo; 5 dias de ra????o; caixa de fogo; cantil; 15 metros de corda de c??nhamo"
            },
            //138, Pacote de Aventureiro
            new Item
            {
                IdItem = 138,
                Nome = "Pacote de Aventureiro",
                Peso = "-",
                Preco = "12 Pe??as de Ouro",
                Descricao = "Mochila; p?? de cabra; martelo; 10 p??tons; 10 tochas; caixa de fogo; 10 dias de ra????es; cantil; 15 metros de corda de c??nhamo"
            },
            //139, Pacote de Diplomata
            new Item
            {
                IdItem = 139,
                Nome = "Pacote de Diplomata",
                Peso = "-",
                Preco = "39 Pe??as de Ouro",
                Descricao = "Ba??; 2 caixas para mapas ou pergaminhos; conjunto de roupas finas; vidro de tinta; caneta tinteiro; l??mpada; 2 frascos de ??leo; 5 folhas de papel; vidro de perfume; parafina; sab??o"
            },
            //140, Pacote de Estudioso
            new Item
            {
                IdItem = 140,
                Nome = "Pacote de Estudioso",
                Peso = "-",
                Preco = "40 Pe??as de Ouro",
                Descricao = "Mochila; livro de estudo; vidro de tinta; caneta tinteiro; 10 folhas de pergaminho; saquinho de areia; pequena faca"
            },
            //141, Pacote de Explorador
            new Item
            {
                IdItem = 141,
                Nome = "Pacote de Explorador",
                Peso = "-",
                Preco = "10 Pe??as de Ouro",
                Descricao = "Mochila; saco de dormir; kit de refei????o; caixa de fogo; 10 tochas; 10 dias de ra????es; cantil; 15 metros de corda de c??nhamo"
            },
            //142, Pacote de Sacerdote
            new Item
            {
                IdItem = 142,
                Nome = "Pacote de Sacerdote",
                Peso = "-",
                Preco = "19 Pe??as de Ouro",
                Descricao = "Mochila; cobertor; 10 velas; caixa de fogo; caixa de esmola; 2 blocos de incenso; incens??rio; vestes; 2 dias de ra????es; cantil"
            }

            );
        }
        //IdTipoMagia, Tipo
        {
            modelBuilder.Entity<TipoMagia>().HasData(
            //1, Truque
            new TipoMagia
            {
                IdTipoMagia = 1,
                Tipo = "Truque"
            },
            //2, Ciclo
            new TipoMagia
            {
                IdTipoMagia = 2,
                Tipo = "Ciclo"
            }
        );
        }
        //IdMagia, Nome, Escola, Alcance, TempodeConjuracao, Duracao, Componente, Descricao, IdTipoMagia
        {
            modelBuilder.Entity<Magia>().HasData(
            new Magia
            {
                IdMagia = 1,
                Nome = "Acalmar Emo????es",
                Escola = "Encantamento",
                Alcance = "18 metros",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 minuto",
                Componente = "Verbal, Som??tico",
                Descricao = "Voc?? tenta suprimir emo????es fortes em um grupo de pessoas.Cada humanoide em uma esfera de 6 metros de raio, centrada em um ponto que voc?? escolher dentro do alcance, deve realizar um teste de resist??ncia de Carisma; uma criatura pode escolher falhar nesse teste, se desejar. Se uma criatura falhar na resist??ncia, escolha um dentre os dois efeitos a seguir. Voc?? pode suprimir qualquer efeito que esteja deixando a criatura enfeiti??ada ou amedrontada.Quando essa magia terminar, qualquer efeito suprimido volta a funcionar, considerando que sua dura????o n??o tenha acabado nesse meio tempo. Alternativamente, voc?? pode tornar um alvo indiferente ??s criaturas que voc?? escolher que forem hostis a ele. Essa indiferen??a acaba se o alvo for atacado ou ferido por uma magia ou se ele testemunhar qualquer dos seus amigos sendo ferido.Quando a magia terminar, a criatura se tornar?? hostil novamente, a n??o ser que o Mestre diga o contr??rio. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 2,
                Nome = "Adivinha????o",
                Escola = "Adivinha????o (ritual)",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 a????o",
                Duracao = "Instant??nea",
                Componente = "Verbal, Som??tico, Material  (incenso e uma oferenda apropriada para sacrif??cio ?? sua religi??o, juntos valendo, no m??nimo, 25 po, consumidos pela magia)",
                Descricao = "Sua magia e uma oferenda colocam voc?? em contato com um deus ou servo divino. Voc?? faz uma ??nica pergunta a respeito de um objetivo, evento ou atividade espec??fico que ir?? ocorrer dentro de 7 dias. O Mestre oferece uma resposta confi??vel. A resposta deve ser uma frase curta, uma rima enigm??tica ou um press??gio. A magia n??o leva em considera????o qualquer poss??vel circunst??ncia que possa mudar o que est?? por vir, como a conjura????o de magias adicionais ou a perda ou ganho de um companheiro. Se voc?? conjurar a magia duas ou mais vezes antes de completar seu pr??ximo descanso longo, existe uma chance cumulativa de 25 por cento de cada conjura????o, depois da primeira que voc?? fez, ter um resultado aleat??rio. O Mestre faz essa jogada secretamente. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 3,
                Nome = "Ajuda",
                Escola = "Abjura????o",
                Alcance = "9 metros",
                TempodeConjuracao = "1 a????o",
                Duracao = "8 horas",
                Componente = "Verbal, Som??tico, Material  (uma pequena fita de tecido branco)",
                Descricao = "Sua magia inspira seus aliados com vigor e determina????o. Escolha at?? tr??s criaturas dentro do alcance. O m??ximo de pontos de vida e os pontos de vida atuais de cada alvo aumentam em 5, pela dura????o. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de 3?? n??vel ou superior, os pontos de vida dos alvos aumentam em 5 pontos adicionais para cada n??vel do espa??o acima do o 2??. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 4,
                Nome = "Alarme",
                Escola = "Abjura????o (ritual)",
                Alcance = "9 metros",
                TempodeConjuracao = "1 minuto",
                Duracao = "8 horas",
                Componente = "Verbal, Som??tico, Material (um pequeno sino e um pequeno fio de prata) ",
                Descricao = "Voc?? coloca um alarme para intrusos desavisados. Escolha uma porta, uma janela ou uma ??rea dentro do alcance que n??o seja maior que 6 metros c??bicos. At?? a magia acabar, um alarme alerta voc?? sempre que uma criatura Mi??da ou maior tocarem ou entrarem na ??rea protegida. Quando voc?? conjura a magia, voc?? pode designar as criaturas que n??o ativar??o o alarme. Voc?? tamb??m escolhe se o alarme ser?? mental ou aud??vel. Um alarme mental alerta voc?? com um silvo na sua mente, se voc?? estiver a at?? de 1,5 quil??metro da ??rea protegida. Esse silvo acordar?? voc?? se voc?? estiver dormindo. Um alarme aud??vel produz o som de um sino de m??o por 10 minutos num raio de 18 metros.",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 5,
                Nome = "Aliado Planar",
                Escola = "Conjura????o",
                Alcance = "18 metros",
                TempodeConjuracao = "10 minutos",
                Duracao = "Instant??nea",
                Componente = "Verbal, Som??tico",
                Descricao = "Voc?? suplica a uma entidade transcendental por ajuda. O ser deve ser conhecido por voc??: seu deus, um primordial, um pr??ncipe dem??nio ou algum outro ser de poder c??smico. Essa entidade envia um celestial, um corruptor ou um elemental leal a ela para ajudar voc??, fazendo a criatura aparecer em um espa??o desocupado dentro do alcance. Se voc?? conhecer o nome de uma criatura especifica, voc?? pode falar o nome quando conjurar essa magia para requisitar essa criatura, do contr??rio, voc?? pode receber uma criatura diferente de qualquer forma (?? escolha do Mestre). Quando a criatura aparecer, ela n??o est?? sob nenhuma compuls??o para se comportar de um modo em particular. Voc?? pode pedir a criatura que realize um servi??o em troca de um pagamento, mas ela n??o ?? obrigada a faz??-lo. A tarefa solicitada pode variar de simples (carregue-nos voando para o outro lado do abismo ou nos ajude a lutar essa batalha) a complexa (espione nossos inimigos ou nos proteja durante nossa incurs??o na masmorra). Voc?? deve ser capaz de se comunicar com a criatura para barganhar os servi??os dela. O pagamento pode ser feito de v??rias formas. Um celestial pode requerer uma generosa doa????o de ouro ou itens m??gicos para um templo aliado, enquanto que um corruptor pode exigir um sacrif??cio vivo ou uma parte dos esp??lios. Algumas criaturas podem trocar seus servi??os por uma miss??o feita por voc??. Como regra geral, uma tarefa que possa ser medida em minutos, exigir?? um pagamento de 100 po por minuto. Uma tarefa medida em horas exigir?? 1.000 po por hora. E uma tarefa medida em dias (at?? 10 dias) exigir?? 10.000 po por dia. O Mestre pode ajustar esses pagamentos baseado nas circunst??ncias pelas quais a magia foi conjurada. Se a tarefa estiver de acordo com o car??ter da criatura, o pagamento pode ser reduzido ?? metade, ou mesmo dispensado. Tarefas que n??o proporcionem perigo, tipicamente requerem apenas metade do pagamento sugerido, enquanto que tarefas especialmente perigosas podem exigir um grande presente. As criaturas raramente aceitar??o tarefas que pare??am suicidas. Ap??s a criatura completar a tarefa ou quando a dura????o acordada para o servi??o expirar, a criatura retornar?? para seu plano natal depois de relatar sua partida a voc??, se apropriado para a tarefa e se poss??vel. Se voc?? n??o for capaz de acertar um pre??o para os servi??os da criatura, ela imediatamente voltar?? para o seu plano natal. Uma criatura convidada para se juntar ao seu grupo, conta como um membro dele, recebendo sua parte total na premia????o de pontos de experi??ncia. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 6,
                Nome = "Aljava Veloz",
                Escola = "Transmuta????o",
                Alcance = "Toque",
                TempodeConjuracao = "1 a????o b??nus",
                Duracao = "Concentra????o, at?? 1 minuto",
                Componente = "V, S, M (uma aljava contendo, pelo menos, uma muni????o)",
                Descricao = "Voc?? transmuta sua aljava para que ela produza um suprimento intermin??vel de muni????es n??o-m??gicas, que parecem saltar na sua m??o quando voc?? tenta pega-las. Em cada um dos seus turnos, at?? a magia acabar, voc?? pode usar uma a????o b??nus para realizar dois ataques com uma arma que use muni????o de uma aljava. Cada vez que voc?? fizer tais ataques ?? dist??ncia, sua aljava, magicamente, rep??e a muni????o que voc?? usou com uma muni????o n??o-m??gica similar. Qualquer muni????o criada por essa magia se desintegra quando a magia acaba. Se a aljava n??o estiver mais com voc??, a magia acaba.",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 7,
                Nome = "Alterar Forma",
                Escola = "Transmuta????o",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 hora",
                Componente = "V, S, M (uma argola de jade valendo, no m??nimo, 1.500 po, que voc?? deve colocar na sua cabe??a antes de conjurar a magia) ",
                Descricao = "Voc?? assume a forma de uma criatura diferente, pela dura????o. A nova forma pode ser qualquer criatura com um n??vel de desafio igual ao seu n??vel ou menor. A criatura n??o pode ser nem um constructo nem um mortovivo e voc?? deve ter visto esse tipo de criatura pelo menos uma vez. Voc?? se transforma num exemplar m??dio da criatura, um sem quaisquer n??veis de classe nem caracter??stica Conjura????o. Suas estat??sticas de jogo s??o substitu??das pelas estat??sticas da forma escolhida, no entanto, voc?? mant??m sua tend??ncia e valores de Intelig??ncia, Sabedoria e Carisma. Voc?? tamb??m mantem suas profici??ncias em testes de resist??ncia, al??m de ganhar as da nova criatura. Se a criatura tiver a mesma profici??ncia que voc?? e o b??nus listado nas estat??sticas dela for maior que o seu, use os b??nus da criatura no lugar do seu. Voc?? n??o pode usar qualquer a????o lend??ria ou de covil da nova forma. Voc?? assume os pontos de vida e Dados de Vida da sua nova forma. Quando voc?? reverter a sua forma normal, voc?? retorna ?? quantidade de pontos de vida que tinha antes da transforma????o. Se voc?? reverter como resultado de ter ca??do a 0 pontos de vida, qualquer dano excedente ?? recebido pela sua forma normal. Contanto que o dano excedente n??o reduza os pontos de vida da sua forma normal a 0, voc?? n??o cair?? inconsciente. Voc?? mantem os benef??cios de qualquer caracter??stica da sua classe, ra??a ou outra fonte e pode usa-las, considerando que sua nova forma ?? fisicamente capaz de faz??-lo. Voc?? n??o pode usar quaisquer sentidos especiais que voc?? possua (por exemplo, vis??o no escuro) a n??o ser que a nova forma tamb??m possua o sentido. Voc?? s?? poder?? falar se a nova forma, normalmente, puder falar. Quando voc?? se transforma, voc?? pode escolher se o seu equipamento cai no ch??o, ?? assimilado a sua nova forma ou ?? usado por ela. Equipamentos vestidos e carregados funcionam normalmente. O Mestre decide qual equipamento ?? vi??vel para a nova forma vestir ou  sar, baseado na forma e tamanho da criatura. O seu equipamento n??o muda de forma ou tamanho para se adaptar ?? nova forma e, qualquer equipamento que a nova forma n??o possa vestir deve, ou cair no ch??o ou ser assimilado por ela. Equipamentos assimilados n??o ter??o efeito nesse estado. Pela dura????o da magia, voc?? pode usar sua a????o para assumir uma forma diferente, seguindo as mesmas restri????es e regras da forma anterior, com uma exce????o: se sua nova forma tiver mais pontos de vida que sua forma atual, seus pontos de vida mantem o valor atual. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 8,
                Nome = "Alterar-se",
                Escola = "Transmuta????o",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 hora",
                Componente = "V, S",
                Descricao = "Voc?? assume uma forma diferente. Quando conjurar essa magia, escolha uma das seguintes op????es, o efeito durar?? pela dura????o da magia. Enquanto a magia durar, voc?? pode terminar uma op????o com uma a????o para ganhar os benef??cios de uma diferente. Adapta????o Aqu??tica. Voc?? adapta seu corpo para um ambiente aqu??tico, brotando guelras e crescendo membranas entre seus dedos. Voc?? pode respirar embaixo d?????gua e ganha deslocamento de nata????o igual a seu deslocamento terrestre. Mudar Apar??ncia. Voc?? transforam sua apar??ncia. Voc?? decide com o que voc?? parece, incluindo altura, peso, tra??os faciais, timbre da sua voz, comprimento do cabelo, colora????o e caracter??sticas distintas, se tiverem. Voc?? pode ficar parecido com um membro de outra ra??a, apesar de nenhuma de suas estat??sticas mudar. Voc?? tamb??m n??o pode parecer com uma criatura de um tamanho diferente do seu, e seu formado b??sico permanece o mesmo; se voc?? for b??pede, voc?? n??o pode usar essa magia para se tornar quadrupede, por exemplo. A qualquer momento, pela dura????o da magia, voc?? pode usar sua a????o para mudar sua apar??ncia dessa forma, novamente. Armas Naturais. Voc?? faz crescerem garras, presas, espinhos, chifres ou armas naturais diferentes, ?? sua escolha. Seus ataques desarmados causam 1d6 de dano de concuss??o, perfurante ou cortante, como apropriado para a arma natural que voc?? escolheu, e voc?? ?? proficiente com seus ataques desarmados. Finalmente, a arma natural ?? m??gica e voc?? tem +1 de b??nus nas jogadas de ataque e dano que voc?? fizer com ela. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 9,
                Nome = "Amizade",
                Escola = "Encantamento",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 minuto",
                Componente = "S, M (uma pequena quantidade de maquiagem aplicada ao rosto durante a conjura????o da magia) ",
                Descricao = "Pela dura????o, voc?? ter?? vantagem em todos os testes de Carisma direcionados a uma criatura, ?? sua escolha, que n??o seja hostil a voc??. Quando a magia acabar, a criatura perceber?? que voc?? usou maia para influenciar o humor dela, e ficar?? hostil a voc??. Uma criatura propensa a viol??ncia ir?? atacar voc??. Outra criatura pode buscar outras formas de retalia????o (a crit??rio do Mestre), dependendo da natureza da sua intera????o com ela.",
                IdTipoMagia = 1
            },
            new Magia
            {
                IdMagia = 10,
                Nome = "Amizade Animal",
                Escola = "Encantamento",
                Alcance = "9 metros",
                TempodeConjuracao = "1 a????o",
                Duracao = "24 horas",
                Componente = "V, S, M (um punhado de comida)",
                Descricao = "Essa magia deixa voc?? convencer uma besta que voc?? n??o quer prejudicar. Escolha uma besta que voc?? possa ver dentro do alcance. Ela deve ver e ouvir voc??. Se a Intelig??ncia da besta for 4 ou maior, a magia falha. Do contr??rio, a besta deve ser bem sucedida num teste de resist??ncia de Sabedoria ou ficar?? enfeiti??ada por voc?? pela dura????o da magia. Se voc?? ou um dos seus companheiros ferir o alvo, a magia termina. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de 2?? n??vel ou superior, voc?? pode afetar uma besta adicional para cada n??vel do espa??o acima do 1??. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 11,
                Nome = "Ampliar Plantas",
                Escola = "Transmuta????o",
                Alcance = "45 metros",
                TempodeConjuracao = "1 a????o ou 8 horas",
                Duracao = "Instant??nea",
                Componente = "V, S",
                Descricao = "Essa magia canaliza vitalidade nas plantas dentro de uma ??rea especifica. Existem dois usos poss??veis para essa magia, concedendo ou benef??cios imediatos ou a longo prazo. Se voc?? conjurar essa magia usando 1 a????o, escolha um ponto dentro do alcance. Todas as plantas normais num raio de 30 metros centrado no ponto, tornam-se espessas e carregadas. Uma criatura se movendo na ??rea deve gastar 6 metros de movimento para cada 1,5 metro que se mover. Voc?? pode excluir uma ou mais ??reas de qualquer tamanho, dentro da ??rea da magia, para n??o ser afetada. Se voc?? conjurar essa magia ao longo de 8 horas, voc?? fertiliza a terra. Todas as plantas num raio de 800 metros, centrado no ponto dentro do alcance, ficam enriquecidas por 1 ano. As plantas fornecer??o o dobro da quantidade normal de comida quando colhidas. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 12,
                Nome = "??ncora Planar",
                Escola = "Abjura????o",
                Alcance = "18 metros",
                TempodeConjuracao = "1 hora",
                Duracao = "24 horas",
                Componente = "V, S, M (uma joia valendo, no m??nimo, 1.000 po, consumida pela magia)",
                Descricao = "Com essa magia, voc?? tenta obrigar um celestial, corruptor, elemental ou fada a servi-lo. A criatura deve estar dentro do alcance durante toda a conjura????o da magia. (Tipicamente, a criatura, primeiramente, ?? invocada dentro de um c??rculo m??gico invertido para mant??-la presa enquanto a magia ?? conjurada.) Ao completar a conjura????o, o alvo deve realizar um teste de resist??ncia de Carisma. Se falhar na resist??ncia, ela ?? obrigada a servir voc?? pela dura????o. Se a criatura foi invocada ou criada por outra magia, a dura????o da magia ?? estendida para se equiparar a dessa magia. Uma criatura obrigada deve seguir suas instru????es da melhor forma que puder. Voc?? poderia comandar a criatura a acompanhar voc?? em uma aventura, a guardar um local ou a enviar uma mensagem. A criatura obedece ao p?? da letra suas instru????es, mas se a criatura for hostil a voc??, ela se esfor??ar?? para distorcer suas palavras para atingir seus pr??prios objetivos. Se a criatura atender suas instru????es completamente antes da magia acabar, ela viajar?? at?? voc?? para relatar esse fato se voc?? estiver no mesmo plano de exist??ncia. Se voc?? estiver em um plano de exist??ncia diferente, ela retornar?? para o lugar onde voc?? a contatou e permanecer?? l?? at?? a magia acabar. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de n??vel superior, a dura????o aumenta para 10 dias com um espa??o de 6?? n??vel, para 30 dias com um espa??o de 7?? n??vel, para 180 dias com um espa??o de 8?? n??vel e para um ano com um espa??o de magia de 9?? n??vel. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 13,
                Nome = "Andar na ??gua",
                Escola = "Transmuta????o",
                Alcance = "9 metros",
                TempodeConjuracao = "1 a????o",
                Duracao = "1 hora",
                Componente = "V, S, M (uma rolha)",
                Descricao = "Essa magia concede a habilidade de se mover atrav??s de qualquer superf??cie l??quida ??? como ??gua, ??cido, lama, neve, arreia movedi??a ou lava ??? como se ela fosse ch??o s??lido inofensivo (as criaturas atravessando lava derretida ainda podem sofrer dano do calor). At?? dez criaturas volunt??rias que voc?? possa ver, dentro do alcance, ganham essa habilidade pela dura????o. Se voc?? afetar uma criatura submersa em um l??quido, a magia ergue o alvo para a superf??cie do l??quido a uma taxa de 18 metros por rodada. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 14,
                Nome = "Animar Mortos",
                Escola = "Necromancia",
                Alcance = "3 metros",
                TempodeConjuracao = "1 minuto",
                Duracao = "Instant??nea",
                Componente = " V, S, M (uma gota de sangue, um peda??o de carne e um punhado de p?? de osso)",
                Descricao = "Essa magia cria um servo morto-vivo. Escolha uma pilha de ossos ou um corpo de um humanoide M??dio ou Pequeno dentro do alcance. Sua magia imbui o alvo com uma imita????o corrompida de vida, erguendo-o como uma criatura morta-viva. O alvo se torna um esqueleto, se voc?? escolheu ossos, ou um zumbi, se voc?? escolheu um corpo (o Mestre tem as estat??sticas de jogo da criatura). Em cada um dos seus turnos, voc?? pode usar uma a????o b??nus para comandar mentalmente qualquer criatura que voc?? criou com essa magia, se a criatura estiver a at?? 18 metros de voc?? (se voc?? controla diversas criaturas, voc?? pode comandar qualquer uma ou todas elas ao mesmo tempo, emitindo o mesmo comando para cada uma). Voc?? decide qual a????o a criatura ir?? fazer e para onde ela ir?? se mover durante o pr??ximo turno dela, ou voc?? pode emitir um comando geral, como para guardar uma c??mara ou corredor especifico. Se voc?? n??o der nenhum comando, as criaturas apenas se defender??o contra criaturas hostis. Uma vez que receba uma ordem, a criatura continuar?? a segui-la at?? a tarefa estar conclu??da. A criatura fica sob seu controle por 24 horas, depois disso ela para de obedecer aos seus comandos. Para 218 manter o controle da criatura por mais 24 horas, voc?? deve conjurar essa magia na criatura novamente, antes das 24 horas atuais terminarem. Esse uso da magia recupera seu controle sobre at?? quatro criaturas que voc?? tenha animado com essa magia, ao inv??s de animar uma nova. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de 4?? n??vel ou superior, voc?? pode animar ou recuperar o controle de duas criaturas mortas-vivas para cada n??vel do espa??o acima do 3??. Cada uma dessas criaturas deve vir de um corpo ou pilha de ossos diferente. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 15,
                Nome = "Animar Objetos",
                Escola = "Transmuta????o",
                Alcance = "36 metros",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 minuto",
                Componente = "V, S",
                Descricao = "Objetos ganham vida ao seu comando. Escolha at?? dez objetos n??o-m??gicos dentro do alcance, que n??o estejam sendo vestidos ou carregados. Alvos M??dios contam como dois objetos, alvos Grandes contam como quatro objetos e alvos Enormes contam como oito objetos. Voc?? n??o pode animar um objeto maior que Enorme. Cada alvo se anima e torna-se uma criatura sob seu controle at?? o final da magia ou at?? ser reduzido a 0 pontos de vida. Com uma a????o b??nus, voc?? pode comandar mentalmente qualquer criatura que voc?? criar com essa magia se a criatura estiver a at?? 150 metros de voc?? (se voc?? controla v??rias criaturas, voc?? pode comandar qualquer ou todas elas ao mesmo tempo, emitindo o mesmo comando para cada uma). Voc?? decide qual a????o a criatura ir?? fazer e para onde ela ir?? se mover durante o pr??ximo turno dela, ou voc?? pode emitir um comando geral, como para guardar uma c??mara ou corredor especifico. Se voc?? n??o der nenhum comando, as criaturas apenas se defender??o contra criaturas hostis. Uma vez que receba uma ordem, a criatura continuar?? a segui-la at?? a tarefa estar conclu??da. Um objeto animado ?? um constructo com CA, pontos de vida, ataques, For??a e Destreza determinados pelo seu tamanho. Sua Constitui????o ?? 10 e sua Intelig??ncia e Sabedoria s??o 3 e seu Carisma ?? 1. Seu deslocamento ?? 9 metros; se o objeto n??o tiver pernas ou outros ap??ndices que ele possa usar para locomo????o, ao inv??s, ele ter?? deslocamento de voo 9 metros e poder?? planar. Se o objeto estiver firmemente preso a uma superf??cie ou objeto maior, como uma corrente presa a uma parede, seu deslocamento ser?? 0. Ele tem percep????o ??s cegas num raio de 9 metros e ?? cego al??m dessa dist??ncia. Quando o objeto animado cair a 0 pontos de vida, ele reverte a sua forma normal de objeto e qualquer dano restante ?? transferido para sua forma de objeto original. Se voc?? ordenar a um objeto que ataque, ele pode realizar um ??nico ataque corpo-a-corpo contra uma criatura a at?? 1,5 metro dele. Ele realiza um ataque de pancada com um b??nus de ataque e dano de concuss??o determinado pelo seu tamanho. O Mestre pode definir que um objeto especifico inflige dano cortante ou perfurante, baseado na forma dele. Em N??veis Superiores. Se voc?? conjurar essa magia usando um espa??o de magia de 6?? n??vel ou superior, voc?? pode animar dois objetos adicionais para cada n??vel do espa??o acima do 5??. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 16,
                Nome = "Antipatia/Simpatia",
                Escola = "Encantamento",
                Alcance = "18 metros",
                TempodeConjuracao = "1 hora",
                Duracao = "10 dias",
                Componente = "Componentes: V, S, M (ou um peda??o de alume embebido em vinagre para o efeito de antipatia, ou uma gota de mel para o efeito de simpatia) ",
                Descricao = "Essa magia atrai ou repele as criaturas de sua escolha. Voc?? escolhe um alvo dentro do alcance, tanto um objeto ou criatura Enorme ou menor ou uma ??rea que n??o seja maior que 60 metros c??bicos. Ent??o, especifica um tipo de criatura inteligente, como drag??es vermelhos, goblins ou vampiros. Voc?? envolve o alvo com uma aura que pode atrair ou repelir as criaturas especificas pela dura????o. Escolha antipatia ou simpatia como efeito da aura. Antipatia. O encantamento faz com que criaturas do tipo designado por voc?? sintam-se fortemente impelidos em deixar a ??rea e evitar o alvo. Quando uma dessas criaturas puder ver o alvo ou ficar a 18 metros dele, a criatura deve ser bem sucedida num teste de resist??ncia de Sabedoria ou ficar?? amedrontada. A criatura continuar?? amedrontada enquanto puder ver o alvo ou permanecer a 18 metros dele. Enquanto estiver amedrontada pelo alvo, a criatura deve usar seu deslocamento para se mover para o local seguro mais pr??ximo o qual ela n??o possa ver o alvo. Se a criatura se mover para mais de 18 metros do alvo e n??o puder v??-lo, a criatura n??o estar?? mais amedrontada, mas ela ficar?? amedrontada novamente se voltar a ver o alvo ou ficar a 18 metros dele. Simpatia. O encantamento faz com que as criaturas especificadas sintam-se fortemente impelidos a se aproximar do alvo enquanto estiverem a 18 metros dele ou puderem v??-lo. Quando uma dessas criaturas puder ver o alvo ou ficar a 18 metros dele, a criatura deve ser bem sucedida num teste de resist??ncia de Vontade ou usar?? seu deslocamento em cada um dos seus turnos para entrar na ??rea ou se mover at?? o alcance do alvo. Quando a criatura tiver feito isso, ela n??o poder?? se afastar do alvo voluntariamente. Se o alvo causar dano ou ferir a criatura afetada de alguma forma, a criatura afetada pode realizar um novo teste de resist??ncia de Sabedoria para terminar o efeito, como descrito abaixo. Terminando o Efeito. Se uma criatura afetada terminar se turno enquanto n??o estiver a at?? 18 metros do alvo ou n??o for capaz de v??-lo, a  criatura faz um teste de resist??ncia de Sabedoria. Em um sucesso, a criatura n??o estar?? mais afetada pelo alvo e  econhecer?? o sentimento de repugn??ncia ou atra????o como m??gico. Al??m disso, uma criatura afetada pela magia tem direito a outro teste de resist??ncia de Sabedoria a cada 24 horas enquanto a magia durar. Uma criatura que obtenha sucesso na resist??ncia contra esse efeito ficar?? imune a ele por 1 minuto, depois desse tempo, ela pode ser afetada novamente. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 17,
                Nome = "Aprimorar Habilidade",
                Escola = "Transmuta????o",
                Alcance = "Toque",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 hora",
                Componente = "V, S, M (pelo ou penas de uma besta)",
                Descricao = "Voc?? toca uma criatura e a agracia com aprimoramento m??gico. Escolha um dos efeitos a seguir; o alvo ganha esse efeito at?? o fim da magia. Agilidade do Gato. O alvo tem vantagem em testes de Destreza. Ele tamb??m n??o sofre dano ao cair de 6 metros ou menos, se n??o estiver incapacitado. Esperteza da Raposa. O alvo tem vantagem em testes de Intelig??ncia. Esplendor da ??guia. O alvo tem vantagem em testes de Carisma. For??a do Touro. O alvo tem vantagem em testes de For??a e sua capacidade de carga ?? dobrada. Sabedoria da Coruja. O alvo tem vantagem em testes de Sabedoria. Vigor do Urso. O alvo tem vantagem em testes de Constitui????o. Ele tamb??m recebe 2d6 pontos de vida tempor??rios, que s??o perdidos quando a magia termina. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de 3?? n??vel ou superior, voc?? pode afetar uma criatura adicional para cada n??vel do espa??o acima do 2??. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 18,
                Nome = "Aprisionamento",
                Escola = "Abjura????o",
                Alcance = "9 metros",
                TempodeConjuracao = "1 minuto",
                Duracao = "At?? ser dissipada",
                Componente = "V, S, M (um pergaminho de representa????o ou uma estatueta esculpida para se parecer com o alvo e um componente especial, que varia de acordo com a vers??o da magia que voc?? escolher, valendo, no m??nimo, 500 po por Dado de Vida)",
                Descricao = "Voc?? cria um impedimento m??gico para imobilizar uma criatura que voc?? possa ver, dentro do alcance. O alvo deve ser bem sucedido num teste de resist??ncia de Sabedoria ou ser?? vinculado ?? magia; se ele for bem sucedido, ele ser?? imune a essa magia se voc?? conjura-la novamente. Enquanto estiver sob efeito dessa magia, a criatura n??o precisar?? respirar, comer ou beber e n??o envelhece. Magias de adivinha????o n??o podem localizar ou perceber o alvo. Quando voc?? conjura essa magia, voc?? escolhe uma das seguintes formas de aprisionamento. Enterrar. O alvo ?? sepultado bem fundo na terra em uma esfera de energia m??gica que ?? grande o suficiente para conter o alvo. Nada pode atravessar a esfera e nenhuma criatura pode se teletransportar ou usar viagem plantar para entrar ou sair dela. O componente especial para essa vers??o da magia ?? um pequeno globo de mitral. Acorrentar. Pesadas correntes, firmemente presas ao solo, matem o alvo no lugar. O alvo est?? impedido at?? a magia acabar e ele n??o pode se mover ou ser movido por nenhum meio, at?? l??. O componente especial para essa vers??o da magia ?? uma fina corrente de metal precioso. Pris??o Cercada. A magia transporta o alvo para dentro de um pequeno semiplano que ?? protegido contra teletransporte e viagem planar. O semiplano pode ser um labirinto, uma jaula, uma torre ou qualquer estrutura ou ??rea confinada similar, ?? sua escolha. O componente material especial para essa vers??o da magia ?? uma representa????o em miniatura da pris??o, feita de jade. Conten????o Reduzida. O alvo ?? reduzido at?? o tamanho de 30 cent??metros e ?? aprisionado dentro de uma gema ou objeto similar. A luz pode passar atrav??s da gema normalmente (permitindo que o alvo veja o exterior e outras criaturas vejam o interior), mas nada mais pode atravessa-la, mesmo por meios de teletransporte ou viagem planar. A gema n??o pode ser partida ou quebrada enquanto a magia estiver efetiva. O componente especial para essa vers??o da magia ?? uma gema transparente grande, como um cor??ndon, diamante ou rubi. Torpor. O alvo cai no sono e n??o pode ser acordado. O componente especial para essa vers??o da magia consiste em ervas sopor??feras raras. Terminando a Magia. Durante a conjura????o da magia, em quaisquer das vers??es, voc?? pode especificar uma condi????o que ir?? fazer a magia terminar e libertar?? o alvo. A condi????o pode ser o qu??o especifica ou elaborada quanto voc?? quiser, mas o Mestre deve concordar que a condi????o ?? razo??vel e tem uma probabilidade de acontecer. As condi????es podem ser baseadas no nome, identidade ou divindade da criatura mas, no mais, devem ser baseadas em a????es ou qualidades observ??veis e n??o em valores intang??veis tais como n??vel, classe e pontos de vida. A magia dissipar magia pode terminar a magia apenas se for conjurada como uma magia de 9?? n??vel, tendo como alvo ou a pris??o ou o componente especial usado para cria-la. Voc?? pode usar um componente especial em particular para criar apenas uma pris??o por vez. Se voc?? conjurar essa magia novamente usando o mesmo componente, o alvo da primeira conjura????o ??, imediatamente, liberado do v??nculo.",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 19,
                Nome = "Arca Secreta de Leomund",
                Escola = "Conjura????o",
                Alcance = "Toque",
                TempodeConjuracao = "1 a????o",
                Duracao = "Instant??nea",
                Componente = "V, S, M (um ba?? requintado, de 90 cm por 60 cm por 60 cm, constru??do com materiais raros valendo, no m??nimo, 5.000 po e uma r??plica Mi??da feita do mesmo material valendo, no m??nimo, 50 po)",
                Descricao = "Voc?? esconde um ba??, e todo o seu conte??do, no Plano Et??reo. Voc?? deve tocar o ba?? e a r??plica em miniatura que serve como componente material para a magia. O ba?? pode acomodar at?? 3,6 metros c??bicos de mat??ria inorg??nica (90 cm por 60 cm por 60 cm). Enquanto o ba?? permanecer no Plano Et??reo, voc?? pode usar uma a????o e tocar a r??plica para revocar o ba??. Ele aparece em um espa??o desocupado no ch??o a 1,5 metro de voc??. Voc?? pode enviar o ba?? de volta ao Plano Et??reo usando uma a????o e tocando tanto no ba?? quanto na r??plica. Ap??s 60 dias, existe 5 por cento de chance, cumulativa, por dia do efeito da magia terminar. Esse efeito termina se voc?? conjurar essa magia novamente, se a pequena r??plica do ba?? for destru??da ou se voc?? decidir terminar a magia usando uma a????o. Se a magia terminar enquanto o ba?? maior estiver no Plano Et??reo, ele estar?? irremediavelmente perdido.",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 20,
                Nome = "??rea Escorregadia",
                Escola = "Conjura????o",
                Alcance = "18 metros",
                TempodeConjuracao = "1 a????o",
                Duracao = "1 minuto",
                Componente = "V, S, M (um pouco de pele de porco ou manteiga)",
                Descricao = "Graxa escorregadia cobre o solo em um quadrado de 3 metros centrado em um ponto, dentro do alcance, tornando essa ??rea em terreno dif??cil pela dura????o. Quando a graxa aparece, cada criatura de p?? na ??rea deve ser bem sucedida num teste de resist??ncia de Destreza ou cair?? no ch??o. Uma criatura que entre na ??rea ou termine seu turno nela, deve ser bem sucedido num teste de resist??ncia de Destreza ou cair?? no ch??o.",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 21,
                Nome = "Arma Elemental",
                Escola = "Transmuta????o",
                Alcance = "Toque",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 hora",
                Componente = "Verbal, Som??tico",
                Descricao = "Uma arma n??o-m??gica que voc?? tocar se torna uma arma m??gica. Escolha um dos tipos de dano a seguir: ??cido, el??trico, frio, fogo ou trovejante. Pela dura????o, a arma tem +1 de b??nus nas jogadas de ataque e causa 1d4 de dano extra, do tipo de elemento escolhido, ao atingir. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de 5?? ou 6?? n??vel, o b??nus nas jogadas de ataque aumenta pra +2 e o dano extra aumenta para 2d4. Quando voc?? usar um espa??o de magia de 7?? n??vel ou superior, o b??nus aumenta para +3 e o dano extra aumenta para 3d4.",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 22,
                Nome = "Arma Espiritual",
                Escola = "Evoca????o",
                Alcance = "18 metros",
                TempodeConjuracao = "1 a????o b??nus",
                Duracao = "1 minuto",
                Componente = "Verbal, Som??tico",
                Descricao = "Voc?? cria uma arma espectral flutuante, dentro do alcance, que permanece pela dura????o ou at?? voc?? conjurar essa magia novamente. Quando voc?? conjura essa magia, voc?? pode realizar um ataque corpo-a-corpo com magia contra uma criatura a 1,5 metro da arma. Se atingir, o alvo sofre dano de energia igual a 1d8 + seu modificador de habilidade de conjura????o. Com uma a????o b??nus, no seu turno, voc?? pode mover a arma at?? 6 metros e repetir o ataque contra uma criatura a 1,5 metro dela. A arma pode ter a forma que voc?? desejar. Cl??rigos de divindades associadas com uma arma em particular (como St. Cuthbert ?? conhecido por sua ma??a ou Thor por seu martelo) fazem o efeito dessa magia se assemelhar a essa arma. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de 4?? n??vel ou superior, o dano aumenta em 1d8 para cada dois n??veis do espa??o acima do 2??.",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 23,
                Nome = "Arma M??gica",
                Escola = "Transmuta????o",
                Alcance = "Toque",
                TempodeConjuracao = "1 a????o b??nus",
                Duracao = "Concentra????o, at?? 1 hora",
                Componente = "Verbal, Som??tico",
                Descricao = "Voc?? toca uma arma n??o-m??gica. At?? a magia acabar, a arma se torna uma arma m??gica com +1 de b??nus nas jogadas de ataque e jogadas de dano. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de 4?? n??vel ou superior, o b??nus aumenta para +2. Quando voc?? usar um espa??o de magia de 6?? n??vel ou superior, o b??nus aumenta para +3. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 24,
                Nome = "Armadura Arcana",
                Escola = "Abjura????o",
                Alcance = "Toque",
                TempodeConjuracao = "1 a????o",
                Duracao = "8 horas",
                Componente = "Verbal, Som??tico, Material (um peda??o de couro curado)",
                Descricao = "Voc?? toca uma criatura volunt??ria que n??o esteja vestindo armadura e uma energia m??gica protetora a envolve at?? a magia acabar. A CA base do alvo se torna 13 + o modificador de Destreza dele. A magia acaba se o alvo colocar uma armadura ou se voc?? dissipa-la usando uma a????o. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 25,
                Nome = "Armadura de Agathys",
                Escola = "Abjura????o",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 a????o",
                Duracao = "1 hora",
                Componente = "Verbal, Som??tico, Material (um copo de ??gua)",
                Descricao = "Uma for??a magica protetora envolve voc??, manifestandose como um frio espectral que cobre voc?? e seu equipamento. Voc?? ganha 5 pontos de vida tempor??rios pela dura????o. Se uma criatura atingir voc?? com um ataque corpo-a-corpo enquanto estiver com esses pontos de vida, a criatura sofrer?? 5 de dano de frio. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de 2?? n??vel ou superior, tanto os pontos de vida tempor??rios quanto o dano de frio aumentam em 5 para cada n??vel do espa??o acima do 1??. ",
                IdTipoMagia = 2
            },
            //26
            new Magia
            {
                IdMagia = 26,
                Nome = "Arrombar",
                Escola = "Transmuta????o",
                Alcance = "18 metros",
                TempodeConjuracao = "1 a????o",
                Duracao = "Instant??nea",
                Componente = "Verbal",
                Descricao = "Escolha um objeto que voc?? possa ver, dentro do alcance. O objeto pode ser uma porta, uma caixa, um ba?? ou um par de algemas, um cadeado ou outro objeto que contenha um meio mundano ou m??gico que previne o acesso. Um alvo que esteja fechado por uma fechadura mundana ou preso ou barrado torna-se destrancado, destravado ou desbloqueado. Se o objeto tiver m??ltiplas fechaduras, apenas uma delas ?? destrancada. Se voc?? escolher um alvo que esteja travado pela magia tranca arcana, essa magia ser?? suprimida por 10 minutos, durante esse per??odo o alvo pode ser aberto e fechado normalmente. Quando voc?? conjurar essa magia, uma batida forte, aud??vel a at?? 90 metros de dist??ncia, emana do objeto alvo. ",
                IdTipoMagia = 2
            },
            //27
            new Magia
            {
                IdMagia = 27,
                Nome = "Assassino Fantasmag??rico",
                Escola = "Ilus??o",
                Alcance = "36 metros",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 minuto",
                Componente = "Verbal, Som??tico",
                Descricao = "Voc?? mexe com os pesadelos de uma criatura que voc?? possa ver, dentro do alcance, e cria uma manifesta????o ilus??ria dos seus medos mais profundos, vis??vel apenas para a criatura. O alvo deve realizar um teste de resist??ncia de Sabedoria. Se falhar na resist??ncia, ele ficar?? amedrontado pela dura????o. No final de cada turno do alvo, antes da magia acabar, ele deve ser bem sucedido num teste de resist??ncia de Sabedoria ou sofrer?? 4d10 de dano ps??quico. Se passar na resist??ncia, a magia acaba. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de 5?? n??vel ou superior, o dano aumenta em 1d10 para cada n??vel do espa??o acima do 4??",
                IdTipoMagia = 2
            },
            //28
            new Magia
            {
                IdMagia = 28,
                Nome = "Ataque Certeiro",
                Escola = "Adivinha????o",
                Alcance = "9 metros",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 rodada",
                Componente = "Som??tico",
                Descricao = "Voc?? estende sua m??o e aponta o dedo para um alvo no alcance. Sua magia garante a voc?? uma breve intui????o sobre as defesas do alvo. No seu pr??ximo turno, voc?? ter?? vantagem na primeira jogada de ataque contra o alvo, considerando que essa magia n??o tenha acabado. ",
                IdTipoMagia = 1
            },
            //29
            new Magia
            {
                IdMagia = 29,
                Nome = "Ataque Visual",
                Escola = "Necromancia",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 minuto",
                Componente = "Verbal, Som??tico",
                Descricao = "Pela dura????o da magia, seus olhos tornam-se manchas vazias imbu??das com poder terr??vel. Uma criatura, ?? sua escolha, a at?? de 18 metros de voc?? que voc?? puder ver, deve ser bem sucedida num teste de resist??ncia de Sabedoria ou ser?? afetada por um dos efeitos a seguir, ?? sua escolha, pela dura????o. A cada um dos seus turnos, at?? a magia acabar, voc?? pode usar sua a????o para afetar outra criatura, mas n??o pode afetar uma criatura novamente se ela tiver sido bem sucedida no teste de resist??ncia contra essa conjura????o de ataque visual. Adormecer. O alvo cai inconsciente. Ele acorda se sofrer qualquer dano ou se outra criatura usar sua a????o para sacudir o adormecido at?? acord??-lo. Apavorar. O alvo est?? amedrontado. Em cada um dos turnos dele, a criatura amedrontada deve realizar a a????o de Disparada e se mover para longe de voc?? pela rota segura mais curta dispon??vel, a n??o ser que n??o haja lugar para se mover. Se o alvo se mover para um local a, pelo menos, 18 metros de dist??ncia de voc?? onde ela n??o possa mais te ver, esse efeito termina. Adoecer. O alvo tem desvantagem nas jogadas de ataque e testes de habilidade. No final de cada um dos turnos dele, ele pode realizar outro teste de resist??ncia de Sabedoria. Se for bem sucedido, o efeito termina. ",
                IdTipoMagia = 2
            },
            //30
            new Magia
            {
                IdMagia = 30,
                Nome = "Aug??rio",
                Escola = "Adivinha????o (ritual)",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 minuto",
                Duracao = "Instant??nea",
                Componente = "Verbal, Som??tico, Material (varetas, ossos ou objetos similarmente marcados valendo, no m??nimo, 25 Pe??as de Ouro",
                Descricao = "Ao lan??ar varetas cravejados com gemas, rolar ossos de drag??o, puxar cartas ornamentadas ou usar outro tipo de ferramenta de adivinha????o, voc?? recebe um pressagio de uma entidade de outro mundo, sobre os resultados de cursos de a????o espec??ficos que voc?? planeja tomar nos pr??ximos 30 minutos. O Mestre escolhe dentre os poss??veis press??gios a seguir: ??? ??xito, para resultados bons ??? Fracasso, para resultados maus ??? ??xito e fracasso, para resultados bons e maus ??? Nada, para resultados que n??o s??o especialmente bons ou ruins A magia n??o leva em conta qualquer poss??vel circunstancia que possa mudar o resultado, como a conjura????o de magias adicionais ou a perda ou ganho de um companheiro. Se voc?? conjurar a magia duas ou mais vezes antes de completar seu pr??ximo descanso longo, existe uma chance cumulativa de 25 por cento de cada conjura????o, depois da primeira que voc?? fez, ter um resultado aleat??rio. O Mestre faz essa jogada secretamente. ",
                IdTipoMagia = 2
            },
            //31
            new Magia
            {
                IdMagia = 31,
                Nome = "Aumentar/Reduzir",
                Escola = "Transmuta????o",
                Alcance = "9 metros",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 minuto",
                Componente = "Verbal, Som??tico, Material (um pouco de p?? de ferro",
                Descricao = "Voc?? faz com que uma criatura ou um objeto que voc?? possa ver dentro do alcance, fique maior ou menor, pela dura????o. Escolha entre uma criatura ou um objeto que n??o esteja sendo carregado nem vestido. Se o alvo for involunt??rio, ele deve realizar um teste de resist??ncia de Constitui????o. Se for bem sucedido, a magia n??o surte efeito. Se o alvo for uma criatura, tudo que ele esteja vestindo ou carregando muda e tamanho com ela. Qualquer item largado por uma criatura afetada, retorna ao seu tamanho natural. Aumentar. O tamanho do alvo dobra em todas as dimens??es e seu peso ?? multiplicado por oito. Esse aumento eleva seu tamanho em uma categoria ??? de M??dio para Grande, por exemplo. Se n??o houver espa??o suficiente para que o alvo dobre de tamanho, a criatura ou objeto alcan??a o tamanho m??ximo poss??vel no espa??o dispon??vel. At?? o fim da magia, o alvo tamb??m tem vantagem em testes de For??a e testes de resist??ncia de For??a. O tamanho das armas do alvo crescem para se adequar ao seu novo tamanho. Quando essas armas s??o ampliadas, os ataques do alvo com elas causam 1d4 de dano extra. Reduzir. O tamanho do alvo ?? reduzido ?? metade em todas as dimens??es e seu peso ?? reduzido a um oitavo do normal. Essa redu????o diminui o tamanho do alvo em uma categoria ??? de M??dio para Pequeno, por exemplo. At?? o fim da magia, o alvo tem desvantagem em testes de For??a e testes de resist??ncia de For??a. O tamanho das armas doalvo diminuem para se adequar ao seu novo tamanho. Quando essas armas s??o reduzidas, os ataques do alvo com elas causam 1d4 de dano a menos (isso n??o pode reduzir o dano a menos de 1).",
                IdTipoMagia = 2
            },
            //32
            new Magia
            {
                IdMagia = 32,
                Nome = "Aura de Pureza",
                Escola = "Abjura????o",
                Alcance = "Pessoal (9 metros de raio)",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 10 minutos",
                Componente = "Verbal",
                Descricao = "Energia purificante irradia de voc?? em uma aura com 9 metros de raio. At?? a magia acabar, a aura se move mantendo-se centrada em voc??. Todas as criaturas n??ohostis na aura (incluindo voc??) n??o podem ficar doentes, tem resist??ncia a dano de veneno e tem vantagem em testes de resist??ncia contra efeitos que deixem ela com qualquer das condi????es a seguir: amedrontado, atordoado, cego, enfeiti??ado, envenenado, paralisado e surdo. ",
                IdTipoMagia = 2
            },
            //33
            new Magia
            {
                IdMagia = 33,
                Nome = "Aura de Vida",
                Escola = "Abjura????o",
                Alcance = "Pessoal (9 metros)",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 10 minutos",
                Componente = "Verbal",
                Descricao = "Energia de preven????o vital irradia de voc?? em uma aura com 9 metros de raio. At?? a magia acabar, a aura se move mantendo-se centrada em voc??. Todas as criaturas n??ohostis na aura (incluindo voc??) tem resist??ncia a dano necr??tico e seu m??ximo de pontos de vida n??o pode ser reduzido. Al??m disso, uma criatura viva n??o-hostil, recupera 1 ponto de vida quando come??a seu turno na aura com 0 pontos de vida. ",
                IdTipoMagia = 2
            },
            //34
            new Magia
            {
                IdMagia = 34,
                Nome = "Aura de Vitalidade",
                Escola = "Evoca????o",
                Alcance = "Pessoal (9 metros)",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 minuto",
                Componente = "Verbal",
                Descricao = "Energia de preven????o vital irradia de voc?? em uma aura com 9 metros de raio. At?? a magia acabar, a aura se move mantendo-se centrada em voc??. Todas as criaturas n??ohostis na aura (incluindo voc??) tem resist??ncia a dano necr??tico e seu m??ximo de pontos de vida n??o pode ser reduzido. Al??m disso, uma criatura viva n??o-hostil, recupera 1 ponto de vida quando come??a seu turno na aura com 0 pontos de vida. ",
                IdTipoMagia = 2
            },
            //35
            new Magia
            {
                IdMagia = 35,
                Nome = "Aura M??gica de Nystul",
                Escola = "Ilus??o",
                Alcance = "Toque",
                TempodeConjuracao = "1 a????o",
                Duracao = "24 horas",
                Componente = "Verbal, Som??tico, Material (um pequeno quadrade do seda)",
                Descricao = "Voc?? coloca uma ilus??o em uma criatura ou objeto que voc?? tocar, ent??o magias de adivinha????o revelar??o informa????es falsas sobre ele. O alvo pode ser uma criatura volunt??ria ou um objeto que n??o esteja sendo carregado ou vestido por outra criatura. Quando voc?? conjura essa magia, escolha um ou ambos os efeitos seguintes. O efeito permanece pela dura????o. Se voc?? conjurar essa magia na mesma criatura ou objeto a cada dia por 30 dias, colocando o mesmo efeito nele todas as vezes, a ilus??o durar?? at?? ser dissipada. Aura Falsa. Voc?? modifica a forma como o alvo aparece para magias e efeitos m??gicos, como detectar magia, que detectam auras m??gicas. Voc?? pode fazer um objeto n??o-m??gico parecer m??gico ou mudar a aura m??gica de um objeto para que ela pare??a pertencer a outra escola de magia a sua escolha. Quando voc?? usar esse efeito num objeto, voc?? pode fazer a aura falsa aparente a qualquer criatura que manusear o item. M??scara. Voc?? modifica a forma como o alvo aparece para magias e efeitos que detectam tipos de criaturas, como o Sentido Divino do paladino ou o gatilho de um magia s??mbolo. Voc?? escolhe o tipo de criatura e outras magias e efeitos m??gicos consideram o alvo como se ele fosse uma criatura desse tipo ou tend??ncia.",
                IdTipoMagia = 2
            },
            //36
            new Magia
            {
                IdMagia = 36,
                Nome = "Aura Sagrada",
                Escola = "Abjura????o",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 minuto",
                Componente = "Verbal, Som??tico, Material (um min??sculo relic??rio valendo, no m??nimo, 1000 Pe??as de Ouro, contendo uma rel??quia sagrada, como um peda??o de tecido do robe de um santo ou um peda??o de um pergaminho de um texto religioso",
                Descricao = "Luz divina emana de voc?? e adere em uma aureola suave num raio de 9 metros, em volta de voc??. As criaturas de sua escolha, no raio, quando voc?? conjurar essa magia, emitem penumbra num raio de 1,5 metro e tem vantagem em todos os testes de resist??ncia e as outras criaturas tem desvantagem nas jogadas de ataque contra elas, at?? a magia acabar. Al??m disso, quando um corruptor ou morto-vivo atingir uma criatura afetada com um ataque corpo-a-corpo, a aura lampeja com luz plena. O atacante deve ser bem sucedido num teste de resist??ncia de Constitui????o ou ficara cego at?? a magia acabar. ",
                IdTipoMagia = 2
            },
            //37
            new Magia
            {
                IdMagia = 37,
                Nome = "Aux??lio Divino",
                Escola = "Evoca????o",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 a????o b??nus",
                Duracao = "Concentra????o, at?? 1 minuto",
                Componente = "Verbal, Som??tico",
                Descricao = "Sua ora????o fortalece voc?? com radia????o divina. At?? o fim da magia, seus ataques com arma causam 1d4 de dano radiante extra ao atingirem.",
                IdTipoMagia = 2
            },
            //38
            new Magia
            {
                IdMagia = 38,
                Nome = "Banimento",
                Escola = "Abjura????o",
                Alcance = "9 metros",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 minuto",
                Componente = "Verbal, Som??tico, Material (um item desagrad??vel ao alvo",
                Descricao = "Voc?? tenta enviar uma criatura que voc?? pode ver dentro do alcance, para outro plano de exist??ncia. O alvo deve ser bem sucedido num teste de resist??ncia de Carisma ou ser?? banido. Se o alvo for nativo do plano de exist??ncia que voc?? est??, voc?? bane o alvo para um semiplano inofensivo. Enquanto estiver l??, a criatura estar?? incapacitada. Ela permanece l?? at?? a magia acabar, a partir desse ponto, o alvo reaparece no espa??o em que ela deixou ou no espa??o desocupado mais pr??ximo, se o espa??o dela estive ocupado. Se o alvo for nativo de um plano de exist??ncia diferente do que voc?? est??, o alvo ?? banido em um lampejo sutil, retornando para o seu plano natal. Se a magia acabar antes de 1 minuto se passar, o alvo reaparece no lugar em que estava ou no espa??o desocupado mais pr??ximo, se o espa??o dela estiver ocupado. Do contr??rio, o alvo n??o retorna. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de 5?? n??vel ou superior, voc?? pode afetar uma criatura adicional para cada n??vel do espa??o acima do 4??.",
                IdTipoMagia = 2
            },
            //39
            new Magia
            {
                IdMagia = 39,
                Nome = "Banquete de Her??is",
                Escola = "Conjura????o",
                Alcance = "9 metros",
                TempodeConjuracao = "10 minutos",
                Duracao = "Instant??nea",
                Componente = "Verbal, Som??tico, Material (uma tigela encrustada de gemas valendo, no m??nimo, 1000 Pe??as de Ouro, que ?? consumida pela magia",
                Descricao = "Voc?? traz um grande banquete, incluindo comida e bebida magnificas. O banquete leva 1 hora para ser consumido e desaparece ao final desse tempo e os efeitos ben??ficos n??o se aplicam at?? essa hora terminar. At?? doze criaturas podem participar do banquete. Uma criatura que participe do banquete ganha diversos benef??cios. A criatura ?? curada de todas as doen??as e venenos, torna-se imune a veneno e a ser amedrontada e faz todos os seus testes de resist??ncia de Sabedoria com vantagem. Seu m??ximo de pontos de vida tamb??m aumenta em 2d10 e ela ganha a mesma quantidade de pontos de vida. Esses benef??cios duram por 24 horas. ",
                IdTipoMagia = 2
            },
            //40
            new Magia
            {
                IdMagia = 40,
                Nome = "Barreira de L??minas",
                Escola = "Evoca????o",
                Alcance = "24 metros",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 10 minutos",
                Componente = "Verbal, Som??tico",
                Descricao = "Voc?? cria uma muralha vertical de l??minas girat??rias, afiadas como navalhas, feitas de energia m??gica. A muralha aparece dentro do alcance e permanece pela dura????o. Voc?? pode fazer uma muralha reta de at?? 30 metros de comprimento por 6 metros de altura e 1,5 metro de largura ou uma muralha anelar com at?? 18 metros de di??metro, 6 metros de altura e 1,5 metro de largura. A muralha confere tr??s-quartos de cobertura a criaturas atr??s dela e seu espa??o ?? terreno dif??cil. Quando uma criatura entrar a ??rea da muralha pela primeira vez em um turno, ou come??ar seu turno nela, a criatura deve realizar um teste de resist??ncia de Destreza. Se falhar, a criatura sofrer?? 6d10 de dano cortante. Em um sucesso, a criatura sofre metade desse dano",
                IdTipoMagia = 2
            },
            //41
            new Magia
            {
                IdMagia = 41,
                Nome = "Ben????o",
                Escola = "Encantamento",
                Alcance = "9 metros",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 minuto",
                Componente = "Verbal, Som??tico, Material (um borrifo de ??gua benta)",
                Descricao = "Voc?? aben??oa at?? tr??s criaturas, ?? sua escolha, dentro do alcance. Sempre que um alvo realizar uma jogada de ataque ou teste de resist??ncia antes da magia acabar, o alvo pode jogar um d4 e adicionar o valor jogado ao ataque ou teste de resist??ncia. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de 2?? n??vel ou superior, voc?? pode afetar uma criatura adicional para cada n??vel do espa??o acima do 1??. ",
                IdTipoMagia = 2
            },
            //42
            new Magia
            {
                IdMagia = 42,
                Nome = "Boca Encanta",
                Escola = "Ilus??o (ritual)",
                Alcance = "9 metros",
                TempodeConjuracao = "1 minuto",
                Duracao = "At?? ser dissipada",
                Componente = "Verbal, Som??tico, Material (um peda??o de favo de mel e p?? de jade valendo, no m??nimo, 10 Pe??as de Ouro, consumidos pela magia)",
                Descricao = "Voc?? implanta uma mensagem em um objeto dentro do alcance, uma mensagem que ?? pronunciada quando uma condi????o de ativa????o ?? satisfeita. Escolha um objeto que voc?? possa ver e n??o esteja sendo vestido ou carregado por outra criatura. Ent??o, fale a mensagem, que deve conter 25 palavras ou menos, apesar de ela poder ser entregue durante um per??odo de at?? 10 minutos. Finalmente, determine a circunst??ncia que ir?? ativar a magia para que sua mensagem seja entregue. Quando essa circunst??ncia ocorrer, a boca encantada aparecer?? no objeto e recitar?? a mensagem com sua voz e com o mesmo volume que voc?? falou. Se o objeto que voc?? escolheu tiver uma boca ou algo semelhante a uma boca (por exemplo, a boca de uma est??tua), a boca m??gica aparece ai, ent??o, as palavras parecer??o vir da boca do objeto. Quando voc?? conjura essa magia, voc?? pode fazer a magia acabar depois de enviar sua mensagem ou ela pode permanecer e repetir a mensagem sempre que a circunst??ncia de ativa????o ocorrer. A circunst??ncia de ativa????o pode ser t??o gen??rica ou t??o detalhada quando voc?? quiser, apesar de ela precisar ser baseada em condi????es visuais ou aud??veis que ocorram a at?? 9 metros do objeto. Por exemplo, voc?? pode instruir a boca a falar quando uma criatura se aproximar a menos de 9 metros do objeto ou quando um sino de prata tocar a menos de 9 metros dela",
                IdTipoMagia = 2
            },
            //43
            new Magia
            {
                IdMagia = 43,
                Nome = "Bola de Fogo",
                Escola = "Evoca????o",
                Alcance = "45 metros",
                TempodeConjuracao = "1 a????o",
                Duracao = "Instant??nea",
                Componente = "Verbal, Som??tica, Material (uma min??scula bola de guano de morcego e enxofre)",
                Descricao = "Um veio brilhante lampeja na ponta do seu dedo em dire????o a um ponto que voc?? escolher, dentro do alcance, e ent??o eclode com um estampido baixo, explodindo em chamas. Cada criatura em uma esfera de 6 metros de raio, centrada no ponto, deve realizar um teste de resist??ncia de Destreza. Um alvo sofre 8d6 de dano de fogo se falhar na resist??ncia, ou metade desse dano se obtiver sucesso. O fogo se espalha, dobrando esquinas. Ele incendeia objetos inflam??veis na ??rea que n??o estejam sendo vestidos ou carregados. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de 4?? n??vel ou superior, o dano aumenta em 1d6 para cada n??vel do espa??o acima do 3??. ",
                IdTipoMagia = 2
            },
            //44
            new Magia
            {
                IdMagia = 44,
                Nome = "Bola de Fogo Control??vel",
                Escola = "Evoca????o",
                Alcance = "45 metros",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 minuto",
                Componente = "Verbal, Som??tico, Material (uma min??scula bola de guano de morcego e enxofre)",
                Descricao = "Um feixe de luz amarelada ?? disparado da ponta do seu dedo, ent??o se condensa e aguarda no ponto escolhido, dentro do alcance, como uma conta brilhante, pela dura????o. Quando a magia termina, seja por sua concentra????o ter sido interrompida ou por voc?? ter decidido termina-la, a conta eclode com um estampido baixo, explodindo em chamas que se espalhando, dobrando esquinas. Cada criatura numa esfera, com 6 metros de raio, centrada na conta, deve realizar um teste de resist??ncia de Destreza. Uma criatura sofre dano igual ao total de dano acumulado se falhar na resist??ncia, ou metade do total se obtiver sucesso. 224 O dano base da magia ?? 12d6. Se at?? o final do seu turno, a conta ainda n??o tiver sido detonada, o dano aumenta em 1d6. Se a conta brilhante for tocada antes do intervalo expirar, a criatura que a tocou deve realizar um teste de resist??ncia de Destreza. Se falhar na resist??ncia, a magia termina imediatamente, fazendo a conta explodir em chamas. Se obtiver sucesso na resist??ncia, a criatura pode arremessar a conta a at?? 12 metros. Quando ela atinge uma criatura ou objeto solido, a magia termina e a conta explode. O fogo danifica objetos na ??rea e incendeia objetos inflam??veis que n??o estejam sendo vestidos ou carregados. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de 8?? n??vel ou superior, o dano base aumenta e 1d6 para cada n??vel do espa??o acima do 7??. ",
                IdTipoMagia = 2
            },
            //45
            new Magia
            {
                IdMagia = 45,
                Nome = "Bom Fruto",
                Escola = "Transmuta????o",
                Alcance = "Toque",
                TempodeConjuracao = "1 a????o",
                Duracao = "Instant??nea",
                Componente = "Verbal, Som??tica, Material (um raminho de visco)",
                Descricao = "At?? dez frutos aparecem na sua m??o e s??o infundidos com magia pela dura????o. Uma criatura pode usar sua a????o para comer um fruto. Comer um fruto restaura 1 ponto de vida e um fruto produz nutrientes suficientes para sustentar uma criatura por um dia. Os frutos perdem seu potencial se n??o forem consumidos dentro de 24 horas da conjura????o dessa magia",
                IdTipoMagia = 2
            },
            //46
            new Magia
            {
                IdMagia = 46,
                Nome = "Bord??o M??stico",
                Escola = "Transmuta????o",
                Alcance = "Toque",
                TempodeConjuracao = "1 a????o b??nus",
                Duracao = "1 minuto",
                Componente = "Verbal, Som??tico, Material (visco, uma folha de trevo e uma clava ou bord??o)",
                Descricao = "A madeira de uma clava ou bord??o, que voc?? esteja segurando, ?? imbu??da com o poder da natureza. Pela dura????o, voc?? pode usar sua habilidade de conjura????o ao inv??s da sua For??a para as jogadas de ataque e dano corpo-a-corpo usando essa arma, e o dado de dano da arma se torna um d8. A arma tamb??m se torna m??gica, se ela j?? n??o for. A magia acaba se voc?? conjura-la novamente ou se voc?? soltar a arma.",
                IdTipoMagia = 1
            },
            //47
            new Magia
            {
                IdMagia = 47,
                Nome = "Bra??os de Hadar",
                Escola = "Conjura????o",
                Alcance = "Pessoal (3 metros de raio)",
                TempodeConjuracao = "1 a????o",
                Duracao = "Instant??nea",
                Componente = "Verbal, Som??tica",
                Descricao = "Voc?? invoca o poder de Hadar, o Faminto Sombrio. Tent??culos de energia negra brotam de voc?? e golpeiam todas as criaturas a at?? 3 metros de voc??. Cada criatura na ??rea deve realizar um teste de resist??ncia de For??a. Se falhar, o alvo sofre 2d6 de dano necr??tico e n??o pode fazer rea????es at?? o pr??ximo turno dela. Em um sucesso, uma criatura sofre metade do dano e n??o sofre qualquer outro efeito. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de 2?? n??vel ou superior, o dano aumenta em 1d6 para cada n??vel do espa??o acima do 1??.",
                IdTipoMagia = 2
            },
            //48
            new Magia
            {
                IdMagia = 48,
                Nome = "Bruxaria",
                Escola = "Encantamento",
                Alcance = "18 metros",
                TempodeConjuracao = "1 a????o b??nus",
                Duracao = "Concentra????o, at?? 1 hora",
                Componente = "Verbal, Som??tico, Material (o olho petrificado de um trit??o)",
                Descricao = "Voc?? coloca uma maldi????o em uma criatura que voc?? possa ver, dentro do alcance. At?? a magia acabar, voc?? causa 1d6 de dano necr??tico extra no alvo sempre que atingi-lo com um ataque. Al??m disso, escolha uma habilidade quando voc?? conjurar a magia. O alvo tem desvantagem em testes de habilidade feitos com a habilidade escolhida. Se o alvo cair a 0 pontos de vida antes da magia acabar, voc?? pode usar uma a????o b??nus, em um turno subsequente, para amaldi??oar outra criatura. Uma magia remover maldi????o conjurada no alvo acaba com a magia prematuramente. Em N??veis Superiores. Quando voc?? conjurar essa magia usando um espa??o de magia de 3?? ou 4?? n??vel, voc?? poder?? manter sua concentra????o na magia por at?? 8 horas. Quando voc?? usar um espa??o de magia de 5?? n??vel ou superior, voc?? poder?? manter sua concentra????o na magia por at?? 24 horas.",
                IdTipoMagia = 2
            },
            //49
            new Magia
            {
                IdMagia = 49,
                Nome = "Caminhar em ??rvores",
                Escola = "Conjura????o",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 a????o",
                Duracao = "Concentra????o, at?? 1 minuto",
                Componente = "Verbal, Som??tico",
                Descricao = "Voc?? adquire a habilidade de entrar em uma ??rvore e se mover de dentro dela para dentro de outra ??rvore de mesmo tipo ?? at?? 150 metros. Ambas as ??rvores devem estar vivas e ter, pelo menos, o mesmo tamanho que voc??. Voc?? deve usar 1,5 metro de deslocamento para entrar numa ??rvore. Voc??, instantaneamente, sabe a localiza????o de todas as outras ??rvores de mesmo tipo ?? 150 metros e, como parte do movimento usado para entrar na ??rvore, pode tanto passar por uma dessas ??rvores quanto sair da ??rvore em que voc?? est??. Voc?? aparece no espa??o que voc?? quiser a 1,5 metro da ??rvore destino, usando outro movimento de 1,5 metro. Se voc?? n??o tiver movimento restante, voc?? aparece a 1,5 metro da ??rvore que voc?? terminou seu movimento. Voc?? pode usar esse habilidade de transporte uma vez por rodada pela dura????o. Voc?? deve terminar cada turno fora da ??rvore. ",
                IdTipoMagia = 2
            },
            //50
            new Magia
            {
                IdMagia = 50,
                Nome = "Caminhar no Vento",
                Escola = "Transmuta????o",
                Alcance = "9 metros",
                TempodeConjuracao = "1 minuto",
                Duracao = "8 horas",
                Componente = "Verbal, Som??tico, Material (fogo e ??gua benta)",
                Descricao = "Voc?? e at?? dez criaturas volunt??ria que voc?? possa ver, dentro do alcance, assumem uma forma gasosa pela dura????o, parecidas com peda??os de nuvem. Enquanto estiver na forma de nuvem, uma criatura tem deslocamento de voo de 90 metros e tem resist??ncia a dano de concuss??o, cortante e perfurante de ataques n??om??gicos. As ??nicas a????es que uma criatura pode realizar nessa forma s??o a a????o de Disparada ou para reverter a sua forma normal. Reverter leva 1 minuto, per??odo pelo qual a criatura estar?? incapacitada e n??o poder?? se mover. At?? a magia acabar, uma criatura pode reverter para a forma de nuvem, o que tamb??m requer a transforma????o de 1 minuto. Se uma criatura estiver na forma de nuvem e voando quando o efeito acabar, a criatura descer?? a 18 metros por rodada por 1 minuto, at?? aterrissar na solo, o que ?? feito com seguran??a. Se ela n??o puder aterrissar em 1 minuto, a criatura cair?? a dist??ncia restante. ",
                IdTipoMagia = 2
            }
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },
            // //
            // new Magia
            // {
            //     IdMagia = ,
            //     Nome = "",
            //     Escola = "",
            //     Alcance = "",
            //     TempodeConjuracao = "",
            //     Duracao = "",
            //     Componente = "",
            //     Descricao = "",
            //     IdTipoMagia = 
            // },  
        );
        }
        //IdRaca, Nome, Tamanho, Idade, Deslocamento, BonusConstituicao, BonusForca, BonusDestreza, BonusInteligencia, BonusSabedoria, BonusCarisma, IdIdioma
        {
            modelBuilder.Entity<Raca>().HasData(
            new Raca
            {
                IdRaca = 1,
                Nome = "An??o",
                Tamanho = "1.20m ~ 1.50m",
                Idade = 350,
                Deslocamento = 7.5,
                BonusConstituicao = 2,
                BonusForca = null,
                BonusDestreza = null,
                BonusInteligencia = null,
                BonusSabedoria = null,
                BonusCarisma = null,
                IdIdioma = 1
                // ProfArma = {8, 25, 9, 28}
            },
            new Raca
            {
                IdRaca = 2,
                Nome = "Elfo",
                Tamanho = "1.50m ~ 1.80m",
                Idade = 750,
                Deslocamento = 9.0,
                BonusConstituicao = 2,
                BonusForca = null,
                BonusDestreza = null,
                BonusInteligencia = null,
                BonusSabedoria = null,
                BonusCarisma = null,
                IdIdioma = 2
            },
            new Raca
            {
                IdRaca = 3,
                Nome = "Halfling",
                Tamanho = "0.90m",
                Idade = 150,
                Deslocamento = 7.5,
                BonusConstituicao = 2,
                BonusForca = null,
                BonusDestreza = null,
                BonusInteligencia = null,
                BonusSabedoria = null,
                BonusCarisma = null,
                IdIdioma = 7
            },
            new Raca
            {
                IdRaca = 4,
                Nome = "Humano",
                Tamanho = "1.5m ~ 1.8m",
                Idade = 100,
                Deslocamento = 9.0,
                BonusConstituicao = 1,
                BonusForca = null,
                BonusDestreza = null,
                BonusInteligencia = null,
                BonusSabedoria = null,
                BonusCarisma = null,
                IdIdioma = 2
            },
            new Raca
            {
                IdRaca = 5,
                Nome = "Draconato",
                Tamanho = "1.8m",
                Idade = 80,
                Deslocamento = 9.0,
                BonusConstituicao = 2,
                BonusForca = null,
                BonusDestreza = null,
                BonusInteligencia = null,
                BonusSabedoria = null,
                BonusCarisma = 1,
                IdIdioma = 12
            },
            new Raca
            {
                IdRaca = 6,
                Nome = "Gnomo",
                Tamanho = "0.90m ~ 1.20m",
                Idade = 500,
                Deslocamento = 7.5,
                BonusConstituicao = null,
                BonusForca = null,
                BonusDestreza = null,
                BonusInteligencia = null,
                BonusSabedoria = null,
                BonusCarisma = null,
                IdIdioma = 1
            },
            new Raca
            {
                IdRaca = 7,
                Nome = "Meio-Elfo",
                Tamanho = "1.50m ~ 1.80m",
                Idade = 180,
                Deslocamento = 1,
                BonusConstituicao = null,
                BonusForca = null,
                BonusDestreza = null,
                BonusInteligencia = null,
                BonusSabedoria = null,
                BonusCarisma = 2,
                IdIdioma = 3
            },
            new Raca
            {
                IdRaca = 8,
                Nome = "Meio-Orc",
                Tamanho = "1.80m ~ 2.10m",
                Idade = 75,
                Deslocamento = 9,
                BonusConstituicao = 1,
                BonusForca = 2,
                BonusDestreza = null,
                BonusInteligencia = null,
                BonusSabedoria = null,
                BonusCarisma = null,
                IdIdioma = 8
            },
            new Raca
            {
                IdRaca = 9,
                Nome = "Tiefling",
                Tamanho = "1.50m ~ 1.80m",
                Idade = 120,
                Deslocamento = 9,
                BonusConstituicao = null,
                BonusForca = null,
                BonusDestreza = null,
                BonusInteligencia = 1,
                BonusSabedoria = null,
                BonusCarisma = 2,
                IdIdioma = 2
            }
        );
        }
        //IdSubRaca, Nome, BonusConstituicao, BonusForca, BonusDestreza, BonusInteligencia, BonusSabedoria, BonusCarisma, IdRaca
        {
            modelBuilder.Entity<SubRaca>().HasData(
            new SubRaca
            {
                IdSubRaca = 1,
                Nome = "An??o da Colina",
                BonusConstituicao = null,
                BonusForca = null,
                BonusDestreza = null,
                BonusInteligencia = null,
                BonusSabedoria = 1,
                BonusCarisma = null,
                IdRaca = 1
            },
            new SubRaca
            {
                IdSubRaca = 2,
                Nome = "An??o da Montanha",
                BonusConstituicao = null,
                BonusForca = 2,
                BonusDestreza = null,
                BonusInteligencia = null,
                BonusSabedoria = null,
                BonusCarisma = null,
                IdRaca = 1,
                // ProfArmadura = {1, 2, 3, 4, 5, 6, 7, 8}
            },
            new SubRaca
            {
                IdSubRaca = 3,
                Nome = "Alto Elfo",
                BonusConstituicao = null,
                BonusForca = null,
                BonusDestreza = null,
                BonusInteligencia = 1,
                BonusSabedoria = null,
                BonusCarisma = null,
                IdRaca = 2,
                // ProfArma = {18, 20, 11, 32}
            },
            new SubRaca
            {
                IdSubRaca = 4,
                Nome = "Elfo da Floresta",
                BonusConstituicao = null,
                BonusForca = null,
                BonusDestreza = null,
                BonusInteligencia = null,
                BonusSabedoria = 1,
                BonusCarisma = null,
                IdRaca = 2,
                // ProfArma = {18, 20, 11, 32}
            },
            new SubRaca
            {
                IdSubRaca = 5,
                Nome = "Elfo Negro (Drow)",
                BonusConstituicao = null,
                BonusForca = null,
                BonusDestreza = null,
                BonusInteligencia = null,
                BonusSabedoria = null,
                BonusCarisma = null,
                IdRaca = 2,
                // ProfArma = {30, 18, 33}
            },
            new SubRaca
            {
                IdSubRaca = 6,
                Nome = "P??s Leves",
                BonusConstituicao = null,
                BonusForca = null,
                BonusDestreza = null,
                BonusInteligencia = null,
                BonusSabedoria = null,
                BonusCarisma = 1,
                IdRaca = 3
            },
            new SubRaca
            {
                IdSubRaca = 7,
                Nome = "Robusto",
                BonusConstituicao = 1,
                BonusForca = null,
                BonusDestreza = null,
                BonusInteligencia = null,
                BonusSabedoria = null,
                BonusCarisma = null,
                IdRaca = 3
            },
            new SubRaca
            {
                IdSubRaca = 8,
                Nome = "Gnomo da Floresta",
                BonusConstituicao = null,
                BonusForca = null,
                BonusDestreza = 1,
                BonusInteligencia = null,
                BonusSabedoria = null,
                BonusCarisma = null,
                IdRaca = 6
            },
            new SubRaca
            {
                IdSubRaca = 9,
                Nome = "Gnomo das Rochas",
                BonusConstituicao = 1,
                BonusForca = null,
                BonusDestreza = null,
                BonusInteligencia = null,
                BonusSabedoria = null,
                BonusCarisma = null,
                IdRaca = 6
            }
            );
        }
        //IdVeiculoTerrestre, Nome, Preco, Deslocamento, CapacidadedeCarga
        {
            modelBuilder.Entity<VeiculoTerrestre>().HasData(
            //1, Burro ou mula, 8PO, 12m, 210Kg
            new VeiculoTerrestre{
                IdVeiculoTerrestre = 1,
                Nome = "Burro/mula",
                Preco = "8 Pe??as de Ouro",
                Deslocamento = "12 metros",
                CapacidadedeCarga = "210 Kg"
            },
            //2, Camelo
            new VeiculoTerrestre{
                IdVeiculoTerrestre = 2,
                Nome = "Camelo",
                Preco = "50 Pe??as de Ouro",
                Deslocamento = "15 metros",
                CapacidadedeCarga = "240 Kg"
            },
            //3, Cavalo de Guerra
            new VeiculoTerrestre{
                IdVeiculoTerrestre = 3,
                Nome = "Cavalo de guerra",
                Preco = "400 Pe??as de Ouro",
                Deslocamento = "18 metros",
                CapacidadedeCarga = "270 Kg"
            },
            //4, Cavalo de montaria
            new VeiculoTerrestre{
                IdVeiculoTerrestre = 4,
                Nome = "Cavalo de montaria",
                Preco = "75 Pe??as de Ouro",
                Deslocamento = "18 metros",
                CapacidadedeCarga = "220 Kg"
            },
            //5, Cavalo Pesado
            new VeiculoTerrestre{
                IdVeiculoTerrestre = 5,
                Nome = "Cavalo Pesado",
                Preco = "50 Pe??as de Ouro",
                Deslocamento = "12 metros",
                CapacidadedeCarga = "270 Kg"
            },
            //6, Elefante
            new VeiculoTerrestre{
                IdVeiculoTerrestre = 6,
                Nome = "Elefante",
                Preco = "200 Pe??as de Ouro",
                Deslocamento = "12 metros",
                CapacidadedeCarga = "660 Kg"
            },
            //7, Mastim
            new VeiculoTerrestre{
                IdVeiculoTerrestre = 7,
                Nome = "Mastim",
                Preco = "25 Pe??as de Ouro",
                Deslocamento = "12 metros",
                CapacidadedeCarga = "100 Kg"
            },
            //8, P??nei
            new VeiculoTerrestre{
                IdVeiculoTerrestre = 8,
                Nome = "P??nei",
                Preco = "30 Pe??as de Ouro",
                Deslocamento = "12 metros",
                CapacidadedeCarga = "115 Kg"
            }
            );
        }
        //IdVeiculoAquatico, Nome, Preco, Velocidade
        {
            modelBuilder.Entity<VeiculoAquatico>().HasData
            (
                //1, Barco de quilha
                new VeiculoAquatico{
                    IdVeiculoAquatico = 1,
                    Nome = "Barco de quilha",
                    Preco = "3000 Pe??as de Ouro",
                    Velocidade = "1.5 km/h"
                },
                //2, Barco a remo
                new VeiculoAquatico{
                    IdVeiculoAquatico = 2,
                    Nome = "Barco a remo",
                    Preco = "50 Pe??as de Ouro",
                    Velocidade = "2 km/h"
                },
                //3, Dracar
                new VeiculoAquatico{
                    IdVeiculoAquatico = 3,
                    Nome = "Dracar",
                    Preco = "10000 Pe??as de Ouro",
                    Velocidade = "5 km/h"
                },
                //4, Galera
                new VeiculoAquatico{
                    IdVeiculoAquatico = 4,
                    Nome = "Galera",
                    Preco = "30000 Pe??as de Ouro",
                    Velocidade = "6.5 km/h"
                },
                //5, Navio de guerra
                new VeiculoAquatico{
                    IdVeiculoAquatico = 5,
                    Nome = "Navio de guerra",
                    Preco = "25000 Pe??as de Ouro",
                    Velocidade = "4 km/h"
                },
                //6, Veleiro
                new VeiculoAquatico{
                    IdVeiculoAquatico = 6,
                    Nome = "Veleiro",
                    Preco = "10000 Pe??as de Ouro",
                    Velocidade = "3 km/h"
                }
            );
        }
        //IdASVTracao, Nome, Preco, Peso
        {
            modelBuilder.Entity<ASVTracao>().HasData(
                //1, Alforje
                new ASVTracao{
                    IdASVTracao = 1,
                    Nome = "Alforje",
                    Preco = "4 Pe??as de Ouro",
                    Peso = "4 Kg"
                },
                //2, Armadura e montaria
                new ASVTracao{
                    IdASVTracao = 2,
                    Nome = "Armadura e montaria",
                    Preco = "X4",
                    Peso = "X2"
                },
                //3, Biga
                new ASVTracao{
                    IdASVTracao = 3,
                    Nome = "Biga",
                    Preco = "250 Pe??as de Ouro",
                    Peso = "50 Kg"
                },
                //4, Carro??a
                new ASVTracao{
                    IdASVTracao = 4,
                    Nome = "Carro??a",
                    Preco = "15 Pe??as de Ouro",
                    Peso = "100 Kg"
                },
                //5, Carruagem
                new ASVTracao{
                    IdASVTracao = 5,
                    Nome = "Carruagem",
                    Preco = "100 Pe??as",
                    Peso = "300 Kg"
                },
                //6, Est??bulo
                new ASVTracao{
                    IdASVTracao = 6,
                    Nome = "Est??bulo",
                    Preco = "5 Pe??as de Prata",
                    Peso = "-"
                },
                //7, Freio e r??dea
                new ASVTracao{
                    IdASVTracao = 7,
                    Nome = "Freio e r??dea",
                    Preco = "2 Pe??as de Ouro",
                    Peso = "0.5 Kg"
                },
                //8, Ra????o (1 dia)
                new ASVTracao{
                    IdASVTracao = 8,
                    Nome = "Ra????o",
                    Preco = "5 Kg",
                    Peso = "5 Pe??as de Cobre"
                },
                //9, Sela Compacta
                new ASVTracao{
                    IdASVTracao = 9,
                    Nome = "Sela Compacta",
                    Preco = "5 Pe??as de Ouro",
                    Peso = "7.5 Kg"
                },
                //10, Sela Ex??tica
                new ASVTracao{
                    IdASVTracao = 10,
                    Nome = "Sela Ex??tica",
                    Preco = "60 Pe??as de Ouro",
                    Peso = "20 Kg"
                },
                //11, Sela Militar
                new ASVTracao{
                    IdASVTracao = 11,
                    Nome = "Sela Militar",
                    Preco = "20 Pe??as de Ouro",
                    Peso = "15 Kg"
                },
                //12, Sela p/ Viagem
                new ASVTracao{
                    IdASVTracao = 12,
                    Nome = "Sela p/ Viagem",
                    Preco = "10 Pe??as de Ouro",
                    Peso = "12.5 Kg"
                },
                //13, Tren??
                new ASVTracao{
                    IdASVTracao = 13,
                    Nome = "Tren??",
                    Preco = "20 Pe??as de Ouro",
                    Peso = "150 Kg"
                }
            );
        }

            modelBuilder.Entity<HabilidadeRacial_Raca>().HasKey(nameof(HabilidadeRacial_Raca.IdHabilidadeRacial), nameof(HabilidadeRacial_Raca.IdRaca));

        //IdHabilidadeRacial, IdRaca
        {
                modelBuilder.Entity<HabilidadeRacial_Raca>().HasData(
                //1, 1
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 1,
                    IdRaca = 1
                },
                //2, 1
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 2,
                    IdRaca = 1
                },
                //3, 1
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 3,
                    IdRaca = 1
                },
                //4, 1
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 4,
                    IdRaca = 1
                },
                //5, 1
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 5,
                    IdRaca = 1
                },
                //1, 2
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 1,
                    IdRaca = 2
                },
                //8, 2
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 8,
                    IdRaca = 2
                },
                //9, 2
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 9,
                    IdRaca = 2,
                },
                //10, 2
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 10,
                    IdRaca = 2
                },
                //21, 3
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 21,
                    IdRaca = 3
                },
                //22, 3
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 22,
                    IdRaca = 3
                },
                //23, 3
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 23,
                    IdRaca = 3
                },
                //26, 5
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 26,
                    IdRaca = 5
                },
                //27, 5
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 27,
                    IdRaca = 5
                },
                //28, 5
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 28,
                    IdRaca = 5
                },
                //1, 6
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 1,
                    IdRaca = 6
                },
                //29, 6
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 29,
                    IdRaca = 6
                },
                //1, 7
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 1,
                    IdRaca = 7
                },
                //9, 7
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 9,
                    IdRaca = 7
                },
                //34, 7
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 34,
                    IdRaca = 7
                },
                //1, 8
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 1,
                    IdRaca = 8
                },
                //35, 8
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 35,
                    IdRaca = 8
                },
                //36, 8
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 36,
                    IdRaca = 8
                },
                //37, 8
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 37,
                    IdRaca = 8
                },
                //38, 9
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 38,
                    IdRaca = 9
                },
                //39, 9
                new HabilidadeRacial_Raca
                {
                    IdHabilidadeRacial = 39,
                    IdRaca = 9
                }
            );
         }
            
        //IdHabilidadeRacial, IdSubRaca
        {
            modelBuilder.Entity<HabilidadeRacial_SubRaca>().HasKey(nameof(HabilidadeRacial_SubRaca.IdHabilidadeRacial), nameof(HabilidadeRacial_SubRaca.IdSubRaca));

            //IdHabilidadeRacial, IdSubRaca
            modelBuilder.Entity<HabilidadeRacial_SubRaca>().HasData(
                //6, 1
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 6,
                    IdSubRaca = 1
                },
                //7, 2
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 7,
                    IdSubRaca = 2
                },
                //12, 3
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 12,
                    IdSubRaca = 3,
                },
                //13, 3
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 13,
                    IdSubRaca = 3
                },
                //14, 3
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 14,
                    IdSubRaca = 3
                },
                //12, 4
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 12,
                    IdSubRaca = 4
                },
                //15, 4
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 15,
                    IdSubRaca = 4
                },
                //16, 4
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 16,
                    IdSubRaca = 4
                },
                //17, 5
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 17,
                    IdSubRaca = 5
                },
                //18, 5
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 18,
                    IdSubRaca = 5
                },
                //19, 5
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 19,
                    IdSubRaca = 5
                },
                //20, 5
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 20,
                    IdSubRaca = 5
                },
                //24, 6
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 24,
                    IdSubRaca = 6
                },
                //25, 7
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 25,
                    IdSubRaca = 7
                },
                //30, 8
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 30,
                    IdSubRaca = 8
                },
                //31, 8
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 31,
                    IdSubRaca = 8
                },
                //32, 9
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 32,
                    IdSubRaca = 9
                },
                //33, 9
                new HabilidadeRacial_SubRaca
                {
                    IdHabilidadeRacial = 33,
                    IdSubRaca = 9
                }
            );
        }
        //IdArquetipo, IdTracodeClasse
        {
            modelBuilder.Entity<TracodeClasse_Arquetipo>().HasKey(nameof(TracodeClasse_Arquetipo.IdTracodeClasse), nameof(TracodeClasse_Arquetipo.IdArquetipo));

            //IdTracodeClasse, IdArquetipo
            modelBuilder.Entity<TracodeClasse_Arquetipo>().HasData(
                //5, 1
                new TracodeClasse_Arquetipo
                {
                    IdTracodeClasse = 5,
                    IdArquetipo = 1
                },
                //5, 2
                new TracodeClasse_Arquetipo
                {
                    IdTracodeClasse = 5,
                    IdArquetipo = 2
                }
            );
        }

        //IdClasse, IdTracodeClasse
        {
            modelBuilder.Entity<Classe_TracodeClasse>().HasKey(nameof(Classe_TracodeClasse.IdClasse), nameof(Classe_TracodeClasse.IdTracodeClasse));

            //IdClasse, IdTracodeClasse, Nivel
            modelBuilder.Entity<Classe_TracodeClasse>().HasData(
            //1, 1, 1
            new Classe_TracodeClasse
            {
                IdClasse = 1,
                IdTracodeClasse = 1,
                Nivel = 1
            },
            //1, 2, 1
            new Classe_TracodeClasse
            {
                IdClasse = 1,
                IdTracodeClasse = 2,
                Nivel = 1
            },
            //1, 3, 2
            new Classe_TracodeClasse
            {
                IdClasse = 1,
                IdTracodeClasse = 3,
                Nivel = 2
            },
            //1, 4, 2
            new Classe_TracodeClasse
            {
                IdClasse = 1,
                IdTracodeClasse = 4,
                Nivel = 2
            },
            //1, 5, 3
            new Classe_TracodeClasse
            {
                IdClasse = 1,
                IdTracodeClasse = 5,
                Nivel = 3
            },
            //1, 6, 4
            new Classe_TracodeClasse
            {
                IdClasse = 1,
                IdTracodeClasse = 6,
                Nivel = 4
            },
            //1, 7, 5
            new Classe_TracodeClasse
            {
                IdClasse = 1,
                IdTracodeClasse = 7,
                Nivel = 5
            },
            //1, 8, 5
            new Classe_TracodeClasse
            {
                IdClasse = 1,
                IdTracodeClasse = 8,
                Nivel = 5
            },
            //1, 9, 7
            new Classe_TracodeClasse
            {
                IdClasse = 1,
                IdTracodeClasse = 9,
                Nivel = 7
            },
            //1, 10, 9
            new Classe_TracodeClasse
            {
                IdClasse = 1,
                IdTracodeClasse = 10,
                Nivel = 9
            },
            //1, 11, 11
            new Classe_TracodeClasse
            {
                IdClasse = 1,
                IdTracodeClasse = 11,
                Nivel = 11
            },
            //1, 12, 15
            new Classe_TracodeClasse
            {
                IdClasse = 1,
                IdTracodeClasse = 12,
                Nivel = 15
            },
            //1, 13, 18
            new Classe_TracodeClasse
            {
                IdClasse = 1,
                IdTracodeClasse = 13,
                Nivel = 18
            },
            //1, 14, 20
            new Classe_TracodeClasse
            {
                IdClasse = 1,
                IdTracodeClasse = 14,
                Nivel = 20
            }
        );
        }
        
        modelBuilder.Entity<Personagem_Arma>().HasKey(nameof(Personagem_Arma.IdPersonagem), nameof(Personagem_Arma.IdArma));
        modelBuilder.Entity<Personagem_Armadura>().HasKey(nameof(Personagem_Armadura.IdPersonagem), nameof(Personagem_Armadura.IdArmadura));
        modelBuilder.Entity<Personagem_Item>().HasKey(nameof(Personagem_Item.IdPersonagem), nameof(Personagem_Item.IdItem));
        modelBuilder.Entity<Proficiencia_Arma>().HasKey(nameof(Proficiencia_Arma.IdPersonagem), nameof(Proficiencia_Arma.IdArma));
        modelBuilder.Entity<Proficiencia_Armadura>().HasKey(nameof(Proficiencia_Armadura.IdPersonagem), nameof(Proficiencia_Armadura.IdArmadura));
        modelBuilder.Entity<Proficiencia_Item>().HasKey(nameof(Proficiencia_Item.IdPersonagem), nameof(Proficiencia_Item.IdItem));

        modelBuilder.Entity<Proficiencia_ASVTracao>().HasKey(nameof(Proficiencia_ASVTracao.IdPersonagem), nameof(Proficiencia_ASVTracao.IdASVTracao)); modelBuilder.Entity<Proficiencia_VeiculoTerrestre>().HasKey(nameof(Proficiencia_VeiculoTerrestre.IdPersonagem), nameof(Proficiencia_VeiculoTerrestre.IdVeiculoTerrestre)); modelBuilder.Entity<Proficiencia_VeiculoAquatico>().HasKey(nameof(Proficiencia_VeiculoAquatico.IdPersonagem), nameof(Proficiencia_VeiculoAquatico.IdVeiculoAquatico));

        modelBuilder.Entity<Personagem_ASVTracao>().HasKey(nameof(Personagem_ASVTracao.IdPersonagem), nameof(Personagem_ASVTracao.IdASVTracao)); modelBuilder.Entity<Personagem_VeiculoTerrestre>().HasKey(nameof(Personagem_VeiculoTerrestre.IdPersonagem), nameof(Personagem_VeiculoTerrestre.IdVeiculoTerrestre)); modelBuilder.Entity<Personagem_VeiculoAquatico>().HasKey(nameof(Personagem_VeiculoAquatico.IdPersonagem), nameof(Personagem_VeiculoAquatico.IdVeiculoAquatico));

    }
}