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
           //1, Acólito, -, -, -, -, -, -, 2, -
           new Antecedente
           {
               IdAntecedente = 1,
               Nome = "Acólito",
               Traco = "1 Eu idolatro um herói particular da minha fé, e constantemente me refiro a seus feitos e exemplos. \n2 Eu consigo encontrar semelhanças mesmo entre os inimigos mais violentos, com empatia e sempre trabalhando pela paz. \n3 Eu vejo presságios em cada evento e ação. Os deuses estão falando conosco, nós apenas temos de ouvi-los. \n4 Nada pode abalar minha atitude otimista. \n5 Eu cito (corretamente ou não) textos sagrados e provérbios em quase qualquer situação. \n6 Eu sou tolerante (ou intolerante) a qualquer outra fé, e respeito (ou condeno) a adoração a outros deuses. \n7 Eu aprecio comida requintada, bebidas e a elite entre o alto escalão de meu templo. Uma vida dura me irrita. \n8 Eu passei tanto tempo no templo que possuo pouca prática em lidar com as pessoas mundo a fora.",
               Ideal = "1 Tradição. As tradições ancestrais de adoração e sacrifício devem ser preservadas e perpetradas. (Leal) \n2 Caridade. Eu sempre tento ajudar aqueles em necessidade, não importando o custo pessoal. (Bom) \n3 Mudança. Nós devemos ajudar a conduzir as mudanças que os deuses estão constantemente trabalhando para o mundo. (Caótico) \n4 Poder. Eu espero que um dia eu consiga chegar ao topo na hierarquia da minha religião. (Leal) \n5 Fé. Eu acredito que minha divindade guia minhas ações. Eu tenho fé que, se eu trabalhar duro, coisas boas acontecerão. (Leal) \n6 Aspiração. Eu busco ser digno da graça do meu deus ao corresponder minhas ações aos seus ensinamentos. (Qualquer)",
               Vinculo = "1 Eu morreria para recuperar uma relíquia ancestral de minha fé, perdida há muito tempo. \n2 Eu ainda terei minha vingança contra o templo corrupto que me acusou de heresia. \n3 Eu devo minha vida ao sacerdote que me acolheu quando meus pais morreram. \n4 Tudo o que faço, faço pelo povo. \n5 Eu farei qualquer coisa para proteger o templo que sirvo. \n6 Eu busco guardar um texto sagrado que meus inimigos dizem ser herético e tentam destruí-lo.",
               Defeito = "1 Eu julgo os outros severamente, e a mim mesmo mais ainda. \n2 Eu deposito muita confiança naqueles que detêm o poder na hierarquia de meu templo. \n3 Minha devoção é muitas vezes me cega perante aqueles que professam a fé do meu deus. \n4 Meu pensamento é inflexível. \n5 Eu suspeito de estranhos e sempre espero o pior deles. \n6 Depois de escolher um objetivo, eu fico obcecado em cumpri-lo, até mesmo em detrimento de qualquer outra coisa em minha vida.",
               Habilidade = "CARACTERÍSTICA: ABRIGO DOS FIÉIS \nComo um acólito, você detém o respeito daqueles que compartilham de sua fé, e você pode realizar cerimônias de sua divindade. Você e seus companheiros de aventura podem até receber cura e caridade de um templo, santuário ou outro posto de sua fé, embora devam fornecer quaisquer componentes materiais necessários para as magias. Aqueles que compartilham de sua religião vão garantir a você (mas apenas você), custeando um estilo de vida modesto. Você também pode possuir laços com um templo específico devotado à sua divindade ou panteão, e fixar residência nele. Pode ser o templo que você está acostumado a servir, se ainda tiver boas relações com ele, ou um templo no qual você encontrou um novo lar. Enquanto frequentar as redondezas desse templo, você pode solicitar os sacerdotes para assisti-lo, desde que essa assistência não seja de alguma forma perigosa e que você sempre esteja em uma boa relação com seu templo.",
               Proficiencia = "Intuição, Religião",
               IdiomaQtd = 2,
               Equipamento = "Um símbolo sagrado (um presente dado quando você entrou no templo), um livro de preces ou uma conta de orações, 5 varetas de incenso, vestimentas, um conjunto de roupas comuns e uma algibeira contendo 15 po",
           },
           //2, Artesão de Guilda, -, -, -, -, -, -, 1, -
           new Antecedente
           {
               IdAntecedente = 2,
               Nome = "Artesão de Guilda",
               Traco = "1 Eu acredito que tudo que valha a pena fazer, vale a pena ser feito direito. Eu não posso evitar – Eu sou perfeccionista. \n2 Eu sou um esnobe que olha de cima a baixo aqueles que não sabem apreciar artes requintadas. \n3 Eu sempre quero aprender como as coisas funcionam e o que deixa as pessoas motivadas. \n4 Eu sou cheio de aforismos espirituosos e tenho um proverbio para cada ocasião.\n5 Eu sou grosso com as pessoas que não tem o mesmo comprometimento que eu com o trabalho duro e honesto. \n6 Eu gosto de falar longamente sobre minha profissão. \n7 Eu não gasto meu dinheiro facilmente e vou barganhar incansavelmente para conseguir o melhor acordo possível. \n8 Eu sou bem conhecido pelo meu trabalho e quero ter certeza que todos o apreciam. Eu sempre fico surpreso quando conheço pessoas que não ouviram falar de mim.",
               Ideal = "1 Comunidade. É dever de todo cidadão civilizado fortalecer os elos da comunidade e a segurança da civilização. (Leal) \n2 Generosidade. Meus talentos me foram dados para que eu pudesse usá-los para beneficiar o mundo. (Bom) \n3 Liberdade. Todos deveriam ser livres para perseguir seus próprios meios de vida. (Caótico) \n4 Ganância. Eu só estou aqui pelo dinheiro. (Mau)\n5 Povo. Eu sou cometido com o povo com quem me importo, não com ideias. (Neutro) \n6 Aspiração. Eu trabalho duro para ser o melhor no meu ofício. (Qualquer)",
               Vinculo = "1 A oficina onde aprendi meu negócio é o local mais importante do mundo pra mim. \n2 Eu criei um trabalho incrível para alguém, mas descobri que ele não era merecedor de recebê-lo. Ainda estou à procura de alguém que seja merecedor. \n3 Eu tenho uma grande dívida para com minha guilda por fazer de mim a pessoa que sou hoje. \n4 Eu busco riqueza para conseguir o amor de alguém.\n5 Um dia eu voltarei para a minha guilda e provarei que sou o maior artesão dentre eles. \n6 Eu irem me vingar das forças malignas que destruíram meu local de negócios e arruinaram meu estilo de vida.",
               Defeito = "1 Eu farei de tudo para pôr minha mãos em algo raro ou inestimável. \n2 Eu rapidamente presumo que alguém está tentando me trapacear. \n3 Ninguém nunca poderá saber que eu, certa vez, roubei dinheiro dos cofres da guilda. \n4 Eu nunca estou satisfeito com o que tenho – eu sempre quero mais.\n5 Eu mataria para adquirir um título de nobreza. \n6 Eu sou terrivelmente invejoso com qualquer um que possa ofuscar meu ofício. Todo lugar que eu vou, estou cercado de rivais. ",
               Habilidade = "CARACTERÍSTICA: ASSOCIADOS DA GUILDA \nComo um membro cativo e respeitado da guilda, você pode contar com certos benefícios que a sociedade garante. Seus camaradas, membros da guilda, irão provêlo com hospedagem e comida, se necessário, e pagarão pelo seu funeral se preciso for. Em algumas cidades e vilas, um salão da guilda oferece um local central para conhecer outros membros de profissão, podendo ser um bom lugar para se conhecer patrões, aliados e empregados em potencial. Guildas, muitas vezes, detêm tremendos poderes políticos. Se você for acusado de um crime, sua guilda irá ampará-lo se uma boa defesa puder ser apresentada para provar sua inocência ou se o crime for justificável. Você pode, também, ter acesso a figuras políticas poderosas através da guilda, se você for um membro bem posicionado. Tais conexões devem exigir doações de dinheiro ou itens mágicos para os cofres da guilda. Você deve pagar cotas de 5 po por mês a guilda. Se você não pagar, você irá contrair uma dívida para permanecer nas boas graças da guilda.",
               Proficiencia = "Intuição, Persuasão. \nUm tipo de ferramenta de artesão",
               IdiomaQtd = 1,
               Equipamento = "Um conjunto de ferramentas de artesão (à sua escolha), uma carta de apresentação da sua guilda, um conjunto de roupas de viajante e uma algibeira com 15 po"
           },
           //3, Artista, -, -, -, -, -, -, 0, -
           new Antecedente
           {
               IdAntecedente = 3,
               Nome = "Artista",
               Traco = "1 Eu conheço uma história relevante de praticamente todas as situações. \n2 Sempre que eu chego em um lugar novo, eu coleto os rumores locais e espalho fofocas. \n3 Eu sou um romântico incorrigível, sempre em busca daquele “alguém especial.” \n4 Ninguém fica com raiva de mim ou perto de mim por muito tempo, já que eu posso acabar com qualquer tipo de tensão. \n5 Eu amo um bom insulto, até os direcionados a mim. \n6 Eu fico sentido se eu não for o centro das atenções. \n7 Eu não vou me contentar com nada menos que a perfeição. \n8 Eu mudo de ânimo ou de pensamento tão rápido quando mudo eu mudo de nota em uma canção.",
               Ideal = "1 Beleza. Quando eu atuo, eu torno o mundo um lugar melhor. (Bom) \n2 Tradição. As histórias, lendas e canções do passado nunca devem ser esquecidas, pois elas nos ensinam quem nós somos. (Leal) \n3 Criatividade. O mundo precisa de novas ideias e ações ousadas. (Caótico) \n4 Ganância. Eu só estou aqui pelo dinheiro e pela fama. (Mau) \n5 Povo. Eu gosto de ver os sorrisos nos rostos das pessoas quando eu atuo. Isso é tudo que importa. (Neutro) \n6 Honestidade. A arte deve refletir a alma; ela deve vir de dentro e revelar quem realmente somos. (Qualquer)",
               Vinculo = "1 Meu instrumento é meu bem mais valioso e ele me lembra de alguém que eu amo. \n2 Alguém roubou meu precioso instrumento e, algum dia, eu vou pegá-lo de volta. \n3 Eu quero ser famoso, custe o que custar. \n4 Eu idolatro um herói dos contos antigos e mensuro meus feitos baseados nessa personalidade. \n5 Eu vou fazer tudo para provar que sou superior eu meu odiado rival. \n6 Eu faria qualquer coisa pelos membros da minha antiga trupe.",
               Defeito = "1 Eu farei de tudo para ganhar fama e renome. \n2 Eu viro um idiota quando vejo um rosto bonito. \n3 Um escândalo me impede de voltar para casa novamente. Esse tipo de problema parece me perseguir por ai. \n4 Eu, certa vez, satirizei um nobre que ainda quer minha cabeça. Foi um erro que eu adoraria repetir. \n5 Eu tenho problemas em esconder meus verdadeiros sentimentos. Minha língua afiada me mete em confusão. \n6 Apesar dos meus melhores esforços, meus amigos não me consideram confiável.",
               Habilidade = "CARACTERÍSTICA: PELA DEMANDA POPULAR \nVocê sempre encontra um lugar para atuar, geralmente em tavernas ou estalagens mas, possivelmente em circos, teatros ou até em cortes nobres. Em tais lugares, você recebe alojamento e comida modesta ou de patrões confortáveis, de graça (dependendo da qualidade do estabelecimento), contanto que você atue a cada noite. Além disso, sua atuação torna você um tipo de figura local. Quando estranhos reconhecerem você em uma cidade em que você já tenha atuado, eles geralmente gostaram de você.",
               Proficiencia = "Acrobacia, Atuação. \nKit de disfarce, um tipo de instrumento musical",
               IdiomaQtd = 0,
               Equipamento = "Um instrumento musical (à sua escolha), um presente de um admirador (carta de amor, mecha de cabelo ou uma bijuteria), um traje e uma algibeira contendo 15 peças de ouro "
           },
           //4, Charlatão, -, -, -, -, -, -, 0, -
           new Antecedente
           {
               IdAntecedente = 4,
               Nome = "Charlatão",
               Traco = "1 Eu me apaixono e desapaixono facilmente, e estou sempre em busca de alguém. \n2 Eu tenho uma piada para cada ocasião, especialmente ocasiões em que o humor é inapropriado. \n3 Bajulação é meu truque predileto para conseguir o que eu quero. \n4 Eu sou um jogador nato que não consegue resistir a se arriscar por uma possível recompensa. \n5 Eu minto sobre quase tudo, mesmo quando não existe qualquer boa razão. \n6 Sarcasmo e insultos são minhas armas prediletas. \n7 Eu tenho vários símbolos sagrados comigo, e invoco a divindade que seja mais útil em cada dado momento. \n8 Eu furto qualquer coisa que eu vejo que possa ter algum valor.",
               Ideal = "1 Independência. Sou um espirito livre – ninguém me diz o que fazer. (Caótico) \n2 Justiça. Eu nunca roubo de pessoas que não podem perder algumas moedas. (Leal) \n3 Caridade. Eu distribuo o dinheiro que adquiro com as pessoas que realmente precisam. (Bom) \n4 Criatividade. Eu nunca faço a mesma trapaça duas vezes. (Caótico) \n5 Amizade. Bens materiais vem e vão. Os laços de amizade duram pra sempre. (Bom) \n6 Aspiração. Eu estou determinado a fazer algo por mim mesmo. (Qualquer)",
               Vinculo = "1 Independência. Sou um espirito livre – ninguém me diz o que fazer. (Caótico) \n2 Justiça. Eu nunca roubo de pessoas que não podem perder algumas moedas. (Leal) \n3 Caridade. Eu distribuo o dinheiro que adquiro com as pessoas que realmente precisam. (Bom) \n4 Criatividade. Eu nunca faço a mesma trapaça duas vezes. (Caótico) \n5 Amizade. Bens materiais vem e vão. Os laços de amizade duram pra sempre. (Bom) \n6 Aspiração. Eu estou determinado a fazer algo por mim mesmo. (Qualquer)",
               Defeito = "1 Não resisto um rostinho bonito. \n2 Estou sempre com dividas. Eu gasto meus lucros ilícitos com luxurias decadentes mais rápido do que os ganho... \n3 Estou convencido que ninguém pode me enganar da forma que eu engano os outros. \n4 Eu sou ganancioso demais pra meu próprio bem. Eu não consigo resistir a me arriscar se tiver dinheiro envolvido. \n5 Eu não resisto a enganar pessoas que são mais poderosas que eu. \n6 Eu odeio admitir e vou me odiar por isso, mas, eu vou correr e salvar minha própria pele se as coisas engrossarem.",
               Habilidade = "CARACTERÍSTICA: IDENTIDADE FALSA \nVocê criou uma segunda identidade que inclui documentos, conhecidos estabelecidos e disfarces que possibilitam que você assuma essa persona. Além disso, você pode forjar documentos, incluindo papeis oficiais e cartas pessoais, contanto que você tenha visto um exemplo desse tipo de documento ou a caligrafia de quem você está tentando copiar.",
               Proficiencia = "Enganação, Prestidigitação,  \nKit de disfarce, kit de falsificação ",
               IdiomaQtd = 0,
               Equipamento = "Um conjunto de roupas finas, um kit de disfarce, ferramentas de trapaça, à sua escolha (dez garrafas tampadas preenchidas com líquidos coloridos, um conjunto de dados viciados, um baralho de cartas marcadas ou um anel de sinete de um duque imaginário), e uma algibeira contendo 15 peças de ouro"
           },
           //5, Criminoso, -, -, -, -, -, -, 0, -
           new Antecedente
           {
               IdAntecedente = 5,
               Nome = "Criminoso",
               Traco = "1 Eu sempre tenho um plano para quando as coisas dão errado. \n2 Eu estou sempre calmo, não importa a situação. Eu nunca levanto minha voz ou deixo minhas emoções me controlarem. \n3 A primeira coisa que faço ao chegar a um novo local é decorar a localização de coisas valiosas – ou onde essas coisas podem estar escondidas. \n4 Eu prefiro fazer um novo amigo a um novo inimigo. \n5 Eu sou incrivelmente receoso em confiar. Aqueles que parecem mais amigáveis geralmente têm mais a esconder. \n6 Eu não presto atenção aos riscos envolvidos em uma situação, nunca me alerte sobre as probabilidades de fracasso. \n7 A melhor maneira de me levar a fazer algo é dizendo que eu não posso fazer. \n8 Eu explodo ao menor insulto.",
               Ideal = "1 Honra. Eu não roubo de irmãos de profissão. (Leal) \n2 Liberdade. Correntes foram feitas para serem partidas, assim como aqueles que as forjaram. (Caótico) \n3 Caridade. Eu roubo dos ricos para dar aos que realmente precisam. (Bom) \n4 Ganância. Eu farei qualquer coisa para me tornar rico. (Mal) \n5 Povo. Eu sou leal aos meus amigos, não a qualquer ideal, e todos sabem que posso viajar até o Estige por aqueles que me importo. (Neutro) \n6 Redenção. Há uma centelha de bondade em todo mundo. (Bom)",
               Vinculo = "1 Eu estou tentando quitar uma dívida que tenho com um generoso benfeitor. \n2 Meus ganhos, honestos ou não, são para sustentar minha família. \n3 Algo importante foi roubado de mim, e eu vou recuperá-lo. \n4 Eu me tornarei o maior ladrão que já existiu. \n5 Eu sou culpado por um terrível crime, espero algum dia poder me redimir. \n6 Alguém que amo morreu por causa de um erro que cometi. Isso nunca acontecerá novamente.",
               Defeito = "1 Quando vejo algo valioso, não consigo pensar em mais nada, além de roubá-lo. \n2 Quando confrontado com uma escolha entre dinheiro e amigo, eu bem que escolho o dinheiro. \n3 Se há um plano, eu vou esquecê-lo. Se eu não esquecê-lo, vou ignorá-lo. \n4 Eu tenho um 'tique' que revela se estou mentindo. \n5 Eu viro as costas e corro quando as coisas começam a ficar ruins. \n6 Um inocente foi preso por um crime que eu cometi. Por mim tudo bem.",
               Habilidade = "CARACTERÍSTICA: CONTATO CRIMINAL \nVocê possui contatos de confiança que agem como seus informantes em uma rede criminosa. Você sabe como se comunicar com eles mesmo em grandes distâncias. Você conhece em especial os mensageiros locais, mestres de caravana corruptos, e marinheiros escusos que podem transmitir seus recados. ",
               Proficiencia = "Enganação, Furtividade, \nUm tipo de kit de jogo, ferramentas de ladrão",
               IdiomaQtd = 0,
               Equipamento = "Um pé de cabra, um conjunto de roupas escuras comuns com capuz e uma algibeira contendo 15 po "
           },
           //6, Eremita, -, -, -, -, -, -, 1, -
           new Antecedente
           {
               IdAntecedente = 6,
               Nome = "Eremita",
               Traco = "1 Eu fiquei tanto tempo isolado que raramente falo, preferindo gestos e grunhidos ocasionais. \n2 Eu sou absurdamente sereno, mesmo em face do desespero. \n3 O líder da minha comunidade tem algo sábio a dizer sobre cada tópico, eu estou ansioso para partilhar dessa sabedoria. \n4 Eu sinto uma empatia tremenda por todos que sofrem. \n5 Eu estou alheio a etiqueta e expectativas sociais. \n6 Eu relaciono tudo que acontece comigo a um grande plano cósmico. \n7 Eu, muitas vezes, me perco em meus pensamentos e contemplação me tornando alheio ao meu redor. \n8 Eu estou trabalhando em uma grande teoria filosófica e adoro partilhar minhas ideias.",
               Ideal = "1 Bem Maior. Meus dons devem ser partilhados com todos, não usados em benefício próprio (Bom) \n2 Lógica. Emoções não podem obscurecer meus sentidos do que é certo e verdade, ou meu pensamento lógico. (Leal) \n3 Pensamento Livre. Questionamentos e curiosidade são os pilares do progresso. (Caótico) \n4 Poder. Isolamento e contemplação são caminhos para poderes místicos e mágicos. (Mau) \n5 Viva e Deixe Viver. Se intrometer nos assuntos dos outros só traz problemas. (Neutro) \n6 Autoconhecimento. Se você conhece a si mesmo, não a mais nada para saber. (Qualquer)",
               Vinculo = "1 Nada é mais importante que os outros membros do eremitério, ordem ou associação. \n2 Eu entrei em reclusão para me esconder daqueles que ainda devem estar me caçando. Algum dia irei confrontálos. \n3 Eu ainda busco o esclarecimento que eu perseguia durante meu isolamento e continuo a me iludir. \n4 Eu entrei em reclusão porque eu amava alguém que eu não podia ter. \n5 Se minha descoberta vir à tona, ela poderá trazer destruição ao mundo. \n6 Meu isolamento me deu grande discernimento sobre um grande mal que apenas eu posso destruir.",
               Defeito = "1 Agora que voltei ao mundo, eu desfruto de seus prazeres um pouco demais. \n2 Eu escondo nas sombras, pensamentos sanguinários que meu isolamento e meditação não conseguiram apagar. \n3 Eu sou dogmático em meus pensamentos e filosofia. \n4 Eu deixo meu desejo de vencer discussões ofuscar amizades e harmonia. \n5 Eu me arrisco muito para descobrir um pouco de conhecimento perdido. \n6 Eu gosto de guardar segredos e não os partilho com ninguém.",
               Habilidade = "CARACTERÍSTICA: DESCOBERTA \nA calma reclusão da seu eremitério prolongado lhe deu acesso a descobertas únicas e poderosas. A natureza exata dessas revelações depende da natureza da sua reclusão. Poderia ser uma grande verdade sobre o cosmos, os deuses, os poderosos seres de outros planos ou as forças da natureza. Poderia ser um local nunca visto por mais ninguém. Você pode ter descoberto um fato que a muito foi esquecido, ou desenterrado uma relíquia do passado que poderia reescrever a história. Poderia ser uma informação que seria prejudicial para as pessoas responsáveis pelo seu exilio, consequentemente, a razão que fez você voltar para a sociedade. Converse com o Mestre para determinar os detalhes da sua descoberta e o impacto na campanha.",
               Proficiencia = "Medicina, Religião,  \nKit de herbalismo",
               IdiomaQtd = 1,
               Equipamento = "Um estojo de pergaminho cheio de notas dos seus estudos e orações, um cobertor de inverno, um conjunto de roupas comuns, um kit de herbalismo e 5 po. "
           },
           //7, Forasteiro, -, -, -, -, -, -, 1, -
           new Antecedente
           {
               IdAntecedente = 7,
               Nome = "Forasteiro",
               Traco = "1 Eu fui guiado por uma sede de viagens que me levou a abandonas meu lar. \n2 Eu cuido dos meus amigos como se eles fossem filhotes recém-nascidos. \n3 Certa vez, eu corri quarenta quilômetros sem parar alertar meu clã da aproximação de uma horda orc. Eu faria de novo se fosse necessário. \n4 Eu tenho uma lição pra cada situação, aprendida observando a natureza. \n5 Eu não vejo lugar para o povo rico e educado. Dinheiro e modos não vão salvá-lo de um urso-coruja faminto. \n6 Estou sempre pegando coisas, distraidamente brincando com elas e, às vezes, quebrando-as. \n7 Eu me sinto muito mais confortável entre animais que entre pessoas. \n8 Eu fui, de fato, criado por lobos.",
               Ideal = "1 Mudança. A vida é como as estações, em constante mudança, e nós devemos mudar com ela. (Caótico) \n2 Bem maior. É responsabilidade de todos trazer a maior felicidade para toda a tribo. (Bom) \n3 Honra. Se eu me desonrar, eu desonrarei todo o meu clã. (Leal) \n4 Força. O mais forte deve governar. (Mau) \n5 Natureza. O mundo natural é mais importante que todas as construções da civilização. (Neutro) \n6 Gloria. Eu devo adquirir gloria em batalha, para mim e para meu clã. (Qualquer)",
               Vinculo = "1 Minha família, clã ou tribo é a coisa mais importante na minha vida, mesmo quando eles estão longe. \n2 Uma ofensa a natureza intocada do meu lar é uma ofensa a mim. \n3 Eu trarei uma fúria terrível aos malfeitores que destruíram minha terra natal. \n4 Eu sou o último da minha tribo e cabe a mim garantir que seus nomes façam parte das lendas. \n5 Eu sofro de visões terríveis de um desastre vindouro, e farei qualquer coisa para impedi-lo. \n6 É meu dever prover filhos para sustentar minha tribo.",
               Defeito = "1 Sou muito apaixonado por cerveja, vinho e outras bebidas. \n2 Não existe lugar para precaução em uma vida vivida ao máximo. \n3 Eu lembro de cada insulto que sofri e nutro um ressentimento silencioso contra qualquer um que já tenha me insultado \n4 Eu tenho dificuldade em confiar em membros de outras raças, tribos ou sociedades. \n5 A violência é minha resposta para quase todos os obstáculos. \n6 Não espere que eu salve aqueles que não conseguem se virar sozinhos. É a lei da natureza que os fortes prosperem e os fracos pereçam.",
               Habilidade = "CARACTERÍSTICA: ANDARILHO Você tem uma memória excelente para mapas e geografia, e você sempre pode recobrar o plano geral de terrenos, assentamentos ou outras características ao seu redor. Além disso, você pode encontrar comida e água fresca para você a até cinco outras pessoas a cada dia, considerando que a terra ofereça bagas, pequenas frutas, água e similares.",
               Proficiencia = "Atletismo, Sobrevivência, \nUm tipo de instrumento musical",
               IdiomaQtd = 1,
               Equipamento = "Um bordão, uma armadilha de caça, um fetiche de um animal que você matou, um conjunto de roupas de viajante e uma algibeira contendo 10 po"
           },
           //8, Herói do Povo, -, -, -, -, -, -, 0, -
           new Antecedente
           {
               IdAntecedente = 8,
               Nome = "Herói do Povo",
               Traco = "1 Eu julgo as pessoas por suas ações, não por suas palavras. \n2 Se alguém está em apuros, eu estou sempre pronto para ajudar. \n3 Quando eu fixo minha mente em algo, eu sigo esse caminho, não importa o que fique no caminho. \n4 Eu possuo um forte senso de justiça e sempre tento encontrar a solução mais equilibrada para as discussões. \n5 Eu confio em minhas habilidades e farei o que for necessário para que os outros confiem também. \n6 Pensar é para os outros, eu prefiro agir. \n7 Eu abuso de palavras longas na tentativa de soar inteligente. \n8 Eu me entedio fácil. Para onde devo ir para me encontrar com meu destino?",
               Ideal = "1 Respeito. As pessoas merecem ser tratadas com dignidade e respeito. (Bom) \n2 Justiça. Ninguém merece tratamento diferenciado perante a lei, muito menos estar acima dela. (Leal) \n3 Liberdade. Não pode haver permissão para tiranos oprimirem o povo. (Caótico) \n4 Força. Se eu ficar forte, eu posso pegar tudo o que eu quiser – o que eu desejar. (Mal) \n5 Sinceridade. Não há nada de bom em fingir ser algo que não sou. (Neutro) \n6 Destino. Nada, nem ninguém, pode me manter longe do meu chamado. (Qualquer)",
               Vinculo = "1 Eu tenho família, embora não faça a mínima ideia de onde eles estão, espero encontrá-los um dia. \n2 Eu trabalho a terra, eu amo a terra e eu vou defender a terra. \n3 Um nobre orgulhoso me deu uma bela surra, e eu vou ter minha vingança em qualquer valentão que encontrar. \n4 Minhas ferramentas são símbolo de minha vida passada, eu as carregarei para nunca me esquecer de minhas origens. \n5 Eu devo proteger aqueles que não podem se defender. \n6 Gostaria que meu amor viesse comigo para seguir meu destino.",
               Defeito = "1 O tirano que comanda minha terra não vai parar até ver meu cadáver. \n2 Eu estou convencido sobre o significado do meu destino, e cego aos riscos e falhas. \n3 As pessoas que me conhecem desde criança sabem de um vergonhoso segredo meu, eu não poderei voltar para casa nunca. \n4 Eu tenho uma fraqueza pelos vícios da cidade, especialmente a bebedeira. \n5 Secretamente, eu acredito que as coisas estariam melhores se algum tirano comandasse a região. \n6 Eu tenho dificuldades em confiar em meus aliados.",
               Habilidade = "CARACTERÍSTICA: HOSPITALIDADE RÚSTICA Já que você ascendeu da categoria de pessoas comuns até onde você está agora, é fácil se misturar a eles. Você pode encontrar lugar entre os camponeses para se esconder, descansar ou se recuperar, a menos que isso ofereça um risco direto a eles. Eles o esconderão da lei e de qualquer um que venha perguntando por você, desde que não tenham que arriscar suas vidas. ",
               Proficiencia = "Adestrar Animais, Sobrevivência, \nUm tipo de ferramenta de artesão, veículos (terrestre)",
               IdiomaQtd = 0,
               Equipamento = " Um conjunto de ferramentas de artesão (à sua escolha), uma pá, um pote de ferro, um conjunto de roupas comuns e uma algibeira contendo 10 po "
           },
           //9, Marinheiro, -, -, -, -, -, -, 0, -
           new Antecedente
           {
               IdAntecedente = 9,
               Nome = "Marinheiro",
               Traco = "1 Meus amigos sabem que podem contar comigo pro que der e vier. \n2 Eu trabalho duro para que possa me divertir muito quando o trabalho estiver pronto. \n3 Eu gosto de navegar para novos portos e fazer novas amizades acompanhado de uma jarra de cerveja. \n4 Eu modifico alguns fatos para o bem de uma boa história. \n5 Pra mim, uma briga de taverna é uma ótima forma de conhecer uma nova cidade. \n6 Eu nunca deixo passar uma aposta amigável. \n7 Meu vocabulário é tão sujo quanto o covil de um otyugh. \n8 Eu gosto de trabalhos bem feitos, especialmente se eu puder convencer alguém a fazê-los.",
               Ideal = "1 Respeito. A coisa que mantem um navio unido é o respeito mútuo entre o capitão e a tripulação. (Bem) \n2 Justiça. Todos nós fazemos o trabalho, portanto, todos partilhamos os espólios. (Leal) \n3 Liberdade. O mar é liberdade – a liberdade de ir aonde quiser. (Caótico) \n4 Domínio. Eu sou um predador e os outros navios no mar são minhas presas. (Mau) \n5 Povo. Eu sou apegado aos meus companheiros de tripulação, não a ideais. (Neutro) \n6 Aspiração. Algum dia eu serei dono do meu próprio navio e traçarei meu próprio destino. (Qualquer)",
               Vinculo = "1 Eu sou leal ao meu capitão, primeiramente, o resto vem em segundo. \n2 O navio é o mais importante – tripulantes e capitães vem e vão. \n3 Eu sempre me lembrarei do meu primeiro navio. \n4 Em uma cidade portuária, eu tenho uma amante que quase me roubou do mar. \n5 Eu fui enganado na divisão dos espólios e eu quero o que me é devido. \n6 Cruéis piratas mataram meu capitão e companheiros de tripulação, saquearam nosso navio e me deixaram para morrer. A vingança será minha.",
               Defeito = "1 Eu sigo ordens, mesmo que eu ache que estão erradas. \n2 Eu direi qualquer coisa para evitar trabalho extra. \n3 Certa vez, alguém duvidou da minha coragem, eu nunca recuo, não importa o quão perigosa seja a situação. \n4 Quando começo a beber, é difícil pra mim parar. \n5 Eu não resisto a uma sacolinha de moedas dando sopa ou outras bugigangas que encontro. \n6 Meu orgulho provavelmente levará a minha destruição.",
               Habilidade = "CARACTERÍSTICA: PASSAGEM DE NAVIO \nQuando você precisar, você pode conseguir passagem de graça em um navio para você e seus companheiros de aventura. Você precisa viajar no navio em que você trabalhou ou em outro navio com o qual você teve boas 139 relações (talvez um comandado por um ex-companheiro de tripulação). Por ser um favor, você não pode solicitar uma programação ou rota que atenda à todas as suas necessidades. Seu Mestre determina quanto tempo levará pra chegar aonde você quer ir. Em troca da passagem grátis, espera-se que você e seus companheiros ajudem a tripulação durante a viagem. ",
               Proficiencia = "Atletismo, Percepção, \nFerramentas de navegador, veículo (aquático)",
               IdiomaQtd = 0,
               Equipamento = "Uma malagueta (clava), 15 metros de corda de seda, uma amuleto da sorte como um pé de coelho ou uma pequena pedra com um furo no centro (ou você pode rolar uma bugiganga da tabela Bugigangas no capítulo 5), um conjunto de trajes comuns e uma algibeira contendo 10 po "
           },
           //10, Nobre, -, -, -, -, -, -, 1, -
           new Antecedente
           {
               IdAntecedente = 10,
               Nome = "Nobre",
               Traco = "1 Minha bajulação eloquente faz com que todos com quem eu converse se sintam a pessoa mais maravilhosa e importante do mundo. \n2 As pessoas comuns me amam por minha bondade e generosidade. \n3 Ninguém pode duvidar, olhando para o meu porte real, que estou acima das massas plebeias. \n4 Eu tenho grande cuidado de sempre estar no meu melhor e seguir as últimas modas. \n5 Eu não gosto de sujar minhas mãos, e eu não vou ser pego em acomodações inadequadas. \n6 Apesar da minha origem nobre, eu não estou acima dos outros. O sangue é um só. \n7 Meu apoio, uma vez perdido, não volta. \n8 Se você me ferir, eu irei esmagá-lo, arruinar seu nome, e salgar seus campos.",
               Ideal = "1 Respeito. O respeito a mim é devido por causa da minha posição, mas todas as pessoas, independentemente da posição merecem ser tratados com dignidade. (Bom) \n2 Responsabilidade. É o meu dever respeitar a autoridade daqueles acima de mim, assim como aqueles abaixo de mim devem me respeitar. (Leal) \n3 Independência. Devo provar que posso me cuidar sem os mimos da minha família. (Caótico) \n4 Poder. Se eu puder alcançar mais poder, ninguém vai me dizer o que fazer. (Mau) \n5 Família. O sangue corre mais grosso que a água. (Qualquer) \n6 Obrigação Nobre. É o meu dever proteger e cuidar das pessoas abaixo de mim. (Bom)",
               Vinculo = "1 Eu vou encarar qualquer desafio para ganhar a aprovação da minha família. \n2 A aliança da minha casa com outra família nobre deve ser mantida a todo custo. \n3 Nada é mais importante do que os outros membros da minha família. \n4 Eu sou apaixonado pela herdeira de uma família que a minha família despreza. \n5 Minha lealdade ao meu soberano é inabalável. \n6 As pessoas comuns devem me ver como um herói do povo.",
               Defeito = "\n1 Eu secretamente acredito que todos estão abaixo de mim. \n2 Eu escondo um segredo verdadeiramente escandaloso que poderia arruinar minha família para sempre. \n3 Muitas vezes eu ouço insultos e ameaças veladas em cada palavra dirigida a mim, e me irrito muito rápido. \n4 Eu tenho um desejo insaciável por prazeres carnais. \n5 Na verdade, o mundo gira ao meu redor. \n6 Pelas minhas palavras e ações, muitas vezes, envergonho minha família.",
               Habilidade = "CARACTERÍSTICA: POSIÇÃO PRIVILEGIADA \nGraças a sua origem nobre, as pessoas tendem a pensar o melhor de você. Você é bem-vindo na alta sociedade e as pessoas assumem que você tem o direito de estar onde está. As pessoas comuns fazem todos os esforços para acomodá-lo e evitar seu desprazer, e outros nobres o tratam como um membro da mesma classe social. Você pode conseguir uma audiência com um nobre local se precisar. ",
               Proficiencia = "História, Persuasão, \nUm tipo de kit de jogos ",
               IdiomaQtd = 1,
               Equipamento = "Um conjunto de trajes finos, um anel de sinete, um pergaminho de linhagem e uma algibeira contendo 25 po"
           },
           //11, Órfão, -, -, -, -, -, -, 0, -
           new Antecedente
           {
               IdAntecedente = 11,
               Nome = "Órfão",
               Traco = "1 Eu escondo pedaços de comida e bugigangas em meus bolsos. \n2 Eu pergunto um monte e coisas. \n3 Eu gosto de me espremer em locais pequenos onde ninguém possa me alcançar. \n4 Eu durmo encostado em um muro ou árvore, abraçado com todas as minhas posses. \n5 Eu como feito um porco e tenho maus modos. \n6 Eu acho que todos que são gentis comigo tem segundas intenções. \n7 Eu não gosto de tomar banho. \n8 Eu digo na cara o que as outras pessoas insinuam ou escondem.",
               Ideal = "1 Respeito. Todas as pessoas, ricas ou pobres, merecem respeito. (Bom) \n2 Comunidade. Nós temos que tomar conta uns dos outros, porque ninguém mais o fará. (Leal) \n3 Mudança. Os baixos se erguerão e os altos irão tombar. A mudança é a natureza das coisas. (Caótico) \n4 Retribuição. Os ricos precisam ver como a vida e morte é nas sarjetas. (Mau) \n5 Povo. Eu ajudo as pessoas que me ajudam – é isso que nos mantem vivos. (Neutro) \n6 Aspiração. Eu vou provar que sou merecedor de uma vida melhor. (Qualquer)",
               Vinculo = "1 Minha cidade ou vila é meu lar, e eu vou lutar para defendêlo. \n2 Eu patrocino um orfanato para que outros não passem pelo que fui forçado a passar. \n3 Eu devo minha sobrevivência a outros órfão que me ensinou a vida nas ruas. \n4 Eu tenho uma dívida que nunca poderei pagar com uma pessoa que teve pena de mim. \n5 Eu sai da minha vida de pobreza roubando uma pessoa importante, eu sou procurado por isso. \n6 Ninguém deveria ter suportar as dificuldades pelas quais passei.",
               Defeito = "1 Se eu estiver em desvantagem, eu vou fugir de uma briga. \n2 Ouro parece ser muito dinheiro pra mim, e eu faria praticamente qualquer coisa por mais dele. \n3 Eu nunca vou confiar em ninguém plenamente, além de mim mesmo. \n4 Eu prefiro matar alguém enquanto dorme que uma luta justa. \n5 Não é roubo se eu preciso mais que outra pessoa. \n6 As pessoas que não podem se virar sozinhas, tem o que merecem.",
               Habilidade = "CARACTERÍSTICA: SEGREDOS DA CIDADE \nVocê conhece os padrões secretos e o fluxo das cidades e pode encontrar passagens através da expansão urbana que os outros deixariam passar. Quando você não estiver em combate, você (e os companheiros que você guiar) podem viajar entre dois locais quaisquer na cidade com o dobro da velocidade normalmente permitida. ",
               Proficiencia = "Furtividade, Prestidigitação, \nKit de disfarce, ferramentas de ladrão ",
               IdiomaQtd = 0,
               Equipamento = "Uma faca pequena, um mapa da cidade em que você cresceu, um rato de estimação, um pequeno objeto para lembrar dos seus pais, um conjunto de roupas comuns e uma algibeira contendo 10 peças de ouro"
           },
           //12, Sábio, -, -, -, -, -, -, 2, -
           new Antecedente
           {
               IdAntecedente = 12,
               Nome = "Sábio",
               Traco = "1 Eu uso palavras polissilábicas para endossar minha impressão de grande erudição. \n2 Eu já li todos os livros das grandes bibliotecas – ou gosto de me vangloriar e dizer que li. \n3 Eu costumo ajudar os outros que não são tão inteligentes quanto eu, e pacientemente explico tudo quantas vezes forem necessárias. \n4 Nada para mim é melhor que um bom mistério. \n5 Eu voluntariamente escuto cada lado, e seus argumentos, antes de tomar uma decisão final. \n6 Eu...falo...lentamente...ao...conversar...com idiotas...que tentam...se comparar...comigo. \n7 E sou horrível e estranho em situações sociais. \n8 Estou convencido de que todos tentam roubar os meus segredos de mim.",
               Ideal = "1 Conhecimento. O caminho para o poder e o auto aperfeiçoamento é através do conhecimento. (Neutro) \n2 Beleza. O que é belo nos mostra o que está além disso perto do que é verdadeiro. (Bom) \n3 Logica. Emoções não devem nublar seu pensamento lógico. (Leal) \n4 Sem Limites. Nada pode apaziguar a possibilidade infinita de toda a existência. (Caótico) \n5 Poder. Conhecimento é o caminho para o poder e a dominação. (Mau) \n6 Auto Aperfeiçoamento. O objetivo de uma vida de estudos é a melhoria de si mesmo. (Qualquer)",
               Vinculo = "1 É meu dever proteger meus estudantes. \n2 Eu guardo um texto ancestral que contém terríveis segredos que não podem cair em mãos erradas. \n3 Eu trabalho para preservar uma biblioteca, universidade, arquivo de escribas ou monastério. \n4 O trabalho a da minha vida é uma série de tomos relatando um campo de conhecimento específico. \n5 Eu venho procurando a minha vida inteira pela resposta de certa questão. \n6 Eu vendi minha alma por conhecimento. Espero realizar grandes feitos para ganhá-la de volta.",
               Defeito = "1 Eu me distraio facilmente com a promessa de informação. \n2 Muitas pessoas gritam e correm quando veem um corruptor. Eu paro e tomo notas de sua anatomia. \n3 Desvendar um mistério ancestral pode muito bem valer o preço e uma civilização. \n4 E prefiro soluções óbvias a complicadas. \n5 Eu falo sem antes pensar em minhas palavras, invariavelmente insultando outros. \n6 Eu não consigo guardar um segredo para salvar minha vida. Ou a vida de qualquer outra pessoa.",
               Habilidade = "CARACTERÍSTICA: PESQUISADOR \nQuando tentar obter ou recuperar um fragmento de conhecimento que você não saiba, você descobre aonde e com quem pode obter essa informação. Normalmente ela será adquirida em bibliotecas, arquivos de escribas, universidade ou outros sábios e pessoas aptas. Seu Mestre pode decidir que o conhecimento que busca está escondido em algum lugar quase inacessível, ou é simplesmente impossível de se obter. Desvendar os 142 segredos mais profundos do multiverso pode requerer uma campanha inteira. ",
               Proficiencia = "Arcanismo, História",
               IdiomaQtd = 2,
               Equipamento = "Um vidro de tinta escura, uma pena, uma faca pequena, uma carta de um falecido colega perguntando a você algo que você nunca terá a chance de responder, um conjunto de roupas comuns e uma algibeira contendo 10 po "
           },
           //13, Soldado, -, -, -, -, -, -, 0, -
           new Antecedente
           {
               IdAntecedente = 13,
               Nome = "Soldado",
               Traco = "1 Eu sou sempre polido e respeitoso. \n2 Eu sou assombrado pelas memórias da guerra. Não consigo tirar aquelas imagens da minha cabeça. \n3 Eu perdi muitos amigos, e sou muito devagar para fazer novos. \n4 Eu tenho muitas histórias de inspiração e cautela da época de minha experiência militar que são relevantes em todas as situações de combate. \n5 Eu não consigo encarar um cão infernal sem vacilar. \n6 Eu gosto de ser forte e de quebrar coisas. \n7 Eu tenho um senso de humor grosseiro. \n8 Eu enfrento os problemas de frente. Uma solução direta é o melhor caminho para o sucesso.",
               Ideal = "1 Bem Maior. Nosso destino é dar nossas vidas em defesa de terceiros. (Bom) \n2 Responsabilidade. Eu faço o que tenho que fazer e obedeço apenas a autoridade. (Leal) \n3 Independência. Quando pessoas seguem ordens cegas elas apoiam um tipo de tirania. (Caótico) \n4 Força. A vida é como uma guerra, o mais forte vence. (Mau) \n5 Viva e Deixa Viver. Ideais não valem a pena se você matar, ou for à guerra por eles. (Neutro) \n6 Aspiração. Minha cidade, nação ou meu povo, são tudo o que importa para mim. (Qualquer)",
               Vinculo = "1 Eu ainda daria a minha vida pelas pessoas com quem servi. \n2 Alguém salvou minha vida no campo de batalha. Desde aquele dia eu nunca deixo nenhum amigo para trás. \n3 Minha honra é minha vida. \n4 Eu nunca esquecerei a destruidora derrota que minha companhia sofreu ou os inimigos que a causaram. \n5 Aqueles que lutam ao meu lado são aqueles por quem vale a pena morrer. \n6 Eu luto por aqueles que não podem lutar por si mesmos.",
               Defeito = "1 O inimigo monstruoso que enfrentei em uma batalha ainda me deixa tremendo de medo. \n2 Eu tenho pouco respeito por aqueles que não se provam bons combatentes. \n3 Eu cometi um terrível erro em batalha, o que custou muitas vidas – eu farei de tudo para manter esse erro em segredo. \n4 Meu ódio por meus inimigos é cego e irracional. \n5 Eu obedeço a lei, mesmo se a lei trouxer a angústia. \n6 Eu prefiro comer minha armadura a admitir que estou errado.",
               Habilidade = "CARACTERÍSTICA: PATENTE MILITAR \nVocê possui uma patente militar da sua época como soldado. Soldados leais à sua antiga organização reconhecem sua autoridade e influência, e o prestam deferência se forem de uma patente mais baixa. Você pode invocar sua patente para exercer influência sobre soldados, e requisitar equipamentos simples ou cavalos para uso temporário. Você também pode ganhar acesso a acampamentos militares aliados, e fortalezas onde usa patente é reconhecida. ",
               Proficiencia = "Atletismo, Intimidação ",
               IdiomaQtd = 0,
               Equipamento = "Uma insígnia de patente, um fetiche obtido de um inimigo caído (uma adaga, lâmina partida ou tira de estandarte), um conjunto de dados de osso ou baralho, um conjunto de roupas comuns e uma algibeira contendo 10 po "
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
            //2, Arma Simples à Distância
            new TipoArma
            {
                IdTipoArma = 2,
                Tipo = "Arma Simples à Distância"
            },
            //3, Arma Marcial Corpo-a-Corpo
            new TipoArma
            {
                IdTipoArma = 3,
                Tipo = "Arma Marcial Corpo-a-Corpo"
            },
            //4, Arma Marcial à Distância
            new TipoArma
            {
                IdTipoArma = 4,
                Tipo = "Arma Marcial à Distância"
            }
            );

            //IdArma, DadoDano, Propriedade, Nome, Peso, Preco, IdTipoArma

            modelBuilder.Entity<Arma>().HasData(
            //1, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 1,
                DadoDano = "1d4 perfurante",
                Propriedade = "Acuidade, leve, arremesso (distância 6/18)",
                Nome = "Adaga",
                Peso = "0.5 Kg",
                Preco = "2 Peças de Ouro",
                IdTipoArma = 1
            },
            //2, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 2,
                DadoDano = "1d6 perfurante",
                Propriedade = "Arremesso (distância 9/36)",
                Nome = "Azagaia",
                Peso = "1 Kg",
                Preco = "5 Peças de Prata",
                IdTipoArma = 1
            },
            //3, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 3,
                DadoDano = "1d6 concussão",
                Propriedade = "Versátil (1d8)",
                Nome = "Bordão",
                Peso = "2 Kg",
                Preco = "2 Peças de Prata",
                IdTipoArma = 1
            },
            //4, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 4,
                DadoDano = "1d8 concussão",
                Propriedade = "Pesada, duas mãos",
                Nome = "Clava Grande",
                Peso = "5 Kg",
                Preco = "2 Peças de Prata",
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
                Preco = "1 Peça de Ouro",
                IdTipoArma = 1
            },
            //6, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 6,
                DadoDano = "1d6 perfurante",
                Propriedade = "Arremesso (distância 6/18), versãtil (1d8)",
                Nome = "Lança",
                Peso = "1.5 Kg",
                Preco = "1 Peça de Ouro",
                IdTipoArma = 1
            },
            //7, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 7,
                DadoDano = "1d6 concussão",
                Propriedade = "",
                Nome = "Maça",
                Peso = "2 Kg",
                Preco = "5 Peças de Ouro",
                IdTipoArma = 1
            },
            //8, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 8,
                DadoDano = "1d6 cortante",
                Propriedade = "Leve, arremesso (distância 6/18)",
                Nome = "Machadinha",
                Peso = "1 Kg",
                Preco = "5 Peças de Ouro",
                IdTipoArma = 1
            },
            //9, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 9,
                DadoDano = "1d4 concussão",
                Propriedade = "Leve, arremesso (distância 6/18)",
                Nome = "Martelo Leve",
                Peso = "1 Kg",
                Preco = "2 Peças de Ouro",
                IdTipoArma = 1
            },
            //10, -, -, -, -, -, 1
            new Arma
            {
                IdArma = 10,
                DadoDano = "1d4 concussão",
                Propriedade = "Leve",
                Nome = "Porrete",
                Peso = "1 Kg",
                Preco = "1 Peça de Prata",
                IdTipoArma = 1
            },
            //11, -, -, -, -, -, 2
            new Arma
            {
                IdArma = 11,
                DadoDano = "1d6 perfurante",
                Propriedade = "Munição (distância 24/96), duas mãos",
                Nome = "Arco Curto",
                Peso = "1 Kg",
                Preco = "25 Peças de Ouro",
                IdTipoArma = 2
            },
            //12, -, -, -, -, -, 2
            new Arma
            {
                IdArma = 12,
                DadoDano = "1d8 perfurante",
                Propriedade = "Munição (distância 24/96), regarga, duas mãos",
                Nome = "Beste Leve",
                Peso = "2.5 Kg",
                Preco = "25 Peças de Ouro",
                IdTipoArma = 2
            },
            //13, -, -, -, -, -, 2
            new Arma
            {
                IdArma = 13,
                DadoDano = "1d4 perfurante",
                Propriedade = "Acuidade, arremesso (distância 6/18)",
                Nome = "Dardo",
                Peso = "0.1 Kg",
                Preco = "5 Peças de Cobre",
                IdTipoArma = 2
            },
            //14, -, -, -, -, -, 2
            new Arma
            {
                IdArma = 14,
                DadoDano = "1d4 concussão",
                Propriedade = "Munição (distância 9/36)",
                Nome = "Funda",
                Peso = "-",
                Preco = "1 Peça de Prata",
                IdTipoArma = 2
            },
            //15, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 15,
                DadoDano = "1d10 cortante",
                Propriedade = "Pesada, alcance, duas mãos",
                Nome = "Alabarda",
                Peso = "3 Kg",
                Preco = "20 Peças de Ouro",
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
                Preco = "25 Peças de Ouro",
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
                Preco = "2 Peças de Ouro",
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
                Preco = "10 Peças de Ouro",
                IdTipoArma = 3
            },
            //19, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 19,
                DadoDano = "2d6 cortante",
                Propriedade = "Pesada, duas mãos",
                Nome = "Espada Grande",
                Peso = "3 Kg",
                Preco = "50 Peças de Ouro",
                IdTipoArma = 3
            },
            //20, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 20,
                DadoDano = "1d8 cortante",
                Propriedade = "Versátil (1d10)",
                Nome = "Espada Longa",
                Peso = "1.5 Kg",
                Preco = "15 Peças de Ouro",
                IdTipoArma = 3
            },
            //21, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 21,
                DadoDano = "1d10 cortante",
                Propriedade = "Pesada, alcance, duas mãos",
                Nome = "Glaive",
                Peso = "3 Kg",
                Preco = "20 Peças de Ouro",
                IdTipoArma = 3
            },
            //22, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 22,
                DadoDano = "1d12 perfurante",
                Propriedade = "Alcance, especial",
                Nome = "Lança de Montaria",
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
                Nome = "Maça Estrela",
                Peso = "2 Kg",
                Preco = "15 Peças de Ouro",
                IdTipoArma = 3
            },
            //24, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 24,
                DadoDano = "1d12 cortante",
                Propriedade = "Pesada, duas mãos",
                Nome = "Machado Grande",
                Peso = "3.5 Kg",
                Preco = "30 Peças de Ouro",
                IdTipoArma = 3
            },
            //25, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 25,
                DadoDano = "1d8 cortante",
                Propriedade = "Versátil (1d10)",
                Nome = "Macado de Batalha",
                Peso = "2 Kg",
                Preco = "10 Peças de Ouro",
                IdTipoArma = 3
            },
            //26, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 26,
                DadoDano = "2d6 concussão",
                Propriedade = "Pesada, duas mãos",
                Nome = "Malho",
                Peso = "5 Kg",
                Preco = "10 Peças de Ouro",
                IdTipoArma = 3
            },
            //27, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 27,
                DadoDano = "1d8 concussão",
                Propriedade = "",
                Nome = "Mangual",
                Peso = "1 Kg",
                Preco = "10 Peças de Ouro",
                IdTipoArma = 3
            },
            //28, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 28,
                DadoDano = "1d8 concussão",
                Propriedade = "Versátil (1d10)",
                Nome = "Martelo de Guerra",
                Peso = "1 Kg",
                Preco = "15 Peças de Ouro",
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
                Preco = "5 Peças de Ouro",
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
                Preco = "25 Peças de Ouro",
                IdTipoArma = 3
            },
            //31, -, -, -, -, -, 3
            new Arma
            {
                IdArma = 31,
                DadoDano = "1d6 perfurante",
                Propriedade = "Arremesso (6/18), versátil(1d8)",
                Nome = "Tridente",
                Peso = "2 Kg",
                Preco = "5 Peças de Ouro",
                IdTipoArma = 3
            },
            //32, -, -, -, -, -, 4
            new Arma
            {
                IdArma = 32,
                DadoDano = "1d8 perfurante",
                Propriedade = "Munição (distância 45/180), pesada, duas mãos",
                Nome = "Arco Longo",
                Peso = "1 Kg",
                Preco = "50 Peças de Ouro",
                IdTipoArma = 4
            },
            //33, -, -, -, -, -, 4
            new Arma
            {
                IdArma = 33,
                DadoDano = "1d6 perfurante",
                Propriedade = "Munição (distância 9/36), leve, recarga",
                Nome = "Besta de Mão",
                Peso = "1.5 Kg",
                Preco = "75 Peças de Ouro",
                IdTipoArma = 4
            },
            //34, -, -, -, -, -, 4
            new Arma
            {
                IdArma = 34,
                DadoDano = "1d10 perfurante",
                Propriedade = "Munição (distância 30/120), pesada, recarga, duas mãos",
                Nome = "Besta Pesada",
                Peso = "4.5 Kg",
                Preco = "50 Peças de Ouro",
                IdTipoArma = 4
            },
            //35, -, -, -, -, -, 4
            new Arma
            {
                IdArma = 35,
                DadoDano = "",
                Propriedade = "Especial, arremesso (distância 1.4/4.5)",
                Nome = "Rede",
                Peso = "1.5 Kg",
                Preco = "1 Peça de Ouro",
                IdTipoArma = 4
            },
            //36, -, -, -, -, -, 4
            new Arma
            {
                IdArma = 36,
                DadoDano = "1 perfurante",
                Propriedade = "Munição (distância 7.5/30), recarga",
                Nome = "Zarabatana",
                Peso = "0.5 Kg",
                Preco = "10 Peças de Ouro",
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
            //2, Armadura Média
            new TipoArmadura
            {
                IdTipoArmadura = 2,
                Tipo = "Armadura Média"
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
                Preco = "5 Peças de Ouro",
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
                Preco = "10 Peças de Ouro",
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
                Preco = "45 Peças de Ouro",
                IdTipoArmadura = 1
            },
            //4, 12, 2, null, false, Gibão de Peles, -, -, 2 
            new Armadura
            {
                IdArmadura = 4,
                ClassedeArmadura = 12,
                ModificadorDestrezaMaximo = 2,
                Forca = null,
                Furtividade = false,
                Nome = "Gibão de Peles",
                Peso = "6 Kg",
                Preco = "10 Peças de Ouro",
                IdTipoArmadura = 2
            },
            //5, 13, 2, null, false, Camisão de Malha, -, -, 2 
            new Armadura
            {
                IdArmadura = 5,
                ClassedeArmadura = 13,
                ModificadorDestrezaMaximo = 2,
                Forca = null,
                Furtividade = false,
                Nome = "Camisão de Malha",
                Peso = "10 Kg",
                Preco = "30 Peças de Ouro",
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
                Preco = "50 Peças de Ouro",
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
                Preco = "400 Peças de Ouro",
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
                Preco = "750 Peças de Ouro",
                IdTipoArmadura = 2
            },
            //9, 14, 0, null, true, Cota de Anéis, -, -, 3
            new Armadura
            {
                IdArmadura = 9,
                ClassedeArmadura = 14,
                ModificadorDestrezaMaximo = 0,
                Forca = null,
                Furtividade = true,
                Nome = "Cota de Anéis",
                Peso = "20 Kg",
                Preco = "30 Peças de Ouro",
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
                Preco = "75 Peças de Ouro",
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
                Preco = "200 Peças de Ouro",
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
                Preco = "1500 Peças de Ouro",
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
                Preco = "10 Peças de Ouro",
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
            //3, Magias de Clérigo
            new ListaMagia
            {
                IdListaMagia = 3,
                Nome = "Magias de Clérigo"
            },
            //4, Magias de Drúida
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
        //IdClasse, DadoVida, Nome, Equipamento, Proficiência, IdListaMagia
        {
            modelBuilder.Entity<Classe>().HasData(
            //1, 12, Bárbaro, -, -, null
            new Classe
            {
                IdClasse = 1,
                DadoVida = 12,
                Nome = "Bárbaro",
                Equipamento = "(a) um machado grande ou (b) qualquer arma marcial corpo-a-corpo  (a) dois machados de mão ou (b) qualquer arma simples  Um pacote de aventureiro e quatro azagaias",
                Proficiencia = "Armaduras: Armaduras leves, armaduras médias e escudos Armas: Armas simples, armas marciais Ferramentas: Nenhuma Testes de Resistência: Força, Constituição Perícias: Escolha duas dentre Adestrar Animais, Atletismo, Intimidação, Natureza, Percepção e Sobrevivência",
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
                Equipamento = "(a) uma rapieira, (b) uma espada longa ou (c) qualquer arma simples  (a) um pacote de diplomata ou (b) um pacote de artista  (a) um lute ou (b) qualquer outro instrumento musical  Armadura de couro e uma adaga",
                Proficiencia = "Armaduras: Armaduras leves Armas: Armas simples, bestas de mão, espadas longas, rapieiras, espadas curtas Ferramentas: Três instrumentos musicais, à sua escolha Testes de Resistência: Destreza, Carisma Perícias: Escolha três quaisquer ",
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
                Equipamento = "(a) uma besta leve e 20 virotes ou (b) qualquer arma simples  (a) uma bolsa de componentes ou (b) um foco arcano  (a) um pacote de estudioso ou (b) um pacote de explorador  Armadura de couro, qualquer arma simples e duas adagas",
                Proficiencia = "Armaduras: Armaduras leves Armas: Armas simples Ferramentas: Nenhuma Testes de Resistência: Sabedoria, Carisma Perícias: Escolha duas dentre Arcanismo, Enganação, História, Intimidação, Investigação, Natureza e Religião ",
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
            //4, 8, Clérigo, -, -, 3
            new Classe
            {
                IdClasse = 4,
                DadoVida = 8,
                Nome = "Clérigo",
                Equipamento = "(a) uma maça ou (b) um martelo de guerra (se for proficiente)  (a) brunea, (b) armadura de couro ou (c) cota de malha (se for proficiente)  (a) um besta leve e 20 virotes ou (b) qualquer arma simples  (a) um pacote de sacerdote ou (b) um pacote de aventureiro  Um escudo e um símbolo sagrado",
                Proficiencia = "Armaduras: Armaduras leves, armaduras médias, escudos Armas: Todas as armas simples Testes de Resistência: Sabedoria, Carisma Perícias: Escolha duas dentre História, Intuição, Medicina, Persuasão e Religião",
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
            //5, 8, Drúida, -, -, 4
            new Classe
            {
                IdClasse = 5,
                DadoVida = 8,
                Nome = "Druida",
                Equipamento = "(a) um escudo de madeira ou (b) qualquer arma simples (a) uma cimitarra ou (b) qualquer arma corpo-a-corpo simples (a) um pacote de estudioso ou (b) um pacote de explorador  Armadura de couro, um pacote de aventureiro e um foco druídico",
                Proficiencia = "(a) uma besta leve e 20 virotes ou (b) qualquer arma simples  (a) uma bolsa de componentes ou (b) um foco arcano  (a) um pacote de explorador ou (b) um pacote de aventureiro",
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
                Equipamento = "(a) uma besta leve e 20 virotes ou (b) qualquer arma simples  (a) uma bolsa de componentes ou (b) um foco arcano  (a) um pacote de explorador ou (b) um pacote de aventureiro",
                Proficiencia = "Armaduras: Nenhuma Armas: Adagas, dardos, fundas, bordões e bestas leves Ferramentas: Nenhuma Testes de Resistência: Constituição, Carisma Perícias: Escolha duas dentre Arcanismo, Enganação, Intuição, Intimidação, Persuasão e Religião",
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
                Equipamento = "(a) cota de malha ou (b) gibão de peles, arco longo e 20 flechas  (a) uma arma marcial e um escudo ou (b) duas armas marciais  (a) uma besta leve e 20 virotes ou (b) dois machados de arremesso  (a) um pacote de aventureiro ou (b) um pacote de explorador",
                Proficiencia = "Armaduras: Todas as armaduras, escudos Armas: Armas simples, armas marciais Ferramentas: nenhum Testes de Resistência: Força, Constituição Perícias: Escolha duas dentre Acrobacia, Adestrar Animais, Atletismo, História, Intuição, Intimidação, Percepção e Sobrevivência ",
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
                Equipamento = "(a) uma rapieira ou (b) uma espada longa  (a) um arco curto e uma aljava com 20 flechas ou (b) uma espada curta  (a) um pacote de assaltante ou (b) um pacote de aventureiro ou (c) um pacote de explorador  Armadura de couro, duas adagas e ferramentas de ladrão",
                Proficiencia = "(a) uma arma marcial e um escudo ou (b) duas armas marciais  (a) cinco azagaias ou (b) qualquer arma simples corpoa-corpo  (a) um pacote de sacerdote ou (b) um pacote de aventureiro  Cota de malha e um símbolo sagrado",
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
                Equipamento = "(a) uma arma marcial e um escudo ou (b) duas armas marciais  (a) cinco azagaias ou (b) qualquer arma simples corpoa-corpo  (a) um pacote de sacerdote ou (b) um pacote de aventureiro  Cota de malha e um símbolo sagrado",
                Proficiencia = "Armaduras: Nenhuma Armas: Adagas, dardos, fundas, bordões, bestas leves Ferramentas: Nenhuma Testes de Resistência: Inteligência, Sabedoria Perícias: Escolha duas dentre Arcanismo, História, Intuição, Investigação, Medicina e Religião",
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
                Equipamento = "(a) uma arma marcial e um escudo ou (b) duas armas marciais  (a) cinco azagaias ou (b) qualquer arma simples corpoa-corpo  (a) um pacote de sacerdote ou (b) um pacote de aventureiro  Cota de malha e um símbolo sagrado",
                Proficiencia = "Armaduras: Todas as armaduras, escudos Armas: Armas simples, armas marciais Ferramentas: Nenhum Testes de Resistência: Sabedoria, Carisma Perícias: Escolha duas dentre Atletismo, Intuição, Intimidação, Medicina, Persuasão e Religião",
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
                Equipamento = "(a) uma arma marcial e um escudo ou (b) duas armas marciais  (a) cinco azagaias ou (b) qualquer arma simples corpoa-corpo  (a) um pacote de sacerdote ou (b) um pacote de aventureiro  Cota de malha e um símbolo sagrado",
                Proficiencia = "Armaduras: Todas as armaduras, escudos Armas: Armas simples, armas marciais Ferramentas: Nenhum Testes de Resistência: Sabedoria, Carisma Perícias: Escolha duas dentre Atletismo, Intuição, Intimidação, Medicina, Persuasão e Religião",
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
                Equipamento = "(a) brunea ou (b) armadura de couro  (a) duas espadas curtas ou (b) duas armas simples corpo-a-corpo  (a) um pacote de explorador ou (b) um pacote de aventureiro  Um arco longo e uma aljava com 20 flechas",
                Proficiencia = "Armaduras: Armaduras leves, armaduras médias, escudos Armas: Armas simples, armas marciais Ferramentas: Nenhuma 117 Testes de Resistência: Força, Destreza Perícias: Escolha três dentre Adestrar Animais, Atletismo, Furtividade, Intuição, Investigação, Natureza, Percepção e Sobrevivência",
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
            //1, Fúria, -
            new TracodeClasse
            {
                IdTracodeClasse = 1,
                Nome = "Fúria",
                HabilidadeTracodeClasse = "Em batalha, você luta com uma ferocidade primitiva. No seu turno, você pode entrar em fúria com uma ação bônus. \nEnquanto estiver em fúria, você recebe os seguintes benefícios se você não estiver vestindo uma armadura pesada: *Você tem vantagem em testes de Força e testes de resistência de Força. *Quando você desferir um ataque com arma corpo-acorpo usando Força, você recebe um bônus nas jogadas de dano que aumenta à medida que você adquire níveis de bárbaro, como mostrado na coluna Dano de Fúria na tabela O Bárbaro. *Você possui resistência contra dano de concussão, cortante e perfurante. Se você for capaz de conjurar magias, você não poderá conjurá-las ou se concentrar nelas enquanto estiver em fúria. Sua fúria dura por 1 minuto. Ela termina prematuramente se você cair inconsciente ou se seu turno acabar e você não tiver atacado nenhuma criatura hostil desde seu último turno ou não tiver sofrido dano nesse período. Você também pode terminar sua fúria no seu turno com uma ação bônus. Quando você tiver usado a quantidade de fúrias mostrada para o seu nível de bárbaro na coluna Fúrias da tabela O Bárbaro, você precisará terminar um descanso longo antes de poder entrar em fúria novamente. "
            },
            //2, Defesa sem Armadura, -
            new TracodeClasse
            {
                IdTracodeClasse = 2,
                Nome = "Defesa sem Armadura",
                HabilidadeTracodeClasse = "Quando você não estiver vestindo qualquer armadura, sua Classe de Armadura será 10 + seu modificador de Destreza + seu modificador de Constituição. Você pode usar um escudo e continuar a receber esse benefício. "
            },
            //3, Ataque Descuidado, -
            new TracodeClasse
            {
                IdTracodeClasse = 3,
                Nome = "Ataque Descuidado",
                HabilidadeTracodeClasse = "A partir do 2° nível, você pode desistir de toda preocupação com sua defesa para atacar com um desespero feroz. Quando você fizer o seu primeiro ataque no turno, você pode decidir atacar descuidadamente. Fazer isso lhe concede vantagem nas jogadas de ataque com armas corpo-a-corpo usando Força durante seu turno, porém, as jogadas de ataques feitas contra você possuem vantagem até o início do seu próximo turno."
            },
            //4, Sentido do Perigo, -
            new TracodeClasse
            {
                IdTracodeClasse = 4,
                Nome = "Sentido de Perigo",
                HabilidadeTracodeClasse = "No 2° nível, você adquire um sentido sobrenatural de quando as coisas próximas não estão como deveriam, concedendo a você uma chance maior quando estiver evitando perigos. Você possui vantagem em testes de resistência de Destreza contra efeitos que você possa ver, como armadilhas e magias. Para receber esse benefício você não pode estar cego, surdo ou incapacitado. "
            },
            //5, Caminho Primitivo, -
            new TracodeClasse
            {
                IdTracodeClasse = 5,
                Nome = "Caminho Primitivo",
                HabilidadeTracodeClasse = "No 3° nível, você escolhe um caminho que molda a natureza da sua fúria. Escolha o Caminho do Furioso ou o Caminho do Guerreiro Totêmico, ambos detalhados no final da descrição de classe. Sua escolha lhe concederá características no 3° nível e novamente no 6°, 10° e 14° níveis. "
            },
            //6, Incremento no Valor de Habilidade, -
            new TracodeClasse
            {
                IdTracodeClasse = 6,
                Nome = "Incremento no Valor de Habilidade",
                HabilidadeTracodeClasse = "Quando você atinge o 4° nível e novamente no 8°, 12°, 16° e 19° nível, você pode aumentar um valor de habilidade, à sua escolha, em 2 ou você pode aumentar dois valores de habilidade, à sua escolha em 1. Como padrão, você não pode elevar um valor de habilidade acima de 20 com essa característica."
            },
            //7, Ataque Extra, -
            new TracodeClasse
            {
                IdTracodeClasse = 7,
                Nome = "Ataque Extra",
                HabilidadeTracodeClasse = "A partir do 5° nível, você pode atacar duas vezes, ao invés de uma, sempre que você realizar a ação de Ataque no seu turno. "
            },
            //8, Movimento Rápido, -
            new TracodeClasse
            {
                IdTracodeClasse = 8,
                Nome = "Movimento Rápido",
                HabilidadeTracodeClasse = "Começando no 5° nível, seu deslocamento aumenta em 3 metros enquanto você não estiver vestindo uma armadura pesada."
            },
            //9, Instinto Selvagem
            new TracodeClasse
            {
                IdTracodeClasse = 9,
                Nome = "Instinto Selvagem",
                HabilidadeTracodeClasse = "No 7° nível, seu instinto está tão apurado que você recebe vantagem nas jogadas de iniciativa. Além disso, se você estiver surpreso no começo de um combate e não estiver incapacitado, você pode agir normalmente no seu primeiro turno, mas apenas se você entrar em fúria antes de realizar qualquer outra coisa neste turno. "

            },
            //10, Crítico Brutal, -
            new TracodeClasse
            {
                IdTracodeClasse = 10,
                Nome = "Crítico Brutal",
                HabilidadeTracodeClasse = "A partir do 9° nível, você pode rolar um dado de dano de arma adicional quando estiver determinando o dano extra de um acerto crítico com uma arma corpo-a-corpo. Isso aumenta para dois dados adicionais no 13° nível e três dados adicionais no 17° nível."
            },
            //11, Fúria Implacável, -
            new TracodeClasse
            {
                IdTracodeClasse = 11,
                Nome = "Fúria Implacável",
                HabilidadeTracodeClasse = "A partir do 11° nível, sua fúria pode manter você lutando independente da gravidade dos seus ferimentos. Se você cair para 0 pontos de vida enquanto estiver em fúria e não morrer, você pode realizar um teste de resistência de Constituição CD 10. Se você for bem sucedido, você volta para 1 ponto de vida ao invés disso. Cada vez que você utilizar essa característica após a primeira, a CD aumenta em 5. Assim que você terminar um descanso curto ou longo a CD volta para 10"
            },
            //12, Fúria Persistente, -
            new TracodeClasse
            {
                IdTracodeClasse = 12,
                Nome = "Fúria Persistente",
                HabilidadeTracodeClasse = "A partir do 15° nível, sua fúria é tão brutal que ela só termina prematuramente se você cair inconsciente ou se você decidir terminá-la. "
            },
            //13, Força Indomável, -
            new TracodeClasse
            {
                IdTracodeClasse = 13,
                Nome = "Força Indomável",
                HabilidadeTracodeClasse = "A partir do 18° nível, se o total de um teste de Força seu for menor que o seu valor de Força, você pode usar esse valor no lugar do resultado. "
            },
            //14, Campeão Primitivo, -
            new TracodeClasse
            {
                IdTracodeClasse = 14,
                Nome = "Campeão Primitivo",
                HabilidadeTracodeClasse = "No 20° nível, você incorpora os poderes da natureza. Seus valores de Força e Constituição aumentam em 4. Seu máximo para esses valores agora é 24."
            },
            //15, Conjuração
            new TracodeClasse
            {
                IdTracodeClasse = 15,
                Nome = "Conjuração",
                HabilidadeTracodeClasse = "Você aprendeu a desembaraçar e remodelar o decido da realidade em harmonia com os seus desejos e música. Suas magias são parte do seu vasto repertório, magia que você pode entoar em diferentes situações. Veja o capítulo 10 para as regras gerais de conjuração e o capítulo 11 para a lista de magias de bardo. TRUQUES Você conhece dois truques, à sua escolha da lista de magias de bardo. Você aprende truques de bardo adicionais, à sua escolha em níveis mais altos, como mostrado na coluna Truques Conhecidos da tabela O Bardo. A tabela O Bardo mostra quantos espaços de magia de 1° nível e superiores você possui disponíveis para conjuração. Para conjurar uma dessas magias, você deve gastar uma espaço de magia do nível da magia ou superior. Você recobra todos os espaços de magia gastos quando você completa um descanso longo. Por exemplo, se você quiser conjurar a magia de 1° nível curar ferimentos e você tiver um espaço de magia de 1° nível e um de 2° nível disponíveis, você poderá conjurar curar ferimentos usando qualquer dos dois espaços. MAGIAS CONHECIDAS DE 1° NÍVEL E SUPERIORES Você conhece quatro magias de 1° nível, à sua escolha, da lista de magias de bardo. A coluna Magias Conhecidas na tabela O Bardo mostra quando você aprende mais magias de bardo, à sua escolha. Cada uma dessas magias deve ser de um nível a que você tenha acesso, como mostrado na tabela. Por exemplo, quando você alcança o 3° nível da classe, você pode aprender uma nova magia de 1° ou 2° nível. Além disso, quando você adquire um nível nessa classe, você pode escolher uma magia de bardo que você conheça e substituí-la por outra magia da lista de magias de bardo, que também deve ser de um nível ao qual você tenha espaços de magia. HABILIDADE DE CONJURAÇÃO Sua habilidade de conjuração é Carisma para suas magias de bardo, portanto, você usa seu Carisma sempre que alguma magia se referir à sua habilidade de conjurar magias. Além disso, você usa o seu modificador de Carisma para definir a CD dos testes de resistência para as magias de bardo que você conjura e quando você realiza uma jogada de ataque com uma magia. CD para suas magias = 8 + bônus de proficiência + seu modificador de Carisma Modificador de ataque de magia = seu bônus de proficiência + seu modificador de Carisma CONJURAÇÃO DE RITUAL Você pode conjurar qualquer magia de bardo que você conheça como um ritual se ela possuir o descritor ritual. FOCO DE CONJURAÇÃO Você pode usar um instrumento musical (encontrado no capítulo 5) como foco de conjuração das suas magias de bardo. "
            },
            //16, Inspiracao de Bardo (d6)
            new TracodeClasse
            {
                IdTracodeClasse = 16,
                Nome = "Inspiração de Bardo (d6)",
                HabilidadeTracodeClasse = "Você pode inspirar os outros através de palavras animadoras ou música. Para tanto, você usa uma ação bônus no seu turno para escolher uma outra criatura, que não seja você mesmo, a até 18 metros de você que possa ouvi-lo. Essa criatura ganha um dado de Inspiração de Bardo, um d6. Uma vez, nos próximos 10 minutos, a criatura poderá rolar o dado e adicionar o valor rolado a um teste de habilidade, jogada de ataque ou teste de resistência que ela fizer. A criatura pode esperar até rolar o d20 antes de decidir usar o dado de Inspiração de Bardo, mas deve decidir antes do Mestre dizer se a rolagem foi bem ou mal sucedida. Quando o dado de Inspiração de Bardo for rolado, ele é gasto. Uma criatura pode ter apenas um dado de Inspiração de Bardo por vez. Você pode usar essa característica um número de vezes igual ao seu modificador de Carisma (no mínimo uma vez). Você recupera todos os usos quando termina um descanso longo. Seu dado de Inspiração de Bardo muda quando você atinge certos níveis na classe. O dado se torna um d8 no 5° nível, um d10 no 10° nível e um d12 no 15° nível."
            },
            //17, Versatilidade
            new TracodeClasse
            {
                IdTracodeClasse = 17,
                Nome = "Versatilidade",
                HabilidadeTracodeClasse = "A partir do 2° nível, você pode adicionar metade do seu bônus de proficiência, arredondado para baixo, em qualquer teste de habilidade que você fizer que ainda não possua seu bônus de proficiência. "
            },
            //18. Canção de Descanso
            new TracodeClasse
            {
                IdTracodeClasse = 18,
                Nome = "Canção de Descanso",
                HabilidadeTracodeClasse = "A partir do 2° nível, você pode usar música ou oração calmantes para ajudar a revitalizar seus aliados feridos durante um descanso curto. Se você ou qualquer criatura amigável que puder ouvir sua atuação recuperar pontos de vida no fim do descanso curto ao gastar um ou mais Dados de Vida, cada uma dessas criaturas recupera 1d6 pontos de vida adicionais. Os pontos de vida adicionais aumentam quando você alcança determinados níveis na classe: para 1d8 no 9° nível, para 1d10 no 13° nível e para 1d12 no 17° nível. "
            },
            //19, Colégio de Bardo
            new TracodeClasse
            {
                IdTracodeClasse = 19,
                Nome = "Colégio de Bardo",
                HabilidadeTracodeClasse = "No 3° nível, você investiga as técnicas avançadas de um colégio de bardo, à sua escolha: o Colégio do Conhecimento ou o Colégio da Bravura, ambos detalhados no final da descrição da classe. Sua escolha lhe concede características no 3° nível e novamente no 6° e 14° nível."
            },
            //20, Aptidão
            new TracodeClasse
            {
                IdTracodeClasse = 20,
                Nome = "Aptidão",
                HabilidadeTracodeClasse = "No 3° nível, escolha duas das perícias em que você é proficiente. Seu bônus de proficiência é dobrado em teste de habilidade que você fizer que utilize qualquer das perícias escolhidas. No 10° nível, você escolhe mais duas perícias em que é proficiente para ganhar esse benefício. "
            },
            //21, Fonte de Inspiração
            new TracodeClasse
            {
                IdTracodeClasse = 21,
                Nome = "Fonte de Inspiração",
                HabilidadeTracodeClasse = "Começando no momento em que você atinge o 5° nível, você recupera todas as utilizações gastas da sua Inspiração de Bardo quando você termina um descanso curto ou longo. "
            },
            //22, Canção de Proteção
            new TracodeClasse
            {
                IdTracodeClasse = 22,
                Nome = "Canção de Proteção",
                HabilidadeTracodeClasse = "No 6° nível, você adquire a habilidade de usar notas musicais ou palavras de poder para interromper efeito de influência mental. Com uma ação, você pode começar uma atuação que dura até o fim do seu próximo turno. Durante esse tempo, você e qualquer criatura amigável a até 9 metros de você terá vantagem em testes de resistência para não ser amedrontado ou enfeitiçado. Uma criatura deve ser capaz de ouvir você para receber esse benefício. A atuação termina prematuramente se você for incapacitado ou silenciado ou se você terminá-la voluntariamente (não requer ação)"
            },
            //23, Segredos Mágicos
            new TracodeClasse
            {
                IdTracodeClasse = 23,
                Nome = "Segredos Mágicos",
                HabilidadeTracodeClasse = "No 10° nível, você usurpou conhecimento mágico de um vasto espectro de disciplinas. Escolha duas magias de qualquer classe, incluindo essa. A magia que você escolher deve ser de um nível que você possa conjurar, como mostrado na tabela O Bardo, ou um truque. As magias escolhidas contam como magias de bardo para você e já estão incluídas no número da coluna Magias Conhecidas da tabela O Bardo. Você aprende duas magias adicionais de qualquer classe no 14° nível e novamente no 18° nível."
            },
            //24, Inspiração Superior
            new TracodeClasse
            {
                IdTracodeClasse = 24,
                Nome = "Inspiração Superior",
                HabilidadeTracodeClasse = "No 20° nível, quando você rolar iniciativa e não tiver nenhum uso restante de Inspiração de Bardo, você recupera um uso."
            },
            //25, Patrono Transcendental
            new TracodeClasse
            {
                IdTracodeClasse = 25,
                Nome = "Patrono Transcendental",
                HabilidadeTracodeClasse = "No 1° nível, você conclui uma barganha com um ser transcendental, à sua escolha: a Arquifada, o Corruptor ou o Grande Antigo, cada um deles é detalhado no final da descrição da classe. Sua escolha lhe confere traços no 1° nível e novamente no6°, 10° e 14° nível."
            },
            //26, Magia de Pacto
            new TracodeClasse
            {
                IdTracodeClasse = 26,
                Nome = "Magia de Pacto",
                HabilidadeTracodeClasse = "Sua pesquisa arcana e a magia outorgada a você por seu patrono, lhe concedem uma gama de magias. Veja o capítulo 10 para as regras gerais de conjuração e o capítulo 11 para a lista de magias de bruxo. TRUQUES Você conhece dois truques, à sua escolha, da lista de magias de bruxo. Você aprende truques de bruxo adicionais, à sua escolha, em níveis mais altos, como mostrado na coluna Truques Conhecidos da tabela O Bruxo. ESPAÇOS DE MAGIA A tabela O Bruxo mostra quantos espaços de magia você possui. A tabela também mostra qual o nível desses espaços; todos os seus espaços de magia são do mesmo nível. Para conjurar uma magia de bruxo de 1° nível ou superior, você deve gastar uma espaço de magia. Você recobra todos os espaços de magia gastos quando você completa um descanso curto ou longo. Por exemplo, quando você atingir o 5° nível, você terá dois espaços de magia de 3° nível. Para conjurar a magia de 1° nível onda trovejante, você deve gastar um desses espaços e você a conjura como uma magia de 3° nível. MAGIAS CONHECIDAS DE 1° NÍVEL E SUPERIORES No 1° nível, você conhece duas magias de 1° nível, à sua escolha da lista de magias de bruxo. A coluna Magias Conhecidas na tabela O Bruxo mostra quando você aprende mais magias de bruxo, à sua escolha, de 1° nível ou superior. Cada uma dessas magias deve ser de um nível a que você tenha acesso, como mostrado na tabela na coluna de Nível de Magia para o seu nível. Quando você alcança o 6° nível, por exemplo, você aprende uma nova magia de bruxo, que pode ser de 1°, 2° ou 3° nível. Além disso, quando você adquire um nível nessa classe, você pode escolher uma magia de bruxo que você conheça e substituí-la por outra magia da lista de magias de bruxo, que também deve ser de um nível ao qual você tenha espaços de magia. HABILIDADE DE CONJURAÇÃO Sua habilidade de conjuração é Carisma para suas magias de bruxo, portanto, você usa seu Carisma sempre que alguma magia se referir à sua habilidade de conjurar magias. Além disso, você usa o seu modificador de Carisma para definir a CD dos testes de resistência para as magias de bruxo que você conjura e quando você realiza uma jogada de ataque com uma magia. CD para suas magias = 8 + bônus de proficiência + seu modificador de Carisma Modificador de ataque de magia = seu bônus de proficiência + seu modificador de Carisma FOCO DE CONJURAÇÃO Você pode usar um foco arcano (encontrado no capítulo 5) como foco de conjuração das suas magias de bruxo. "
            },
            //27, Invocações Místicas
            new TracodeClasse
            {
                IdTracodeClasse = 27,
                Nome = "Invocações Místicas",
                HabilidadeTracodeClasse = "Durante seus estudos sobre conhecimento oculto, você descobriu as invocações místicas, fragmentos de conhecimento proibido que infundiram você com habilidade mágica permanente. No 2° nível, você ganha duas invocações místicas, à sua escolha. Suas opções de invocação estão detalhadas no final da descrição dessa classe. Quando você atinge certos nível de bruxo, você adquire novas invocações à sua escolha, como mostrado na coluna Invocações Conhecidas na tabela O Bruxo. Além disso, quando você adquire um novo nível nessa classe, você pode escolher uma invocação que você conheça e substituí-la por outra invocação que você possa aprender nesse nível. "
            },
            //28, Dádiva do Pacto
            new TracodeClasse
            {
                IdTracodeClasse = 28,
                Nome = "Dádiva de Pacto",
                HabilidadeTracodeClasse = "No 3° nível, seu patrono transcendental lhe confere um dom por seus leais serviços. Você adquire uma das características a seguir, à sua escolha."
            },
            //29, Arcana Mística
            new TracodeClasse
            {
                IdTracodeClasse = 29,
                Nome = "Arcana Mística",
                HabilidadeTracodeClasse = "No 11° nível, seu patrono confere a você um segredo mágico conhecido como arcana. Escolha uma magia de 6° nível da lista de magias de bruxo como sua arcana. Você pode conjurar essa magia arcana uma vez sem gastar um espaço de magia. Você deve terminar um descanso longo antes de poder fazer isso novamente. Em nível altos, você adquire mais magias de bruxo de sua escolha que podem ser conjuradas dessa forma: uma magia de 7° nível no 13° nível, uma magia de 8° nível no 15° nível e uma magia de 9° nível no 17° nível. Você recupera todos os usos de sua Arcana Mística quando você termina um descanso longo."
            },
            //30 Mestre Místico
            new TracodeClasse
            {
                IdTracodeClasse = 30,
                Nome = "Mestre Místico",
                HabilidadeTracodeClasse = "No 20° nível, você pode recarregar sua reserva interior de poder místico quando suplicar ao seu patrono para recuperar espaços de magia gastos. Você pode gastar 1 minuto suplicando pela ajuda do seu patrono para recuperar todos os espaços de magia gastos da sua característica Magia de Pacto. Uma vez que você recuperou espaços de magia com essa característica, você deve terminar um descanso longo antes de fazê-lo novamente. "
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
                    HabilidadeArquetipo = "CAMINHO DO FURIOSO Para alguns bárbaros, a fúria é um meio para um fim – esse fim é a violência. O Caminho do Furioso é um caminho de fúria livre, entumecido em sangue. A medida que você entra na fúria de um furioso, você vibra no caos da batalha, despreocupado com a sua própria saúde ou bem-estar. FRENESI Começando no momento que você escolhe esse caminho no 3° nível, você pode entrar num frenesi quando estiver em fúria. Se você desejar, pela duração da sua fúria, você pode realizar um único ataque corpo-a-corpo com arma, com uma ação bônus, em cada um de seus turnos após esse. Quando sua fúria acabar, você sofrerá um nível de exaustão (como descrito no apêndice A). FÚRIA INCONSCIENTE A partir do 6° nível, você não pode ser enfeitiçado ou amedrontado enquanto estiver em fúria. Se você estava enfeitiçado ou amedrontado quando entrou em fúria, o efeito é suspenso pela duração da fúria. PRESENÇA INTIMIDANTE A partir do 10° nível, você pode usar sua ação para amedrontar alguém com sua presença intimidante. Quando o fizer, escolha uma criatura que você possa ver a 9 metros. Se a criatura puder ver ou ouvir você, ela deve ser bem sucedida num teste de resistência de Sabedoria (CD igual a 8 + seu bônus de proficiência + seu modificador de Carisma) ou ficara com medo de você até o fim do seu próximo turno. Nos turnos seguintes, você pode usar sua ação para estender a duração desse efeito na criatura amedrontada até o início do seu próximo turno. Esse efeito termina se a criatura terminar seu turno fora da sua linha de visão ao a mais de 18 metros de você. Se a criatura for bem sucedida no teste de resistência, você não poderá usar essa característica nessa criatura novamente por 24 horas. RETALIAÇÃO A partir do 14° nível, quando você sofrer dano de uma criatura que esteja a até 1,5 metro de você, você pode usar sua reação para realizar um ataque corpo-a-corpo com arma contra essa criatura. "
                },
                //2, Caminho do Guerreiro Totêmico
                new Arquetipo
                {
                    IdArquetipo = 2,
                    Nome = "Caminho do Guerreiro Totêmico",
                    HabilidadeArquetipo = "O Caminho do Guerreiro Totêmico é uma jornada espiritual, à partir do momento que o bárbaro aceita um espirito animal como seu guia, protetor e inspiração. Em batalha, seu espirito totêmico preenche você com força sobrenatural, adicionando combustível mágico a sua fúria bárbara. A maioria das tribos bárbaras consideram que um animal totêmico possui parentesco a um clã em particular. Em tais casos, é incomum a um indivíduo possuir mais de um espirito animal totêmico, apesar de existirem exceções. CONSELHEIRO ESPIRITUAL Seu caminho é buscar a sintonia com o mundo natural, concedendo a você uma afinidade com as bestas. A partir do 3° nível, quando você toma esse caminho, você recebe a habilidade de conjurar as magias sentido bestial e falar com animais, mas apenas na forma de rituais, como descrito no capítulo 10. TOTEM ESPIRITUAL A partir do 3° nível, quando você adota esse caminho, você escolhe um totem espiritual e ganha suas características. Você deve fazer ou adquirir um objeto físico como totem – um amuleto ou adorno similar – que incorpora o pelo ou penas, garras, dente ou ossos do animal totêmico. Se você quiser, você também adquire pequenos atributos físicos que o assemelham ao seu totem espiritual. Por exemplo, se você tiver o totem espiritual do urso, você seria incomumente peludo e de pele grossa, ou se o seu totem for a águia, seu olhos teriam um brilho amarelado. Seu totem animal deve ser um animal relacionado aos listados aqui, mas pode ser um mais apropriado a sua terra natal. Por exemplo, você poderia escolher falcão ou abutre ao invés de águia. Águia. Quando estiver em fúria e não estiver vestindo uma armadura pesada, as outras criaturas terão desvantagem nas jogadas de ataque de oportunidade contra você e você pode usar a ação de Disparada como uma ação bônus no seu turno. O espirito da águia torna você um predador que pode vagar pelo meio da briga com facilidade. Lobo. Quando estiver em fúria, seus amigos tem vantagem nas jogadas de ataque corpo-a-corpo realizadas contra qualquer criatura a 1,5 metro de você que seja hostil a você. O espirito do lobo transforma você em um líder de caça. Urso. Quando em fúria, você adquire resistência a todos os tipos de dano, exceto dano psíquico. O espirito do urso torna você vigoroso o suficiente para permanecer de pé diante de qualquer castigo. ASPECTO DA BESTA No 6° nível, você adquire um benefício místico baseado no totem que você escolheu. Você pode escolher o mesmo animal que selecionou no 3° nível ou um diferente. Águia. Você ganha a visão aguçada de uma águia. Você pode ver a até 1,6 km sem dificuldade, sendo capaz de discernir até os menores detalhes quando estiver olhando para algo a menos de 30 metros de você. Além disso, penumbra não impõem desvantagem nos seus testes de Sabedoria (Percepção). Lobo. Você ganha a sensibilidade predatória de um lobo. Você pode rastrear outras criaturas quando estiver viajando a passo rápido e você pode se mover furtivamente quando estiver viajando a passo normal (veja o capítulo 8 para as regras de passo de viagem). Urso. Você ganha a força de um urso. Sua capacidade de carga (incluindo carga máxima e capacidade de erguer) é dobrada e você tem vantagem em testes de Força realizados para empurrar, puxar, erguer ou quebrar objetos. ANDARILHO ESPIRITUAL No 10° nível, você pode conjurar a magia comunhão com a natureza, mas apenas como um ritual. Quando o fizer, uma versão espiritual de um dos animais que você escolheu como Totem Espiritual ou Aspecto da Besta aparece para você para transmitir a informação que você busca. SINTONIA TOTÊMICA No 14° nível, você ganha um benefício magico baseado em um totem animal, à sua escolha. Você pode escolher o mesmo animal que selecionou anteriormente ou um diferente. Águia. Quando estiver em fúria, você adquire um deslocamento de voo igual ao seu deslocamento de caminhada. Esse benefício funciona apenas em pequenos explosões: você cai se terminar seu turno no ar e não tiver nada em que possa se agarrar. Lobo. Quando estiver em fúria, você pode usar uma ação bônus no seu turno para derrubar uma criatura Grande ou menor no chão quando você atingi-la com um ataque corpo-a-corpo com arma. Urso. Quando estiver em fúria, qualquer criatura a até 1,5 metro de você que for hostil a você terá desvantagem nas jogadas de ataque contra outros alvos além de você ou outro personagem com essa característica. Um inimigo é imune a esse efeito se ele não puder ver ou ouvir você ou caso ele não possa ser amedrontado. "
                },
                //3, Colégio do Conhecimento
                new Arquetipo
                {
                    IdArquetipo = 3,
                    Nome = "Colégio do Conhecimento",
                    HabilidadeArquetipo = "Bardos do Colégio do Conhecimento conhecem algo sobre a maioria das coisas, coletando pedaços de conhecimento de fontes tão diversas quanto tomos eruditos ou contos de camponeses. Quer seja cantando baladas populares em taverna, quer seja elaborando composições para cortes reais, esses bardos usam seus dons para manter a audiência enfeitiçada. Quando os aplausos acabam, os membros da audiência vão estar se questionando se tudo que eles creem é verdade, desde sua crença no sacerdócio do templo local até sua lealdade ao rei. A fidelidade desses bardos reside na busca pela beleza e verdade, não na lealdade a um monarca ou em seguir os dogmas de uma divindade. Um nobre que mantem um bardo desses como seu arauto ou conselheiro, sabe que o bardo prefere ser honesto que político. Os membros do colégio se reúnem em bibliotecas e, as vezes, em faculdades de verdade, completas com salas de aula e dormitórios, para partilhar seu conhecimento uns com os outros. Eles também se encontram em festivais ou em assuntos de estado, onde eles podem expor corrupção, desvendar mentiras e zombar da superestima de figuras de autoridade. PROFICIÊNCIA ADICIONAL Quando você se junta ao Colégio do Conhecimento no 3° nível, você ganha proficiência em três perícias, à sua escolha. PALAVRAS DE INTERRUPÇÃO Também no 3° nível, você aprende como usar sua perspicácia para distrair, confundir e, de outras formas, atrapalhar a confiança e competência de outros. Quando uma criatura que você pode ver a até 18 metros de você realizar uma jogada de ataque, um teste de habilidade ou uma jogada de dano, você pode usar sua reação para gastar um uso de Inspiração de Bardo, rolando o dado de Inspiração de Bardo e subtraindo o número rolado da rolagem da criatura. Você escolhe usar essa característica depois da criatura fazer a rolagem, mas antes do Mestre determinar se a jogada de ataque ou teste de habilidade foi bem ou mal sucedido, ou antes da criatura causar dano. A criatura será imune se não puder ouvir ou se não puder ser enfeitiçada. SEGREDOS MÁGICOS ADICIONAIS No 6° nível, você aprende duas magias, à sua escolha, de qualquer classe. As magias que você escolher devem ser de um nível que você possa conjurar, como mostrado na tabela O Bardo, ou um truque. As magias escolhidas contam como magias de bardo pra você, mas não contam no número de magias de bardo que você conhece. PERÍCIA INIGUALÁVEL A partir do 14° nível, quando você fizer um teste de habilidade, você pode gastar um uso de Inspiração de Bardo. Role o dado de Inspiração de Bardo e adicione o número rolado ao seu teste de habilidade. Você pode escolher fazer isso depois de rolar o dado do teste de habilidade, mas antes do Mestre dizer se foi bem ou mal sucedido. "
                },
                //4, Colégio da Bravura
                new Arquetipo
                {
                    IdArquetipo = 4,
                    Nome = "Colégio da Bravura",
                    HabilidadeArquetipo = "Os bardos do Colégio da Bravura são escaldos destemidos de quem os contos mantem viva a memória dos grandes heróis do passado, dessa forma inspirando uma nova geração de heróis. Esses bardos se reúnem em salões de hidromel ou ao redor de fogueiras para cantar os feitos dos grandiosos, tanto do passado quanto do presente. Eles viajam pelos lugares para testemunhar grandes eventos em primeira mão e para garantir que a memória desses eventos não se perca nesse mundo. Com suas canções, eles inspiram outros a alcançar o mesmo patamar de realizações dos antigos heróis. PROFICIÊNCIA ADICIONAL Quando você se junta ao Colégio da Bravura no 3° nível, você adquire proficiência com armadura médias, escudos e armas marciais. INSPIRAÇÃO EM COMBATE Também no 3° nível, você aprende a inspirar os outros em batalha. Uma criatura que possuir um dado de Inspiração de Bardo seu, pode rolar esse dado e adicionar o número rolado a uma jogada de dano que ele tenha acabado de fazer. Alternativamente, quando uma jogada de ataque for realizada contra essa criatura, ela pode usar sua reação para rolar o dado de Inspiração de Bardo e adicionar o número rolado a sua CA contra esse ataque, depois da rolagem ser feita, mas antes de saber se errou ou acertou. ATAQUE EXTRA A partir do 6° nível, você pode atacar duas vezes, ao invés de uma, sempre que você realizar a ação de Ataque no seu turno. MAGIA DE BATALHA No 14° nível, você dominou a arte de tecer a conjuração e usar armas em um ato harmonioso. Quando você usar sua ação para conjurar uma magia de bardo, você pode realizar um ataque com arma com uma ação bônus."
                },
                //5, Pacto da Corrente
                new Arquetipo
                {
                    IdArquetipo = 5,
                    Nome = "Pacto da Corrente",
                    HabilidadeArquetipo = "PACTO DA CORRENTE Você aprende a magia convocar familiar e pode conjurá-la como um ritual. Essa magia não conta no número de magias que você conhece. Quando você conjura essa magia, você pode escolher uma das formas convencionais para o seu familiar ou uma das seguintes formas especiais: diabrete, pseudodragão, quasit ou sprite. Além disso, quando você realiza a ação de Ataque, você pode renunciar s um dos seus ataques para permitir que seu familiar realize um ataque, com a reação dele"
                },
                //6, Pacto da Lâmina
                new Arquetipo
                {
                    IdArquetipo = 6,
                    Nome = "Pacto da Lâmina",
                    HabilidadeArquetipo = "Você pode usar sua ação para criar uma arma de pactom em sua mão vazia. Você escolhe a forma que essa arma corpo-a-corpo tem a cada vez que você a cria (veja as opções de arma no capítulo 5). Você é proficiente com ela enquanto a empunhar. Essa arma conta como sendo mágica com os propósitos de ultrapassar resistência e imunidade a ataques e danos não-mágicos. Sua arma de pacto desaparece se ela estiver a mais de 1,5 metro de você por 1 minuto ou mais. Ela também desaparece se você usar essa característica novamente, se você dissipar a arma (não requer ação) ou se você morrer. Você pode transformar uma arma mágica em sua arma de pacto ao realizar um ritual especial enquanto empunha a arma. Você precisa de 1 hora para concluir o ritual, que pode ser realizado durante um descanso curto. Você pode dissipar a arma, guardando-a em um espaço extradimensional, e ela reaparece toda vez que você criar sua arma de pacto. A arma deixa de ser sua arma de pacto se você morrer, se você realizar um ritual de 1 hora com outra arma diferente ou se você realizar um ritual de 1 hora para romper seu elo com ela. A arma aparece aos seus pés se ela estiver no espaço extradimensional quando o elo for quebrado."
                },
                //7, Pacto do Tomo
                new Arquetipo
                {
                    IdArquetipo = 7,
                    Nome = "Pacto do Tomo",
                    HabilidadeArquetipo = "Seu patrono lhe deu um grimório chamado Livro das Sombras. Quando você adquire essa característica, escolha três truques da lista de magias de qualquer classe. Enquanto o livro estiver com você, você poderá conjurar esses truques à vontade. Eles não contam no número de truques que você conhece. Esses truques são considerados magias de bruxo para você e não precisam ser da mesma lista de magia. Se você perder seu Livro das Sombras, você pode realizar uma cerimônia de 1 hora para receber um substituto do seu patrono. Essa cerimônia pode ser realizada durante um descanso curto ou longo e destrói o livro anterior. O livro se torna cinzas quando você morre"
                },
                //8, A Arquifada
                new Arquetipo
                {
                    IdArquetipo = 8,
                    Nome = "A Arquifada",
                    HabilidadeArquetipo = "Seu patrono é um senhor ou senhora das fadas, uma criatura lendária que detém segredos que foram esquecidos antes das raças mortais nascerem. As motivações desses seres são, muitas vezes, inescrutáveis e, as vezes, excêntricas e podem envolver esforços para adquirir grandes poderes mágicos ou resolução de desavenças antigas. Incluem-se dentre esses seres o Príncipe do Frio; a Rainha do Ar e Trevas, regente da Corte do Crepúsculo; Titania da Corte do Verão; seu cônjuge, Oberon, o Senhor Verdejante; Hyrsam, o Príncipe dos Tolos; e bruxas antigas. LISTA DE MAGIA EXPANDIDA A Arquifada permite que você escolha magias de uma lista expandida quando você for aprender magias de bruxo. As seguintes magias são adicionadas a sua lista de magias de bruxo. MAGIAS EXPANDIDAS DA ARQUIFADA Nível de Magia Magias 1° fogo das fadas, sono 2° acalmar emoções, força fantasmagórica 3° piscar, ampliar plantas 4° dominar besta, invisibilidade maior 5° dominar pessoa, similaridade PRESENÇA FEÉRICA A partir do 1° nível, seu patrono concede a você a habilidade de projetar a sedução e temeridade da presença da fada. Com uma ação, você pode fazer com que cada criatura num cubo de 3 metros centrado em você, faça um teste de resistência de Sabedoria com uma CD igual a de sua magia de bruxo. As criaturas que falharem no teste ficaram enfeitiçadas ou amedrontadas por você (à sua escolha) até o início do seu próximo turno. Quando você usar essa característica, você não poderá utilizá-la novamente antes de realizar um descanso curto ou longo. NÉVOA DE FUGA A partir do 6° nível, você pode desaparecer em uma lufada de névoa em resposta a alguma ofensa. Quando você sofrer dano, você pode usar sua reação para ficar invisível e se teletransportar a até 18 metros para um espaço desocupado que você possa ver. Você permanece invisível até o início do seu próximo turno ou até realizar um ataque ou conjurar uma magia. Após usar essa características, você não poderá utilizá-la novamente até terminar um descanso curto ou longo. DEFESA SEDUTORA A partir do 10° nível, seu patrono ensina você como voltar as magias de efeito mental dos seus inimigos contra eles. Você não pode ser enfeitiçado e, quando outra criatura tenta enfeitiçá-lo, você pode usar sua reação para tentar reverter o encanto de volta aquela criatura. A criatura deve ser bem sucedida num teste de resistência de Sabedoria contra a CD da sua magia de bruxo ou ficara enfeitiçado por 1 minuto ou até a criatura sofrer dano. DELÍRIO SOMBRIO Começando no 14° nível, você pode imergir uma criatura num reino ilusório. Com um ação, escolha uma criatura que você possa ver a até 18 metros de você. Ela deve ser bem sucedida num teste de resistência de Sabedoria contra a CD da sua magia de bruxo. Se ela falhar, ela ficará enfeitiçada ou amedrontada por você (à sua escolha) por 1 minuto ou até você quebrar sua concentração (como se você estivesse se concentrando em uma magia). Esse efeito termina prematuramente se a criatura sofrer dano. Até que essa ilusão termine, a criatura acredita que está perdida num reino enevoado, a aparência desse reino fica a seu critério. A criatura só pode ver e ouvir a si mesma, a você e a sua ilusão. Você deve terminar um descanso curto ou longo antes de poder usar essa característica novamente. "
                }
            );

            //IdHabilidadeRacial, Nome, Descrição

            modelBuilder.Entity<HabilidadeRacial>().HasData(
            //1, Visão no Escuro
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 1,
                Nome = "Visão no Escuro",
                Descricao = "Acostumado à vida subterrânea ou às florestas crepusculares e ao céu noturno, você tem uma visão superior no escuro e na penumbra. Você enxerga na penumbra a até 18 metros como se fosse luz plena, e no escuro como se fosse na penumbra. Você não pode discernir cores no escuro, apenas tons de cinza."
            },
            //2, Resiliência Anã
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 2,
                Nome = "Resiliência Anã",
                Descricao = "Você possui vantagem em testes de resistência contra venenos e resistência contra dano de veneno"
            },
            //3, Treinamento Anão em Combate
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 3,
                Nome = "Treinamento Anão em Combate",
                Descricao = "Você tem proficiência com machados de batalha, machadinhas,martelos leves e martelos de guerra."
            },
            //4, Proficiência com Ferramentas
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 4,
                Nome = "Proficiência com Ferramentas",
                Descricao = "Você tem proficiência em uma ferramenta de artesão à sua escolha entre: ferramentas de ferreiro, suprimentos de cervejeiro ou ferramentas de pedreiro. "
            },
            //5, Especialização em Rochas
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 5,
                Nome = "Especialização em Rochas",
                Descricao = "Sempre que você realizar um teste de Inteligência (História) relacionado à origem de um trabalho em pedra, você é considerado proficiente na perícia História e adiciona o dobro do seu bônus de proficiência ao teste, ao invés do seu bônus de proficiência normal."
            },
            //6, Tenacidade Anã
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 6,
                Nome = "Tenacidade Anã",
                Descricao = "Seu máximo de pontos de vida aumentam em 1, e cada vez que o anão da colina sobe um nível, ele recebe 1 ponto de vida adicional."
            },
            //7, Treinamento anão com Armaduras
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 7,
                Nome = "Treinamento Anão com Armaduras",
                Descricao = "Você adquire proficiência em armaduras leves e médias. "
            },
            //8, Sentidos Aguçados
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 8,
                Nome = "Sentidos Aguçados",
                Descricao = "Você tem proficiência na perícia Percepção."
            },
            //9, Ancestral Feérico
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 9,
                Nome = "Ancestral Feérico",
                Descricao = "Você tem vantagem nos testes de resistência para resistir a ser enfeitiçado e magias não podem colocá-lo para dormir. "
            },
            //11, Transe
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 11,
                Nome = "Transe",
                Descricao = "Elfos não precisam dormir. Ao invés disso, eles meditam profundamente, permanecendo semiconscientes, durante 4 horas por dia. (A palavra em idioma comum para tal meditação é 'transe'.) Enquanto medita, um elfo é capaz de sonhar de certo modo. Esses sonhos na verdade são exercícios mentais que se tornam reflexos através de anos de prática. Depois de descansar dessa forma, você ganha os mesmos benefícios que um humano depois de 8 horas de sono."
            },
            //12 Treinamento Élfico com Armas
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 12,
                Nome = "Treinamento Élfico com Armas",
                Descricao = "Você possui proficiência com espadas longas, espadas curtas, arcos longos e arcos curtos. "
            },
            //13, Truque
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 13,
                Nome = "Truque",
                Descricao = "Você conhece um truque, à sua escolha, da lista de truques do mago. Inteligência é a habilidade usado para conjurar este truque. "
            },
            //14, Idioma Adicional
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 14,
                Nome = "Idioma Adicional",
                Descricao = " Você pode falar, ler e escrever um idioma adicional à sua escolha."
            },
            //15, Pés Ligeiros
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 15,
                Nome = "Pés Ligeiros",
                Descricao = "Seu deslocamento base de caminhada aumenta para 10,5 metros."
            },
            //16, Máscara da Natureza
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 16,
                Nome = "Máscara da Natureza",
                Descricao = "Você pode tentar se esconder mesmo quando você está apenas levemente obscurecido por folhagem, chuva forte, neve caindo, névoa ou outro fenômeno natural. "
            },
            //17, Visão no Escuro Superior
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 17,
                Nome = "Visão no Escuro Superior",
                Descricao = " Sua visão no escuro tem alcance de 36 metros de raio"
            },
            //18, Sensibilidade à Luz Solar
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 18,
                Nome = "Sensibilidade à Luz Solar",
                Descricao = "Você possui desvantagem nas jogadas de ataque e testes de Sabedoria (Percepção) relacionados a visão quando você, o alvo do seu ataque, ou qualquer coisa que você está tentando perceber, esteja sob luz solar direta. "
            },
            //19, Magia Drow
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 19,
                Nome = "Magia Drow",
                Descricao = ". Você possui o truque globos de luz. Quando você alcança o 3° nível, você pode conjurar a magia fogo das fadas. Quando você alcança o 5° nível, você pode conjurar escuridão. Você precisa terminar um descanso longo para poder conjurar as magias desse traço novamente. Carisma é sua habilidade chave para conjurar essas magias. "
            },
            //20, Treinamento Drow com Armas
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 20,
                Nome = "Treinamento Drow com Armas",
                Descricao = "Você possui proficiência com rapieiras, espadas curtas e bestas de mão. "
            },
            //21, Sortudo
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 21,
                Nome = "Sortudo",
                Descricao = "Quando você obtiver um 1 natural em uma jogada de ataque, teste de habilidade ou teste de resistência, você pode jogar de novo o dado e deve utilizar o novo resultado"
            },
            //22, Bravura
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 22,
                Nome = "Bravura",
                Descricao = "Você tem vantagem em testes de resistência contra ficar amedrontado"
            },
            //23, Agilidade Halfling
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 23,
                Nome = "Agilidade Halfling",
                Descricao = "Você pode mover-se através do espaço de qualquer criatura que for de um tamanho maior que o seu"
            },
            //24, Furtividade Natural
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 24,
                Nome = "Furtividade Natural",
                Descricao = "Você pode tentar se esconder mesmo quando possuir apenas a cobertura de uma criatura que for no mínimo um tamanho maior que o seu"
            },
            //25, Resiliência dos Robustos
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 25,
                Nome = "Resiliência dos Robustos",
                Descricao = "Você tem vantagem em testes de resistência contra veneno e tem resistência contra dano de veneno"
            },
            //26, Ancestral Dracônico
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 26,
                Nome = "Ancestral Dracônico",
                Descricao = "Você possui um ancestral dracônico. Escolha um tipo de dragão da tablea Ancestral Dracônico. sua arma de sopro e resistência a dano são determinadas pelo tipo de dragão, como mostrado na tabela"
            },
            //27, Arma de Sopro
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 27,
                Nome = "Arma de Sopro",
                Descricao = "Você pode usar uma ação para exalar energia destrutiva. Seu ancestral dracônico determina o tamanho, formado e tipo de dano que você expele.Quando você usa sua arma de sopro, cada criatura na área exalada deve realizar um teste de resistência, o tipo do teste é determinado pelo seu ancestral dracônico. A CD do teste de resistência é 8 + seu modificador de Constituição + seu bônus de proficiência. Uma criatura sofre 2d6 de dano num fracasso e metade desse dano num sucesso. O dano aumenta para 3d6 no 6° nível, 4d6 no 11° nível e 5d6 no 16° nível. Depois de usar sua arma de sopro, você não poderá utilizá-la novamente até completar um descanso curto ou longo. "
            },
            //28, Resistência a Dano
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 28,
                Nome = "Resistência a Dano",
                Descricao = "Você possui resistência ao tipo de dano associado ao seu ancestral dracônico"
            },
            //29, Esperteza Gnômica
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 29,
                Nome = "Esperteza Gnômica",
                Descricao = "Você possui vantagem em todos os testes de resistência de Inteligência, Sabedoria e Carisma contra magia"
            },
            //30, Ilusionista Nato
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 30,
                Nome = "Ilusionista Nato",
                Descricao = "Você conhece o truque ilusão menor. Inteligência é a sua habilidade usada para cunjurá-la"
            },
            //31, Falar com Bestas Pequenas
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 31,
                Nome = "Falar com Bestas Pequenas",
                Descricao = "Através de sons e gestos, você pode comunicar ideias simples para Bestas pequenas ou menores. Gnomos da floresta amam os animais e normalmente possuem esquilos, doninhas, coelhos, toupeiras, pica-paus e outras criaturas como amados animais de estimação. "
            },
            //32, Conhecimento de Artífice
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 32,
                Nome = "Conhecimento de Artífice",
                Descricao = "Toda vez que você fizer um teste de Inteligência (História) relacionado a itens mágicos, objetos alquímicos ou mecanismos tecnológicos, você pode adicionar o dobro do seu bônus de proficiência, ao invés de qualquer bônus de proficiência que você normalmente use. "
            },
            //33, Engenhoqueiro
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 33,
                Nome = "Engenhoqueiro",
                Descricao = "Você possui proficiência com ferramentas de artesão (ferramentas de engenhoqueiro). Usando essas ferramentas, você pode gastar 1 hora e 10 po em materiais para construir um mecanismo Miúdo (CA 5, 1 pv). O mecanismo para de funcionar após 24 horas (a não ser que você gaste 1 hora reparando-o para manter o mecanismo funcionando), ou quando você usa sua ação para desmantelá-lo; nesse momento, você pode recuperar o material usado para criá-lo. Você pode ter até três desses mecanismos ativos ao mesmo tempo. Quando você criar um mecanismo, escolha uma das seguintes opções: Brinquedo Mecânico. Esse brinquedo é um animal, monstro ou pessoa mecânica, como um sapo, rato, pássaro, dragão ou soldado. Quando colocado no chão, o brinquedo se move 1,5 metro pelo chão em cada um dos seus turnos em uma direção aleatória. Ele faz barulhos apropriados a criatura que ele representa. Isqueiro Mecânico. O mecanismo produz uma miniatura de chama, que você pode usar para acender uma vela, tocha ou fogueira. Usar o mecanismo requer sua ação. Caixa de Música. Quando aberta, essa caixa de música toca uma canção a um volume moderado. A caixa para de tocar quando alcança o fim da música ou quando é fechada."
            },
            //34, Versatilidade em Perícia
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 34,
                Nome = "Versatilidade em Perícia",
                Descricao = "Você ganha proficiência em duas perícias, à sua escolha"
            },
            //35, Ameaçador
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 35,
                Nome = "Ameaçador",
                Descricao = "Você adquire proficiência na perícia Intimidação"
            },
            //36, Resistência Implacável
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 36,
                Nome = "Resistência Implacável",
                Descricao = "Quando você é reduzido a 0 pontos de vida mas não é completamente morto, você pode voltar para 1 ponto de vida. você não pode usar essa característica novamente até completar um descanso longo."
            },
            //37, Ataques Selvagens
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 37,
                Nome = "Ataques Selvagens",
                Descricao = "Quando você atinge um ataque crítico com uma arma corpo-a-corpo, você pode rolar um dos dados de dano da arma mais uma vez e adicioná-lo ao dano extra causado pelo crítico"
            },
            //38, Resistência Infernal
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 38,
                Nome = "Resistência Infernal",
                Descricao = "Você possui resistência a dano do fogo"
            },
            //39, Legado Infernal
            new HabilidadeRacial
            {
                IdHabilidadeRacial = 39,
                Nome = "Legado Infernal",
                Descricao = "Você conhece o truque taumaturgia. Quando você atingir o 3° nível, você poderá conjurar a magia repreensão infernal como uma magia de 2° nível. Quando você atingir o 5° nível, você também poderá conjurar a magia escuridão. Você precisa terminar um descanso longo para poder usar as magias desse traço novamente. Sua habilidade de conjuração para essas magias é Carisma. "
            }
        );
        }
        //IdTipoIdioma, Tipo
        {
            modelBuilder.Entity<TipoIdioma>().HasData(
            //1, Padrão
            new TipoIdioma
            {
                IdTipoIdioma = 1,
                Tipo = "Padrão"
            },
            //2, Exótico
            new TipoIdioma
            {
                IdTipoIdioma = 2,
                Tipo = "Exótico"
            }
        );
        }
        //IdIdioma, Nome, FaladoPor, Alfabeto, IdTipoIdioma
        {
            modelBuilder.Entity<Idioma>().HasData(
            //1, Anão, Anões, Anão, 1
            new Idioma
            {
                IdIdioma = 1,
                Nome = "Anão",
                FaladoPor = "Anões",
                Alfabeto = "Anão",
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
            //3, Élfico, Elfos, Élfico, 1
            new Idioma
            {
                IdIdioma = 3,
                Nome = "Élfico",
                FaladoPor = "Elfos",
                Alfabeto = "Élfico",
                IdTipoIdioma = 1
            },
            //4, Gigante, Ogros e gigantes, Anão, 1
            new Idioma
            {
                IdIdioma = 4,
                Nome = "Gigante",
                FaladoPor = "Ogros, gigantes",
                Alfabeto = "Anão",
                IdTipoIdioma = 1
            },
            //5, Gnômico, Gnomos, Anão, 1
            new Idioma
            {
                IdIdioma = 5,
                Nome = "Gnômico",
                FaladoPor = "Gnomos",
                Alfabeto = "Anão",
                IdTipoIdioma = 1
            },
            //6, Goblin, Goblinoides, Anão, 1
            new Idioma
            {
                IdIdioma = 6,
                Nome = "Goblin",
                FaladoPor = "Goblinoides",
                Alfabeto = "Anão",
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
            //8, Orc, Orcs, Anão, 1
            new Idioma
            {
                IdIdioma = 8,
                Nome = "Orc",
                FaladoPor = "Orcs",
                Alfabeto = "Anão",
                IdTipoIdioma = 1
            },
            //9, Abissal, Demônios, Infernal, 2
            new Idioma
            {
                IdIdioma = 9,
                Nome = "Abissal",
                FaladoPor = "Demônios",
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
            //11, Dialeto Subterrâneo, Devoradores de Mente e Observadores, -, 2
            new Idioma
            {
                IdIdioma = 11,
                Nome = "Dialeto Subterrâneo",
                FaladoPor = "Devoradores de mente, Observadores",
                Alfabeto = "-",
                IdTipoIdioma = 2
            },
            //12, Dracônico, Dragões e Draconatos, Dracônico, 2
            new Idioma
            {
                IdIdioma = 12,
                Nome = "Dracônico",
                FaladoPor = "Dragões, Draconatos",
                Alfabeto = "Dracônico",
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
            //14, Primordial, Elementais, Anão, 2
            new Idioma
            {
                IdIdioma = 14,
                Nome = "Primordial",
                FaladoPor = "Elementais",
                Alfabeto = "Anão",
                IdTipoIdioma = 2
            },
            //15, Silvestre, Criaturas feéricas, Élfico, 2
            new Idioma
            {
                IdIdioma = 15,
                Nome = "Silvestre",
                FaladoPor = "Criaturas feéricas",
                Alfabeto = "Élfico",
                IdTipoIdioma = 2
            },
            //16, Subcomum, Comerciantes do Subterrâneo, Élfico, 2
            new Idioma
            {
                IdIdioma = 16,
                Nome = "Subcomum",
                FaladoPor = "Comerciantes do Subterrâneo",
                Alfabeto = "Élfico",
                IdTipoIdioma = 2
            }
        );
        }
        //IdItem, Nome, Peso, Preco, Descricao
        {
            modelBuilder.Entity<Item>().HasData(
            //1, Ábaco, -, -, -
            new Item
            {
                IdItem = 1,
                Nome = "Ábaco",
                Peso = "1 Kg",
                Preco = "2 Peças de Ouro",
                Descricao = ""
            },
            //2, Ácido (vidro), -, -, -
            new Item
            {
                IdItem = 2,
                Nome = "Ácido (vidro)",
                Peso = "0.5 Kg",
                Preco = "25 Peças de Ouro",
                Descricao = ""
            },
            //3, Água Benta (fresco), -, -, -
            new Item
            {
                IdItem = 3,
                Nome = "Água Benta (frasco)",
                Peso = "0.5 Kg",
                Preco = "25 Peças de Ouro",
                Descricao = "Usando uma ação, você pode espalhar o conteúdo desse frasco em uma criatura a até 1,5 metro de você ou arremessar a até 6 metros, quebrando o frasco com o impacto. Em ambos os casos, você deve realizar um ataque à distância contra uma criatura alvo, tratando a água benta como uma arma improvisada. Se o alvo for um corruptor ou morto-vivo, ele sofre 2d6 de dano radiante. Um clérigo ou paladino pode criar água benta realizando um ritual especial. O ritual leva 1 hora para ser realizado, consome 25 po de prata em pó e exige que se gaste um espaço de magia de 1º nível. "
            },
            //4, Algema, -, -, -
            new Item
            {
                IdItem = 4,
                Nome = "Algemas",
                Peso = "2 Kg",
                Preco = "2 Peças de Ouro",
                Descricao = " Essas algemas de metal podem prender uma criatura Pequena ou Média. Escapar das algemas exige sucesso em um teste de Destreza CD 20. Quebrá-las exige um teste de Força CD 20 bem sucedido. Cada conjunto de algemas vem com uma chave. Sem a chave, uma criatura proficiente com ferramentas de ladrão pode abrir a fechadura das algemas com um sucesso em um teste de Destreza CD 15. As algemas têm 15 pontos de vida. "
            },
            //5, Algibeira, -, -, -
            new Item
            {
                IdItem = 5,
                Nome = "Algibeira",
                Peso = "0.5 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = " Uma bolsa de pano ou couro que pode armazenar até 20 munições de funda ou 50 munições de zarabatana, entre outras coisas. Para armazenar componentes de magia, veja bolsa de componentes, também descrita nessa seção. "
            },
            //6, Aljava, -, -, -
            new Item
            {
                IdItem = 6,
                Nome = "Aljava",
                Peso = "0.5 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = " Uma aljava pode guardar até 20 flechas."
            },
            //7, Ampulheta, -, -, -
            new Item
            {
                IdItem = 7,
                Nome = "Ampulheta",
                Peso = "0.5 Kg",
                Preco = "25 Peças de Ouro",
                Descricao = ""
            },
            //8, Antídoto, -, -, -
            new Item
            {
                IdItem = 8,
                Nome = "Antídoto",
                Peso = "0.5 Kg",
                Preco = "50 Peças de Ouro",
                Descricao = "Uma criatura que beber o líquido desse vidro tem vantagem em testes de resistência contra venenos por 1 hora. O antídoto não confere nenhum benefício para mortos-vivos ou constructos. "
            },
            //9, Apito de advertência, -, -, -
            new Item
            {
                IdItem = 9,
                Nome = "Apito de advertência",
                Peso = "0.5 Kg",
                Preco = "25 Peças de Ouro",
                Descricao = ""
            },
            //10, Aríete portátil, -, -, -
            new Item
            {
                IdItem = 10,
                Nome = "Aríete portátil",
                Peso = "17.5 Kg",
                Preco = "4 Peças de Ouro",
                Descricao = "Você pode usar um aríete portátil para quebrar portas. Ao fazer isso, você ganha um bônus de +4 no teste de Força. Outra criatura pode ajudá-lo a usar o aríete, o que concede vantagem no teste. "
            },
            //11, Armadilha de caça, -, -, -
            new Item
            {
                IdItem = 11,
                Nome = "Armadilha de caça",
                Peso = "12.5 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = "Quando você usa sua ação para armá-la, essa armadilha forma um anel de aço com dentes serrilhados. Eles se fecham quando uma criatura pisa sobre uma placa de pressão no seu centro. A armadilha é fixada por uma pesada corrente em um objeto fixo e imóvel, como uma árvore ou um cravo enterrado no chão. Uma criatura que pisar na placa de pressão deve ser bem sucedida em um teste de resistência de Destreza CD 13 ou sofrerá 1d4 de dano perfurante e para de se mover. Daí em diante, até que a criatura se liberte da armadilha, seu movimento é limitado ao comprimento da corrente (tipicamente 1 metro de comprimento). A criatura presa pode usar sua ação para fazer um teste de Força CD 13 e se libertar, ou outra criatura no alcance pode fazer o teste para libertá-la. Cada fracasso no teste causa 1 de dano perfurante à criatura presa. "
            },
            //12, Arpéu, -, -, -
            new Item
            {
                IdItem = 12,
                Nome = "Arpéu",
                Peso = "2 Kg",
                Preco = "2 Peças de Ouro",
                Descricao = ""
            },
            //13, Balança de mercador, -, -, -
            new Item
            {
                IdItem = 13,
                Nome = "Balança de mercador",
                Peso = "1.5 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = "Trata-se de uma pequena balança, pratos e um sortimento adequado de pesos de até 1 kg. Com ela, você pode medir o peso exato de pequenos objetos, como metais preciosos brutos ou bens comerciais, para ajudar a determinar seu valor. "
            },
            //14, Balde, -, -, -
            new Item
            {
                IdItem = 14,
                Nome = "Balde",
                Peso = "1.5 Kg",
                Preco = "5 Peças de Cobre",
                Descricao = ""
            },
            //15, Barril, -, -, -
            new Item
            {
                IdItem = 15,
                Nome = "Barril",
                Peso = "35 Kg",
                Preco = "2 Peças de Ouro",
                Descricao = ""
            },
            //16, Baú, -, -, -
            new Item
            {
                IdItem = 16,
                Nome = "Baú",
                Peso = "12.5 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //17, Bolsa de componentes, -, -, -
            new Item
            {
                IdItem = 17,
                Nome = "Bolsa de componentes",
                Peso = "1 Kg",
                Preco = "25 Peças de Ouro",
                Descricao = "Trata-se de uma pequena bolsa de couro à prova d'água que pode ser fixada em um cinto. Ela possui compartimentos para armazenar todos os componentes materiais e outros itens especiais que você precisa para lançar suas magias, exceto os componentes que possuem um custo específico (conforme indicado na descrição da magia)."
            },
            //18, Caixa de Fogo, -, -, -
            new Item
            {
                IdItem = 18,
                Nome = "Caixa de Fogo",
                Peso = "0.5 Kg",
                Preco = "5 Peças de Prata",
                Descricao = "Esse pequeno recipiente detém uma pederneira, isqueiro e um pavio (um pano geralmente seco embebido em óleo) usado para acender uma fogueira. Usá-lo para acender uma tocha – ou qualquer outra coisa exposta a um combustível abundante – leva uma ação. Acender qualquer outro fogo leva 1 minuto "
            },
            //19, Caneca, -, -, -
            new Item
            {
                IdItem = 19,
                Nome = "Caneca",
                Peso = "0.5 Kg",
                Preco = "2 Peças de Cobre",
                Descricao = ""
            },
            //20, Caneta Tinteiro, -, -, -
            new Item
            {
                IdItem = 20,
                Nome = "Caneta Tinteiro",
                Peso = "",
                Preco = "2 Peças de Cobre",
                Descricao = ""
            },
            //21, Cantil, -, -, -
            new Item
            {
                IdItem = 21,
                Nome = "Cantil",
                Peso = "2.5 Kg",
                Preco = "2 Peças de Prata",
                Descricao = ""
            },
            //22, Cesto, -, -, -
            new Item
            {
                IdItem = 22,
                Nome = "Cesto",
                Peso = "1 Kg",
                Preco = "4 Peças de Prata",
                Descricao = ""
            },
            //23, Cobertor de inverno, -, -, -
            new Item
            {
                IdItem = 23,
                Nome = "Cobertor de inverno",
                Peso = "1.5 Kg",
                Preco = "5 Peças de Prata",
                Descricao = ""
            },
            //24, Corda de cânhamo (15 metros), -, -, -
            new Item
            {
                IdItem = 24,
                Nome = "Corda de cânhamo (15 metros)",
                Peso = "5 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //25, Corda de seda (15 metros), -, -, -
            new Item
            {
                IdItem = 25,
                Nome = "Corda de seda (15 metros)",
                Peso = "2.5 Kg",
                Preco = "10 Peças de Ouro",
                Descricao = ""
            },
            //26, Corrente (3 metros), -, -, -
            new Item
            {
                IdItem = 26,
                Nome = "Corrente",
                Peso = "5 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //27, Equipamento de pescaria, -, -, -
            new Item
            {
                IdItem = 27,
                Nome = "Equipamento de pescaria",
                Peso = "2 Kg",
                Preco = "1 Peça Ouro",
                Descricao = ""
            },
            //28, Escada (3 metros)
            new Item
            {
                IdItem = 28,
                Nome = "Escadas",
                Peso = "12.5 Kg",
                Preco = "1 Peça Prata",
                Descricao = ""
            },
            //29, Esferas (sacola com 1000)
            new Item
            {
                IdItem = 29,
                Nome = "Esferas (sacola com 1000)",
                Peso = "1 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //30, Espelho de aço
            new Item
            {
                IdItem = 30,
                Nome = "Espelho de aço",
                Peso = "0.25 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //31, Estrepes (bolsa com 20)
            new Item
            {
                IdItem = 31,
                Nome = "Estrepes (bolsa com 20)",
                Peso = "1 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //32 Fechadura
            new Item
            {
                IdItem = 32,
                Nome = "Fechadura",
                Peso = "0.5 Kg",
                Preco = "10 Peças de Ouro",
                Descricao = ""
            },
            //33 Bastão (Foco Arcano)
            new Item
            {
                IdItem = 33,
                Nome = "Bastão",
                Peso = "1 Kg",
                Preco = "10 Peças de Ouro",
                Descricao = ""
            },
            //34, Cajado (Foco Arcano)
            new Item
            {
                IdItem = 34,
                Nome = "Cajado",
                Peso = "2 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //35, Cristal (Foco Arcano)
            new Item
            {
                IdItem = 35,
                Nome = "Cristal",
                Peso = "0.5 Kg",
                Preco = "10 Peças de Ouro",
                Descricao = ""
            },
            //36, Orbe (Foco Arcano)
            new Item
            {
                IdItem = 36,
                Nome = "Orbe",
                Peso = "1.5 Kg",
                Preco = "20 Peças de Ouro",
                Descricao = ""
            },
            //37, Varinha (Foco Arcano)
            new Item
            {
                IdItem = 37,
                Nome = "Varinha",
                Peso = "0.5 Kg",
                Preco = "10 Peças de Ouro",
                Descricao = ""
            },
            //38, Cajado de madeira (Foco Druídico)
            new Item
            {
                IdItem = 38,
                Nome = "Cajado de madeira",
                Peso = "2 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //39, Ramo de visco (Foco Druídico)
            new Item
            {
                IdItem = 39,
                Nome = "Ramo de visco",
                Peso = "-",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //40, Totem (Foco Druídico)
            new Item
            {
                IdItem = 40,
                Nome = "Totem",
                Peso = "-",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //41, Varinha de teixo (Foco Druídico)
            new Item
            {
                IdItem = 41,
                Nome = "Varinha de teixo",
                Peso = "0.5 Kg",
                Preco = "10 Peças de Ouro",
                Descricao = ""
            },
            //42, Fogo alquímico (frasco)
            new Item
            {
                IdItem = 42,
                Nome = "Fogo alquímico (frasco)",
                Peso = "0.5 Kg",
                Preco = "50 Peças de Ouro",
                Descricao = ""
            },
            //43, Frasco
            new Item
            {
                IdItem = 43,
                Nome = "Frasco",
                Peso = "1 Kg",
                Preco = "2 Peças de Cobre",
                Descricao = ""
            },
            //44, Garrafa de vidro
            new Item
            {
                IdItem = 44,
                Nome = "Garrafa de vidro",
                Peso = "1 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //45, Giz (1 peça)
            new Item
            {
                IdItem = 45,
                Nome = "Giz (1 peça)",
                Peso = "-",
                Preco = "1 Peça de Cobre",
                Descricao = ""
            },
            //46, Grimório
            new Item
            {
                IdItem = 46,
                Nome = "Grimório",
                Peso = "1.5 Kg",
                Preco = "50 Peças de Ouro",
                Descricao = ""
            },
            //47, Jarra
            new Item
            {
                IdItem = 47,
                Nome = "Jarra",
                Peso = "2 Kg",
                Preco = "4 Peças de Cobre",
                Descricao = ""
            },
            //48, Kit de escalada
            new Item
            {
                IdItem = 48,
                Nome = "Kit de escalada",
                Peso = "6 Kg",
                Preco = "25 Peças de Ouro",
                Descricao = ""
            },
            //49, Kit de primeiros-socorros
            new Item
            {
                IdItem = 49,
                Nome = "Kit de primeiros-socorros",
                Peso = "1.5 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //50, Lâmpada
            new Item
            {
                IdItem = 50,
                Nome = "Lâmpada",
                Peso = "0.5 Kg",
                Preco = "5 Peças de Prata",
                Descricao = ""
            },
            //51, Lanterna coberta
            new Item
            {
                IdItem = 51,
                Nome = "Lanterna coberta",
                Peso = "1 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //52, Lanterna furta-fogo
            new Item
            {
                IdItem = 52,
                Nome = "Lanterna furta-fogo",
                Peso = "1 Kg",
                Preco = "10 Peças de Ouro",
                Descricao = ""
            },
            //53, Lente de aumento
            new Item
            {
                IdItem = 53,
                Nome = "Lente de aumento",
                Peso = "-",
                Preco = "100 Peças de Ouro",
                Descricao = ""
            },
            //54, Livro
            new Item
            {
                IdItem = 54,
                Nome = "Livro",
                Peso = "2.5 Kg",
                Preco = "25 Peças de Ouro",
                Descricao = ""
            },
            //55, Luneta
            new Item
            {
                IdItem = 55,
                Nome = "Luneta",
                Peso = "0.5 Kg",
                Preco = "1000 Peças de Ouro",
                Descricao = ""
            },
            //56, Manto
            new Item
            {
                IdItem = 56,
                Nome = "Manto",
                Peso = "2 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //57, Marreta
            new Item
            {
                IdItem = 57,
                Nome = "Marreta",
                Peso = "5 Kg",
                Preco = "2 Peças de Ouro",
                Descricao = ""
            },
            //58, Martelo
            new Item
            {
                IdItem = 58,
                Nome = "Martelo",
                Peso = "1.5 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //59, Mochila
            new Item
            {
                IdItem = 59,
                Nome = "Mochila",
                Peso = "2.5 Kg",
                Preco = "2 Peças de Ouro",
                Descricao = ""
            },
            //60 Balas de Funda (20) (Munição)
            new Item
            {
                IdItem = 60,
                Nome = "Balas de Funda (20)",
                Peso = "0.75 Kg",
                Preco = "4 Peças de Cobre",
                Descricao = ""
            },
            //61 Flechas (20) (Munição)
            new Item
            {
                IdItem = 61,
                Nome = "Flechas (20)",
                Peso = "0.5 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //62, Virotes (20) (Munição)
            new Item
            {
                IdItem = 62,
                Nome = "Virotes (20)",
                Peso = "0.75 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //63, Zarabatana (20) (Munição)
            new Item
            {
                IdItem = 63,
                Nome = "Zarabatana (20)",
                Peso = "0.5 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //64, Óleo (frasco)
            new Item
            {
                IdItem = 64,
                Nome = "Óleo (frasco)",
                Peso = "0.5 Kg",
                Preco = "1 Peça de Prata",
                Descricao = ""
            },
            //65, Pá
            new Item
            {
                IdItem = 65,
                Nome = "Pá",
                Peso = "2.5 Kg",
                Preco = "2 Peças de Ouro",
                Descricao = ""
            },
            //66, Panela de Ferro
            new Item
            {
                IdItem = 66,
                Nome = "Panela de Ferro",
                Peso = "5 Kg",
                Preco = "2 Peças de Ouro",
                Descricao = ""
            },
            //67, Papel (uma folha)
            new Item
            {
                IdItem = 67,
                Nome = "Papel (uma folha)",
                Peso = "-",
                Preco = "2 Peças de Prata",
                Descricao = ""
            },
            //68, Parafina
            new Item
            {
                IdItem = 68,
                Nome = "Parafina",
                Peso = "-",
                Preco = "5 Peças de Prata",
                Descricao = ""
            },
            //69, Pé de cabra
            new Item
            {
                IdItem = 69,
                Nome = "Pé de cabra",
                Peso = "2.5 Kg",
                Preco = "2 Peças de Ouro",
                Descricao = ""
            },
            //70, Pedra de amolar
            new Item
            {
                IdItem = 70,
                Nome = "Pedra de amolar",
                Peso = "-",
                Preco = "1 Peça de Cobre",
                Descricao = ""
            },
            //71, Perfume (frasco)
            new Item
            {
                IdItem = 71,
                Nome = "Perfume (frasco)",
                Peso = "-",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //72, Pergaminho (uma folha)
            new Item
            {
                IdItem = 72,
                Nome = "Pergaminho (uma folha",
                Peso = "-",
                Preco = "1 Peça de Prata",
                Descricao = ""
            },
            //73, Picareta de Minerador
            new Item
            {
                IdItem = 73,
                Nome = "Picareta de minerador",
                Peso = "5 Kg",
                Preco = "2 Peças de Ouro",
                Descricao = ""
            },
            //74, Píton
            new Item
            {
                IdItem = 74,
                Nome = "Píton",
                Peso = "-",
                Preco = "5 Peças de Cobre",
                Descricao = ""
            },
            //75, Poção de Cura
            new Item
            {
                IdItem = 75,
                Nome = "Poção de Cura",
                Peso = "0.25 Kg",
                Preco = "50 Peças de Ouro",
                Descricao = ""
            },
            //76, Porta mapas ou pergaminhos
            new Item
            {
                IdItem = 76,
                Nome = "Porta mapas ou pergaminhos",
                Peso = "0.5 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //77, Porta virotes
            new Item
            {
                IdItem = 77,
                Nome = "Porta virotes",
                Peso = "0.5 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //78, Pregos de ferro (10)
            new Item
            {
                IdItem = 78,
                Nome = "Pregos de ferro (10)",
                Peso = "2.5 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //79, Rações de viagem (1 dia)
            new Item
            {
                IdItem = 79,
                Nome = "Rações de viagem (1 dia)",
                Peso = "1 Kg",
                Preco = "5 Peças de Prata",
                Descricao = ""
            },
            //80, Robes
            new Item
            {
                IdItem = 80,
                Nome = "Robes",
                Peso = "2 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //81, Roldana e polia
            new Item
            {
                IdItem = 81,
                Nome = "Roldana e polia",
                Peso = "2.5 Kg",
                Preco = "2 Peças de Ouro",
                Descricao = ""
            },
            //82, Roupas comuns
            new Item
            {
                IdItem = 82,
                Nome = "Roupas comuns",
                Peso = "1.5 Kg",
                Preco = "5 Peças de Prata",
                Descricao = ""
            },
            //83, Roupas de viajante
            new Item
            {
                IdItem = 83,
                Nome = "Roupas de viajante",
                Peso = "2 Kg",
                Preco = "2 Peças de Ouro",
                Descricao = ""
            },
            //84, Roupas de entretenimento
            new Item
            {
                IdItem = 84,
                Nome = "Roupas de entretenimento",
                Peso = "2 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //85, Roupas finas
            new Item
            {
                IdItem = 85,
                Nome = "Roupas finas",
                Peso = "3 Kg",
                Preco = "15 Peças de Ouro",
                Descricao = ""
            },
            //86, Sabão
            new Item
            {
                IdItem = 86,
                Nome = "Sabão",
                Peso = "-",
                Preco = "1 Peças de Cobre",
                Descricao = ""
            },
            //87, Saco
            new Item
            {
                IdItem = 87,
                Nome = "Saco",
                Peso = "0.25 Kg",
                Preco = "1 Peça de Cobre",
                Descricao = ""
            },
            //88, Saco de dormir
            new Item
            {
                IdItem = 88,
                Nome = "Saco de dormir",
                Peso = "3.5 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //89, Amuleto (Símbolo Sagrado)
            new Item
            {
                IdItem = 89,
                Nome = "Amuleto",
                Peso = "0.5 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //90 Emblema (Símbolo Sagrado)
            new Item
            {
                IdItem = 90,
                Nome = "Emblema",
                Peso = "-",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //91 Relicário (Símbolo Sagrado)
            new Item
            {
                IdItem = 91,
                Nome = "Relicário",
                Peso = "1 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //92, Sinete
            new Item
            {
                IdItem = 92,
                Nome = "Sinete",
                Peso = "-",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //93, Sino
            new Item
            {
                IdItem = 93,
                Nome = "Sino",
                Peso = "-",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //94, Tenda para duas pessoas
            new Item
            {
                IdItem = 94,
                Nome = "Tenda para duas pessoas",
                Peso = "10 Kg",
                Preco = "2 Peças de Ouro",
                Descricao = ""
            },
            //95, Tocha
            new Item
            {
                IdItem = 95,
                Nome = "Tocha",
                Peso = "0.5 Kg",
                Preco = "1 Peça de Cobre",
                Descricao = ""
            },
            //96, Tinta (frasco de 30ml)
            new Item
            {
                IdItem = 96,
                Nome = "Tinta (frasco de 30 ml)",
                Peso = "-",
                Preco = "10 Peças de Ouro",
                Descricao = ""
            },
            //97, Vara (3 metros)
            new Item
            {
                IdItem = 97,
                Nome = "Vara (3 metros)",
                Peso = "3.5 Kg",
                Preco = "5 Peças de Cobre",
                Descricao = ""
            },
            //98, Vela
            new Item
            {
                IdItem = 98,
                Nome = "Vela",
                Peso = "-",
                Preco = "1 Peça de Cobre",
                Descricao = ""
            },
            //99, Veneno básico (frasco)
            new Item
            {
                IdItem = 99,
                Nome = "Veneno básico (frasco)",
                Peso = "-",
                Preco = "100 Peças de Ouro",
                Descricao = ""
            },
            //100, Ferramentas de carpinteiro
            new Item
            {
                IdItem = 100,
                Nome = "Ferramentas de carpinteiro",
                Peso = "3 Kg",
                Preco = "8 Peças de Ouro",
                Descricao = ""
            },
            //101, Ferramentas de cartógrafo
            new Item
            {
                IdItem = 101,
                Nome = "Ferramentas de cartógrafo",
                Peso = "3 Kg",
                Preco = "15 Peças de Ouro",
                Descricao = ""
            },
            //102, Ferramentas de costureiro
            new Item
            {
                IdItem = 102,
                Nome = "Ferramentas de costureiro",
                Peso = "2.5 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //103, Ferramentas de entalhador
            new Item
            {
                IdItem = 103,
                Nome = "Ferramentas de entalhador",
                Peso = "2.5 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //104, Ferramentas de ferreiro
            new Item
            {
                IdItem = 104,
                Nome = "Ferramentas de ferreiro",
                Peso = "4 Kg",
                Preco = "20 Peças de Ouro",
                Descricao = ""
            },
            //105, Ferramentas de funileiro
            new Item
            {
                IdItem = 105,
                Nome = "Ferramentas de funileiro",
                Peso = "5 Kg",
                Preco = "50 Peças de Ouro",
                Descricao = ""
            },
            //106, Ferramentas de joalheiro
            new Item
            {
                IdItem = 106,
                Nome = "Ferramentas de joalheiro",
                Peso = "1 Kg",
                Preco = "25 Peças de Ouro",
                Descricao = ""
            },
            //107, Ferramentas de oleiro
            new Item
            {
                IdItem = 107,
                Nome = "Ferramentas de oleiro",
                Peso = "1.5 Kg",
                Preco = "10 Peças de Ouro",
                Descricao = ""
            },
            //108, Ferramentas de pedreiro
            new Item
            {
                IdItem = 108,
                Nome = "Ferramentas de pedreiro",
                Peso = "4 Kg",
                Preco = "10 Peças de Ouro",
                Descricao = ""
            },
            //109, Ferramentas de pintor
            new Item
            {
                IdItem = 109,
                Nome = "Ferramentas de pintor",
                Peso = "2.5 Kg",
                Preco = "10 Peças de Ouro",
                Descricao = ""
            },
            //110, Ferramentas de sapaterio
            new Item
            {
                IdItem = 110,
                Nome = "Ferramentas de sapateiro",
                Peso = "2.5 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //111, Ferramentas de vidreiro
            new Item
            {
                IdItem = 111,
                Nome = "Ferramentas de vidreiro",
                Peso = "2.5 Kg",
                Preco = "30 Peças de Ouro",
                Descricao = ""
            },
            //112, Suprimentos de alquimista
            new Item
            {
                IdItem = 112,
                Nome = "Suprimentos de alquimista",
                Peso = "4 Kg",
                Preco = "50 Peças de Ouro",
                Descricao = ""
            },
            //113, Supreimentos de cervejeiro
            new Item
            {
                IdItem = 113,
                Nome = "Suprimentos de cervejeiro",
                Peso = "4.5 Kg",
                Preco = "20 Peças de Ouro",
                Descricao = ""
            },
            //114, Suprimentos de caligrafia
            new Item
            {
                IdItem = 114,
                Nome = "Suprimentos de caligrafia",
                Peso = "2.5 Kg",
                Preco = "10 Peças de Ouro",
                Descricao = ""
            },
            //115, Utensílios de cozinheiro(Ferramentas de artesão)
            new Item
            {
                IdItem = 115,
                Nome = "Utensílios de cozinheiro",
                Peso = "4 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //116, Ferramentas de navegação
            new Item
            {
                IdItem = 116,
                Nome = "Ferramentas de navegação",
                Peso = "1 Kg",
                Preco = "25 Peças de Ouro",
                Descricao = ""
            },
            //117, Ferramentas de ladrão
            new Item
            {
                IdItem = 117,
                Nome = "Ferramentas de ladrão",
                Peso = "0.5 Kg",
                Preco = "25 Peças de Ouro",
                Descricao = ""
            },
            //118, Alaúde (Instrumento musical)
            new Item
            {
                IdItem = 118,
                Nome = "Alaúde",
                Peso = "1 Kg",
                Preco = "35 Peças de Ouro",
                Descricao = ""
            },
            //119, Flauta (Instrumento musical)
            new Item
            {
                IdItem = 119,
                Nome = "Flauta",
                Peso = "0.5 Kg",
                Preco = "2 Peças de Ouro",
                Descricao = ""
            },
            //120, Flauta de pã (Instrumento musical)
            new Item
            {
                IdItem = 120,
                Nome = "Flauta de pã",
                Peso = "1 Kg",
                Preco = "12 Peças de Ouro",
                Descricao = ""
            },
            //121, Gaita de foles (Instrumento musical)
            new Item
            {
                IdItem = 121,
                Nome = "Gaita de foles",
                Peso = "3 Kg",
                Preco = "30 Peças de Ouro",
                Descricao = ""
            },
            //122, Lira (Instrumento musical)
            new Item
            {
                IdItem = 122,
                Nome = "Lira",
                Peso = "1 Kg",
                Preco = "30 Peças de Ouro",
                Descricao = ""
            },
            //123, Oboé (Instrumento musical)
            new Item
            {
                IdItem = 123,
                Nome = "Oboé",
                Peso = "0.5 Kg",
                Preco = "2 Peças de Ouro",
                Descricao = ""
            },
            //124, Tambor (Instrumento musical)
            new Item
            {
                IdItem = 124,
                Nome = "Tambor",
                Peso = "1.5 Kg",
                Preco = "6 Peças de Ouro",
                Descricao = ""
            },
            //125, Trombeta (Instrumento musical)
            new Item
            {
                IdItem = 125,
                Nome = "Trombeta",
                Peso = "1 Kg",
                Preco = "3 Peças de Ouro",
                Descricao = ""
            },
            //126, Violino (Instrumento musical)
            new Item
            {
                IdItem = 126,
                Nome = "Violino",
                Peso = "3 Kg",
                Preco = "30 Peças de Ouro",
                Descricao = ""
            },
            //127, Xilofone (Instrumento musical)
            new Item
            {
                IdItem = 127,
                Nome = "Xilofone",
                Peso = "5 Kg",
                Preco = "25 Peças de Ouro",
                Descricao = ""
            },
            //128, Kit de disfarce
            new Item
            {
                IdItem = 128,
                Nome = "Kit de disfarce",
                Peso = "1.5 Kg",
                Preco = "25 Peças de Ouro",
                Descricao = ""
            },
            //129, Kit de falsificação
            new Item
            {
                IdItem = 129,
                Nome = "Kit de falsificação",
                Peso = "2.5 Kg",
                Preco = "15 Peças de Ouro",
                Descricao = ""
            },
            //130, Kit de herbalismo
            new Item
            {
                IdItem = 130,
                Nome = "Kit de herbalismo",
                Peso = "1.5 Kg",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //131, Baralho de cartas (Kit de jogo)
            new Item
            {
                IdItem = 131,
                Nome = "Baralho de cartas",
                Peso = "-",
                Preco = "5 Peças de Prata",
                Descricao = ""
            },
            //132, Conjunto de dados (Kit de jogo)
            new Item
            {
                IdItem = 132,
                Nome = "Conjunto de dados",
                Peso = "-",
                Preco = "1 Peça de Prata",
                Descricao = ""
            },
            //133, Jogo dos três dragões (Kit de jogo)
            new Item
            {
                IdItem = 133,
                Nome = "Jogo dos três dragões",
                Peso = "-",
                Preco = "5 Peças de Ouro",
                Descricao = ""
            },
            //134, Xadrez do dragão (Kit de jogo)
            new Item
            {
                IdItem = 134,
                Nome = "Xadrez do dragão",
                Peso = "0.25 Kg",
                Preco = "1 Peça de Ouro",
                Descricao = ""
            },
            //135, Kit de venenos
            new Item
            {
                IdItem = 135,
                Nome = "Kit de venenos",
                Peso = "1 Kg",
                Preco = "50 Peças de Ouro",
                Descricao = ""
            },
            //136, Pacote de Artista
            new Item
            {
                IdItem = 136,
                Nome = "Pacote de Artista",
                Peso = "-",
                Preco = "40 Peças de Ouro",
                Descricao = "Mochila; saco de dormir; duas fantasias; 5 velas; 5 dias de rações; cantil; kit de disfarce"
            },
            //137, Pacote de Assaltante
            new Item
            {
                IdItem = 137,
                Nome = "Pacote de Assaltante",
                Peso = "-",
                Preco = "16 Peças de Ouro",
                Descricao = "Mochila; saco com 1000 esferas de metal; 3 metros de linha; sino; 5 velas; pé de cabra; martelo; 10 pítons; lanterna coberta; 2 fascos de óleo; 5 dias de ração; caixa de fogo; cantil; 15 metros de corda de cânhamo"
            },
            //138, Pacote de Aventureiro
            new Item
            {
                IdItem = 138,
                Nome = "Pacote de Aventureiro",
                Peso = "-",
                Preco = "12 Peças de Ouro",
                Descricao = "Mochila; pé de cabra; martelo; 10 pítons; 10 tochas; caixa de fogo; 10 dias de rações; cantil; 15 metros de corda de cânhamo"
            },
            //139, Pacote de Diplomata
            new Item
            {
                IdItem = 139,
                Nome = "Pacote de Diplomata",
                Peso = "-",
                Preco = "39 Peças de Ouro",
                Descricao = "Baú; 2 caixas para mapas ou pergaminhos; conjunto de roupas finas; vidro de tinta; caneta tinteiro; lâmpada; 2 frascos de óleo; 5 folhas de papel; vidro de perfume; parafina; sabão"
            },
            //140, Pacote de Estudioso
            new Item
            {
                IdItem = 140,
                Nome = "Pacote de Estudioso",
                Peso = "-",
                Preco = "40 Peças de Ouro",
                Descricao = "Mochila; livro de estudo; vidro de tinta; caneta tinteiro; 10 folhas de pergaminho; saquinho de areia; pequena faca"
            },
            //141, Pacote de Explorador
            new Item
            {
                IdItem = 141,
                Nome = "Pacote de Explorador",
                Peso = "-",
                Preco = "10 Peças de Ouro",
                Descricao = "Mochila; saco de dormir; kit de refeição; caixa de fogo; 10 tochas; 10 dias de rações; cantil; 15 metros de corda de cânhamo"
            },
            //142, Pacote de Sacerdote
            new Item
            {
                IdItem = 142,
                Nome = "Pacote de Sacerdote",
                Peso = "-",
                Preco = "19 Peças de Ouro",
                Descricao = "Mochila; cobertor; 10 velas; caixa de fogo; caixa de esmola; 2 blocos de incenso; incensário; vestes; 2 dias de rações; cantil"
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
                Nome = "Acalmar Emoções",
                Escola = "Encantamento",
                Alcance = "18 metros",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 minuto",
                Componente = "Verbal, Somático",
                Descricao = "Você tenta suprimir emoções fortes em um grupo de pessoas.Cada humanoide em uma esfera de 6 metros de raio, centrada em um ponto que você escolher dentro do alcance, deve realizar um teste de resistência de Carisma; uma criatura pode escolher falhar nesse teste, se desejar. Se uma criatura falhar na resistência, escolha um dentre os dois efeitos a seguir. Você pode suprimir qualquer efeito que esteja deixando a criatura enfeitiçada ou amedrontada.Quando essa magia terminar, qualquer efeito suprimido volta a funcionar, considerando que sua duração não tenha acabado nesse meio tempo. Alternativamente, você pode tornar um alvo indiferente às criaturas que você escolher que forem hostis a ele. Essa indiferença acaba se o alvo for atacado ou ferido por uma magia ou se ele testemunhar qualquer dos seus amigos sendo ferido.Quando a magia terminar, a criatura se tornará hostil novamente, a não ser que o Mestre diga o contrário. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 2,
                Nome = "Adivinhação",
                Escola = "Adivinhação (ritual)",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 ação",
                Duracao = "Instantânea",
                Componente = "Verbal, Somático, Material  (incenso e uma oferenda apropriada para sacrifício à sua religião, juntos valendo, no mínimo, 25 po, consumidos pela magia)",
                Descricao = "Sua magia e uma oferenda colocam você em contato com um deus ou servo divino. Você faz uma única pergunta a respeito de um objetivo, evento ou atividade específico que irá ocorrer dentro de 7 dias. O Mestre oferece uma resposta confiável. A resposta deve ser uma frase curta, uma rima enigmática ou um presságio. A magia não leva em consideração qualquer possível circunstância que possa mudar o que está por vir, como a conjuração de magias adicionais ou a perda ou ganho de um companheiro. Se você conjurar a magia duas ou mais vezes antes de completar seu próximo descanso longo, existe uma chance cumulativa de 25 por cento de cada conjuração, depois da primeira que você fez, ter um resultado aleatório. O Mestre faz essa jogada secretamente. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 3,
                Nome = "Ajuda",
                Escola = "Abjuração",
                Alcance = "9 metros",
                TempodeConjuracao = "1 ação",
                Duracao = "8 horas",
                Componente = "Verbal, Somático, Material  (uma pequena fita de tecido branco)",
                Descricao = "Sua magia inspira seus aliados com vigor e determinação. Escolha até três criaturas dentro do alcance. O máximo de pontos de vida e os pontos de vida atuais de cada alvo aumentam em 5, pela duração. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 3° nível ou superior, os pontos de vida dos alvos aumentam em 5 pontos adicionais para cada nível do espaço acima do o 2°. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 4,
                Nome = "Alarme",
                Escola = "Abjuração (ritual)",
                Alcance = "9 metros",
                TempodeConjuracao = "1 minuto",
                Duracao = "8 horas",
                Componente = "Verbal, Somático, Material (um pequeno sino e um pequeno fio de prata) ",
                Descricao = "Você coloca um alarme para intrusos desavisados. Escolha uma porta, uma janela ou uma área dentro do alcance que não seja maior que 6 metros cúbicos. Até a magia acabar, um alarme alerta você sempre que uma criatura Miúda ou maior tocarem ou entrarem na área protegida. Quando você conjura a magia, você pode designar as criaturas que não ativarão o alarme. Você também escolhe se o alarme será mental ou audível. Um alarme mental alerta você com um silvo na sua mente, se você estiver a até de 1,5 quilômetro da área protegida. Esse silvo acordará você se você estiver dormindo. Um alarme audível produz o som de um sino de mão por 10 minutos num raio de 18 metros.",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 5,
                Nome = "Aliado Planar",
                Escola = "Conjuração",
                Alcance = "18 metros",
                TempodeConjuracao = "10 minutos",
                Duracao = "Instantânea",
                Componente = "Verbal, Somático",
                Descricao = "Você suplica a uma entidade transcendental por ajuda. O ser deve ser conhecido por você: seu deus, um primordial, um príncipe demônio ou algum outro ser de poder cósmico. Essa entidade envia um celestial, um corruptor ou um elemental leal a ela para ajudar você, fazendo a criatura aparecer em um espaço desocupado dentro do alcance. Se você conhecer o nome de uma criatura especifica, você pode falar o nome quando conjurar essa magia para requisitar essa criatura, do contrário, você pode receber uma criatura diferente de qualquer forma (à escolha do Mestre). Quando a criatura aparecer, ela não está sob nenhuma compulsão para se comportar de um modo em particular. Você pode pedir a criatura que realize um serviço em troca de um pagamento, mas ela não é obrigada a fazê-lo. A tarefa solicitada pode variar de simples (carregue-nos voando para o outro lado do abismo ou nos ajude a lutar essa batalha) a complexa (espione nossos inimigos ou nos proteja durante nossa incursão na masmorra). Você deve ser capaz de se comunicar com a criatura para barganhar os serviços dela. O pagamento pode ser feito de várias formas. Um celestial pode requerer uma generosa doação de ouro ou itens mágicos para um templo aliado, enquanto que um corruptor pode exigir um sacrifício vivo ou uma parte dos espólios. Algumas criaturas podem trocar seus serviços por uma missão feita por você. Como regra geral, uma tarefa que possa ser medida em minutos, exigirá um pagamento de 100 po por minuto. Uma tarefa medida em horas exigirá 1.000 po por hora. E uma tarefa medida em dias (até 10 dias) exigirá 10.000 po por dia. O Mestre pode ajustar esses pagamentos baseado nas circunstâncias pelas quais a magia foi conjurada. Se a tarefa estiver de acordo com o caráter da criatura, o pagamento pode ser reduzido à metade, ou mesmo dispensado. Tarefas que não proporcionem perigo, tipicamente requerem apenas metade do pagamento sugerido, enquanto que tarefas especialmente perigosas podem exigir um grande presente. As criaturas raramente aceitarão tarefas que pareçam suicidas. Após a criatura completar a tarefa ou quando a duração acordada para o serviço expirar, a criatura retornará para seu plano natal depois de relatar sua partida a você, se apropriado para a tarefa e se possível. Se você não for capaz de acertar um preço para os serviços da criatura, ela imediatamente voltará para o seu plano natal. Uma criatura convidada para se juntar ao seu grupo, conta como um membro dele, recebendo sua parte total na premiação de pontos de experiência. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 6,
                Nome = "Aljava Veloz",
                Escola = "Transmutação",
                Alcance = "Toque",
                TempodeConjuracao = "1 ação bônus",
                Duracao = "Concentração, até 1 minuto",
                Componente = "V, S, M (uma aljava contendo, pelo menos, uma munição)",
                Descricao = "Você transmuta sua aljava para que ela produza um suprimento interminável de munições não-mágicas, que parecem saltar na sua mão quando você tenta pega-las. Em cada um dos seus turnos, até a magia acabar, você pode usar uma ação bônus para realizar dois ataques com uma arma que use munição de uma aljava. Cada vez que você fizer tais ataques à distância, sua aljava, magicamente, repõe a munição que você usou com uma munição não-mágica similar. Qualquer munição criada por essa magia se desintegra quando a magia acaba. Se a aljava não estiver mais com você, a magia acaba.",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 7,
                Nome = "Alterar Forma",
                Escola = "Transmutação",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 hora",
                Componente = "V, S, M (uma argola de jade valendo, no mínimo, 1.500 po, que você deve colocar na sua cabeça antes de conjurar a magia) ",
                Descricao = "Você assume a forma de uma criatura diferente, pela duração. A nova forma pode ser qualquer criatura com um nível de desafio igual ao seu nível ou menor. A criatura não pode ser nem um constructo nem um mortovivo e você deve ter visto esse tipo de criatura pelo menos uma vez. Você se transforma num exemplar médio da criatura, um sem quaisquer níveis de classe nem característica Conjuração. Suas estatísticas de jogo são substituídas pelas estatísticas da forma escolhida, no entanto, você mantém sua tendência e valores de Inteligência, Sabedoria e Carisma. Você também mantem suas proficiências em testes de resistência, além de ganhar as da nova criatura. Se a criatura tiver a mesma proficiência que você e o bônus listado nas estatísticas dela for maior que o seu, use os bônus da criatura no lugar do seu. Você não pode usar qualquer ação lendária ou de covil da nova forma. Você assume os pontos de vida e Dados de Vida da sua nova forma. Quando você reverter a sua forma normal, você retorna à quantidade de pontos de vida que tinha antes da transformação. Se você reverter como resultado de ter caído a 0 pontos de vida, qualquer dano excedente é recebido pela sua forma normal. Contanto que o dano excedente não reduza os pontos de vida da sua forma normal a 0, você não cairá inconsciente. Você mantem os benefícios de qualquer característica da sua classe, raça ou outra fonte e pode usa-las, considerando que sua nova forma é fisicamente capaz de fazê-lo. Você não pode usar quaisquer sentidos especiais que você possua (por exemplo, visão no escuro) a não ser que a nova forma também possua o sentido. Você só poderá falar se a nova forma, normalmente, puder falar. Quando você se transforma, você pode escolher se o seu equipamento cai no chão, é assimilado a sua nova forma ou é usado por ela. Equipamentos vestidos e carregados funcionam normalmente. O Mestre decide qual equipamento é viável para a nova forma vestir ou  sar, baseado na forma e tamanho da criatura. O seu equipamento não muda de forma ou tamanho para se adaptar à nova forma e, qualquer equipamento que a nova forma não possa vestir deve, ou cair no chão ou ser assimilado por ela. Equipamentos assimilados não terão efeito nesse estado. Pela duração da magia, você pode usar sua ação para assumir uma forma diferente, seguindo as mesmas restrições e regras da forma anterior, com uma exceção: se sua nova forma tiver mais pontos de vida que sua forma atual, seus pontos de vida mantem o valor atual. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 8,
                Nome = "Alterar-se",
                Escola = "Transmutação",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 hora",
                Componente = "V, S",
                Descricao = "Você assume uma forma diferente. Quando conjurar essa magia, escolha uma das seguintes opções, o efeito durará pela duração da magia. Enquanto a magia durar, você pode terminar uma opção com uma ação para ganhar os benefícios de uma diferente. Adaptação Aquática. Você adapta seu corpo para um ambiente aquático, brotando guelras e crescendo membranas entre seus dedos. Você pode respirar embaixo d’água e ganha deslocamento de natação igual a seu deslocamento terrestre. Mudar Aparência. Você transforam sua aparência. Você decide com o que você parece, incluindo altura, peso, traços faciais, timbre da sua voz, comprimento do cabelo, coloração e características distintas, se tiverem. Você pode ficar parecido com um membro de outra raça, apesar de nenhuma de suas estatísticas mudar. Você também não pode parecer com uma criatura de um tamanho diferente do seu, e seu formado básico permanece o mesmo; se você for bípede, você não pode usar essa magia para se tornar quadrupede, por exemplo. A qualquer momento, pela duração da magia, você pode usar sua ação para mudar sua aparência dessa forma, novamente. Armas Naturais. Você faz crescerem garras, presas, espinhos, chifres ou armas naturais diferentes, à sua escolha. Seus ataques desarmados causam 1d6 de dano de concussão, perfurante ou cortante, como apropriado para a arma natural que você escolheu, e você é proficiente com seus ataques desarmados. Finalmente, a arma natural é mágica e você tem +1 de bônus nas jogadas de ataque e dano que você fizer com ela. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 9,
                Nome = "Amizade",
                Escola = "Encantamento",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 minuto",
                Componente = "S, M (uma pequena quantidade de maquiagem aplicada ao rosto durante a conjuração da magia) ",
                Descricao = "Pela duração, você terá vantagem em todos os testes de Carisma direcionados a uma criatura, à sua escolha, que não seja hostil a você. Quando a magia acabar, a criatura perceberá que você usou maia para influenciar o humor dela, e ficará hostil a você. Uma criatura propensa a violência irá atacar você. Outra criatura pode buscar outras formas de retaliação (a critério do Mestre), dependendo da natureza da sua interação com ela.",
                IdTipoMagia = 1
            },
            new Magia
            {
                IdMagia = 10,
                Nome = "Amizade Animal",
                Escola = "Encantamento",
                Alcance = "9 metros",
                TempodeConjuracao = "1 ação",
                Duracao = "24 horas",
                Componente = "V, S, M (um punhado de comida)",
                Descricao = "Essa magia deixa você convencer uma besta que você não quer prejudicar. Escolha uma besta que você possa ver dentro do alcance. Ela deve ver e ouvir você. Se a Inteligência da besta for 4 ou maior, a magia falha. Do contrário, a besta deve ser bem sucedida num teste de resistência de Sabedoria ou ficará enfeitiçada por você pela duração da magia. Se você ou um dos seus companheiros ferir o alvo, a magia termina. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 2° nível ou superior, você pode afetar uma besta adicional para cada nível do espaço acima do 1°. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 11,
                Nome = "Ampliar Plantas",
                Escola = "Transmutação",
                Alcance = "45 metros",
                TempodeConjuracao = "1 ação ou 8 horas",
                Duracao = "Instantânea",
                Componente = "V, S",
                Descricao = "Essa magia canaliza vitalidade nas plantas dentro de uma área especifica. Existem dois usos possíveis para essa magia, concedendo ou benefícios imediatos ou a longo prazo. Se você conjurar essa magia usando 1 ação, escolha um ponto dentro do alcance. Todas as plantas normais num raio de 30 metros centrado no ponto, tornam-se espessas e carregadas. Uma criatura se movendo na área deve gastar 6 metros de movimento para cada 1,5 metro que se mover. Você pode excluir uma ou mais áreas de qualquer tamanho, dentro da área da magia, para não ser afetada. Se você conjurar essa magia ao longo de 8 horas, você fertiliza a terra. Todas as plantas num raio de 800 metros, centrado no ponto dentro do alcance, ficam enriquecidas por 1 ano. As plantas fornecerão o dobro da quantidade normal de comida quando colhidas. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 12,
                Nome = "Âncora Planar",
                Escola = "Abjuração",
                Alcance = "18 metros",
                TempodeConjuracao = "1 hora",
                Duracao = "24 horas",
                Componente = "V, S, M (uma joia valendo, no mínimo, 1.000 po, consumida pela magia)",
                Descricao = "Com essa magia, você tenta obrigar um celestial, corruptor, elemental ou fada a servi-lo. A criatura deve estar dentro do alcance durante toda a conjuração da magia. (Tipicamente, a criatura, primeiramente, é invocada dentro de um círculo mágico invertido para mantê-la presa enquanto a magia é conjurada.) Ao completar a conjuração, o alvo deve realizar um teste de resistência de Carisma. Se falhar na resistência, ela é obrigada a servir você pela duração. Se a criatura foi invocada ou criada por outra magia, a duração da magia é estendida para se equiparar a dessa magia. Uma criatura obrigada deve seguir suas instruções da melhor forma que puder. Você poderia comandar a criatura a acompanhar você em uma aventura, a guardar um local ou a enviar uma mensagem. A criatura obedece ao pé da letra suas instruções, mas se a criatura for hostil a você, ela se esforçará para distorcer suas palavras para atingir seus próprios objetivos. Se a criatura atender suas instruções completamente antes da magia acabar, ela viajará até você para relatar esse fato se você estiver no mesmo plano de existência. Se você estiver em um plano de existência diferente, ela retornará para o lugar onde você a contatou e permanecerá lá até a magia acabar. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de nível superior, a duração aumenta para 10 dias com um espaço de 6° nível, para 30 dias com um espaço de 7° nível, para 180 dias com um espaço de 8° nível e para um ano com um espaço de magia de 9° nível. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 13,
                Nome = "Andar na Água",
                Escola = "Transmutação",
                Alcance = "9 metros",
                TempodeConjuracao = "1 ação",
                Duracao = "1 hora",
                Componente = "V, S, M (uma rolha)",
                Descricao = "Essa magia concede a habilidade de se mover através de qualquer superfície líquida – como água, ácido, lama, neve, arreia movediça ou lava – como se ela fosse chão sólido inofensivo (as criaturas atravessando lava derretida ainda podem sofrer dano do calor). Até dez criaturas voluntárias que você possa ver, dentro do alcance, ganham essa habilidade pela duração. Se você afetar uma criatura submersa em um líquido, a magia ergue o alvo para a superfície do líquido a uma taxa de 18 metros por rodada. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 14,
                Nome = "Animar Mortos",
                Escola = "Necromancia",
                Alcance = "3 metros",
                TempodeConjuracao = "1 minuto",
                Duracao = "Instantânea",
                Componente = " V, S, M (uma gota de sangue, um pedaço de carne e um punhado de pó de osso)",
                Descricao = "Essa magia cria um servo morto-vivo. Escolha uma pilha de ossos ou um corpo de um humanoide Médio ou Pequeno dentro do alcance. Sua magia imbui o alvo com uma imitação corrompida de vida, erguendo-o como uma criatura morta-viva. O alvo se torna um esqueleto, se você escolheu ossos, ou um zumbi, se você escolheu um corpo (o Mestre tem as estatísticas de jogo da criatura). Em cada um dos seus turnos, você pode usar uma ação bônus para comandar mentalmente qualquer criatura que você criou com essa magia, se a criatura estiver a até 18 metros de você (se você controla diversas criaturas, você pode comandar qualquer uma ou todas elas ao mesmo tempo, emitindo o mesmo comando para cada uma). Você decide qual ação a criatura irá fazer e para onde ela irá se mover durante o próximo turno dela, ou você pode emitir um comando geral, como para guardar uma câmara ou corredor especifico. Se você não der nenhum comando, as criaturas apenas se defenderão contra criaturas hostis. Uma vez que receba uma ordem, a criatura continuará a segui-la até a tarefa estar concluída. A criatura fica sob seu controle por 24 horas, depois disso ela para de obedecer aos seus comandos. Para 218 manter o controle da criatura por mais 24 horas, você deve conjurar essa magia na criatura novamente, antes das 24 horas atuais terminarem. Esse uso da magia recupera seu controle sobre até quatro criaturas que você tenha animado com essa magia, ao invés de animar uma nova. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 4° nível ou superior, você pode animar ou recuperar o controle de duas criaturas mortas-vivas para cada nível do espaço acima do 3°. Cada uma dessas criaturas deve vir de um corpo ou pilha de ossos diferente. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 15,
                Nome = "Animar Objetos",
                Escola = "Transmutação",
                Alcance = "36 metros",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 minuto",
                Componente = "V, S",
                Descricao = "Objetos ganham vida ao seu comando. Escolha até dez objetos não-mágicos dentro do alcance, que não estejam sendo vestidos ou carregados. Alvos Médios contam como dois objetos, alvos Grandes contam como quatro objetos e alvos Enormes contam como oito objetos. Você não pode animar um objeto maior que Enorme. Cada alvo se anima e torna-se uma criatura sob seu controle até o final da magia ou até ser reduzido a 0 pontos de vida. Com uma ação bônus, você pode comandar mentalmente qualquer criatura que você criar com essa magia se a criatura estiver a até 150 metros de você (se você controla várias criaturas, você pode comandar qualquer ou todas elas ao mesmo tempo, emitindo o mesmo comando para cada uma). Você decide qual ação a criatura irá fazer e para onde ela irá se mover durante o próximo turno dela, ou você pode emitir um comando geral, como para guardar uma câmara ou corredor especifico. Se você não der nenhum comando, as criaturas apenas se defenderão contra criaturas hostis. Uma vez que receba uma ordem, a criatura continuará a segui-la até a tarefa estar concluída. Um objeto animado é um constructo com CA, pontos de vida, ataques, Força e Destreza determinados pelo seu tamanho. Sua Constituição é 10 e sua Inteligência e Sabedoria são 3 e seu Carisma é 1. Seu deslocamento é 9 metros; se o objeto não tiver pernas ou outros apêndices que ele possa usar para locomoção, ao invés, ele terá deslocamento de voo 9 metros e poderá planar. Se o objeto estiver firmemente preso a uma superfície ou objeto maior, como uma corrente presa a uma parede, seu deslocamento será 0. Ele tem percepção às cegas num raio de 9 metros e é cego além dessa distância. Quando o objeto animado cair a 0 pontos de vida, ele reverte a sua forma normal de objeto e qualquer dano restante é transferido para sua forma de objeto original. Se você ordenar a um objeto que ataque, ele pode realizar um único ataque corpo-a-corpo contra uma criatura a até 1,5 metro dele. Ele realiza um ataque de pancada com um bônus de ataque e dano de concussão determinado pelo seu tamanho. O Mestre pode definir que um objeto especifico inflige dano cortante ou perfurante, baseado na forma dele. Em Níveis Superiores. Se você conjurar essa magia usando um espaço de magia de 6° nível ou superior, você pode animar dois objetos adicionais para cada nível do espaço acima do 5°. ",
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
                Componente = "Componentes: V, S, M (ou um pedaço de alume embebido em vinagre para o efeito de antipatia, ou uma gota de mel para o efeito de simpatia) ",
                Descricao = "Essa magia atrai ou repele as criaturas de sua escolha. Você escolhe um alvo dentro do alcance, tanto um objeto ou criatura Enorme ou menor ou uma área que não seja maior que 60 metros cúbicos. Então, especifica um tipo de criatura inteligente, como dragões vermelhos, goblins ou vampiros. Você envolve o alvo com uma aura que pode atrair ou repelir as criaturas especificas pela duração. Escolha antipatia ou simpatia como efeito da aura. Antipatia. O encantamento faz com que criaturas do tipo designado por você sintam-se fortemente impelidos em deixar a área e evitar o alvo. Quando uma dessas criaturas puder ver o alvo ou ficar a 18 metros dele, a criatura deve ser bem sucedida num teste de resistência de Sabedoria ou ficará amedrontada. A criatura continuará amedrontada enquanto puder ver o alvo ou permanecer a 18 metros dele. Enquanto estiver amedrontada pelo alvo, a criatura deve usar seu deslocamento para se mover para o local seguro mais próximo o qual ela não possa ver o alvo. Se a criatura se mover para mais de 18 metros do alvo e não puder vê-lo, a criatura não estará mais amedrontada, mas ela ficará amedrontada novamente se voltar a ver o alvo ou ficar a 18 metros dele. Simpatia. O encantamento faz com que as criaturas especificadas sintam-se fortemente impelidos a se aproximar do alvo enquanto estiverem a 18 metros dele ou puderem vê-lo. Quando uma dessas criaturas puder ver o alvo ou ficar a 18 metros dele, a criatura deve ser bem sucedida num teste de resistência de Vontade ou usará seu deslocamento em cada um dos seus turnos para entrar na área ou se mover até o alcance do alvo. Quando a criatura tiver feito isso, ela não poderá se afastar do alvo voluntariamente. Se o alvo causar dano ou ferir a criatura afetada de alguma forma, a criatura afetada pode realizar um novo teste de resistência de Sabedoria para terminar o efeito, como descrito abaixo. Terminando o Efeito. Se uma criatura afetada terminar se turno enquanto não estiver a até 18 metros do alvo ou não for capaz de vê-lo, a  criatura faz um teste de resistência de Sabedoria. Em um sucesso, a criatura não estará mais afetada pelo alvo e  econhecerá o sentimento de repugnância ou atração como mágico. Além disso, uma criatura afetada pela magia tem direito a outro teste de resistência de Sabedoria a cada 24 horas enquanto a magia durar. Uma criatura que obtenha sucesso na resistência contra esse efeito ficará imune a ele por 1 minuto, depois desse tempo, ela pode ser afetada novamente. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 17,
                Nome = "Aprimorar Habilidade",
                Escola = "Transmutação",
                Alcance = "Toque",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 hora",
                Componente = "V, S, M (pelo ou penas de uma besta)",
                Descricao = "Você toca uma criatura e a agracia com aprimoramento mágico. Escolha um dos efeitos a seguir; o alvo ganha esse efeito até o fim da magia. Agilidade do Gato. O alvo tem vantagem em testes de Destreza. Ele também não sofre dano ao cair de 6 metros ou menos, se não estiver incapacitado. Esperteza da Raposa. O alvo tem vantagem em testes de Inteligência. Esplendor da Águia. O alvo tem vantagem em testes de Carisma. Força do Touro. O alvo tem vantagem em testes de Força e sua capacidade de carga é dobrada. Sabedoria da Coruja. O alvo tem vantagem em testes de Sabedoria. Vigor do Urso. O alvo tem vantagem em testes de Constituição. Ele também recebe 2d6 pontos de vida temporários, que são perdidos quando a magia termina. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 3° nível ou superior, você pode afetar uma criatura adicional para cada nível do espaço acima do 2°. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 18,
                Nome = "Aprisionamento",
                Escola = "Abjuração",
                Alcance = "9 metros",
                TempodeConjuracao = "1 minuto",
                Duracao = "Até ser dissipada",
                Componente = "V, S, M (um pergaminho de representação ou uma estatueta esculpida para se parecer com o alvo e um componente especial, que varia de acordo com a versão da magia que você escolher, valendo, no mínimo, 500 po por Dado de Vida)",
                Descricao = "Você cria um impedimento mágico para imobilizar uma criatura que você possa ver, dentro do alcance. O alvo deve ser bem sucedido num teste de resistência de Sabedoria ou será vinculado à magia; se ele for bem sucedido, ele será imune a essa magia se você conjura-la novamente. Enquanto estiver sob efeito dessa magia, a criatura não precisará respirar, comer ou beber e não envelhece. Magias de adivinhação não podem localizar ou perceber o alvo. Quando você conjura essa magia, você escolhe uma das seguintes formas de aprisionamento. Enterrar. O alvo é sepultado bem fundo na terra em uma esfera de energia mágica que é grande o suficiente para conter o alvo. Nada pode atravessar a esfera e nenhuma criatura pode se teletransportar ou usar viagem plantar para entrar ou sair dela. O componente especial para essa versão da magia é um pequeno globo de mitral. Acorrentar. Pesadas correntes, firmemente presas ao solo, matem o alvo no lugar. O alvo está impedido até a magia acabar e ele não pode se mover ou ser movido por nenhum meio, até lá. O componente especial para essa versão da magia é uma fina corrente de metal precioso. Prisão Cercada. A magia transporta o alvo para dentro de um pequeno semiplano que é protegido contra teletransporte e viagem planar. O semiplano pode ser um labirinto, uma jaula, uma torre ou qualquer estrutura ou área confinada similar, à sua escolha. O componente material especial para essa versão da magia é uma representação em miniatura da prisão, feita de jade. Contenção Reduzida. O alvo é reduzido até o tamanho de 30 centímetros e é aprisionado dentro de uma gema ou objeto similar. A luz pode passar através da gema normalmente (permitindo que o alvo veja o exterior e outras criaturas vejam o interior), mas nada mais pode atravessa-la, mesmo por meios de teletransporte ou viagem planar. A gema não pode ser partida ou quebrada enquanto a magia estiver efetiva. O componente especial para essa versão da magia é uma gema transparente grande, como um coríndon, diamante ou rubi. Torpor. O alvo cai no sono e não pode ser acordado. O componente especial para essa versão da magia consiste em ervas soporíferas raras. Terminando a Magia. Durante a conjuração da magia, em quaisquer das versões, você pode especificar uma condição que irá fazer a magia terminar e libertará o alvo. A condição pode ser o quão especifica ou elaborada quanto você quiser, mas o Mestre deve concordar que a condição é razoável e tem uma probabilidade de acontecer. As condições podem ser baseadas no nome, identidade ou divindade da criatura mas, no mais, devem ser baseadas em ações ou qualidades observáveis e não em valores intangíveis tais como nível, classe e pontos de vida. A magia dissipar magia pode terminar a magia apenas se for conjurada como uma magia de 9° nível, tendo como alvo ou a prisão ou o componente especial usado para cria-la. Você pode usar um componente especial em particular para criar apenas uma prisão por vez. Se você conjurar essa magia novamente usando o mesmo componente, o alvo da primeira conjuração é, imediatamente, liberado do vínculo.",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 19,
                Nome = "Arca Secreta de Leomund",
                Escola = "Conjuração",
                Alcance = "Toque",
                TempodeConjuracao = "1 ação",
                Duracao = "Instantânea",
                Componente = "V, S, M (um baú requintado, de 90 cm por 60 cm por 60 cm, construído com materiais raros valendo, no mínimo, 5.000 po e uma réplica Miúda feita do mesmo material valendo, no mínimo, 50 po)",
                Descricao = "Você esconde um baú, e todo o seu conteúdo, no Plano Etéreo. Você deve tocar o baú e a réplica em miniatura que serve como componente material para a magia. O baú pode acomodar até 3,6 metros cúbicos de matéria inorgânica (90 cm por 60 cm por 60 cm). Enquanto o baú permanecer no Plano Etéreo, você pode usar uma ação e tocar a réplica para revocar o baú. Ele aparece em um espaço desocupado no chão a 1,5 metro de você. Você pode enviar o baú de volta ao Plano Etéreo usando uma ação e tocando tanto no baú quanto na réplica. Após 60 dias, existe 5 por cento de chance, cumulativa, por dia do efeito da magia terminar. Esse efeito termina se você conjurar essa magia novamente, se a pequena réplica do baú for destruída ou se você decidir terminar a magia usando uma ação. Se a magia terminar enquanto o baú maior estiver no Plano Etéreo, ele estará irremediavelmente perdido.",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 20,
                Nome = "Área Escorregadia",
                Escola = "Conjuração",
                Alcance = "18 metros",
                TempodeConjuracao = "1 ação",
                Duracao = "1 minuto",
                Componente = "V, S, M (um pouco de pele de porco ou manteiga)",
                Descricao = "Graxa escorregadia cobre o solo em um quadrado de 3 metros centrado em um ponto, dentro do alcance, tornando essa área em terreno difícil pela duração. Quando a graxa aparece, cada criatura de pé na área deve ser bem sucedida num teste de resistência de Destreza ou cairá no chão. Uma criatura que entre na área ou termine seu turno nela, deve ser bem sucedido num teste de resistência de Destreza ou cairá no chão.",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 21,
                Nome = "Arma Elemental",
                Escola = "Transmutação",
                Alcance = "Toque",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 hora",
                Componente = "Verbal, Somático",
                Descricao = "Uma arma não-mágica que você tocar se torna uma arma mágica. Escolha um dos tipos de dano a seguir: ácido, elétrico, frio, fogo ou trovejante. Pela duração, a arma tem +1 de bônus nas jogadas de ataque e causa 1d4 de dano extra, do tipo de elemento escolhido, ao atingir. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 5° ou 6° nível, o bônus nas jogadas de ataque aumenta pra +2 e o dano extra aumenta para 2d4. Quando você usar um espaço de magia de 7° nível ou superior, o bônus aumenta para +3 e o dano extra aumenta para 3d4.",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 22,
                Nome = "Arma Espiritual",
                Escola = "Evocação",
                Alcance = "18 metros",
                TempodeConjuracao = "1 ação bônus",
                Duracao = "1 minuto",
                Componente = "Verbal, Somático",
                Descricao = "Você cria uma arma espectral flutuante, dentro do alcance, que permanece pela duração ou até você conjurar essa magia novamente. Quando você conjura essa magia, você pode realizar um ataque corpo-a-corpo com magia contra uma criatura a 1,5 metro da arma. Se atingir, o alvo sofre dano de energia igual a 1d8 + seu modificador de habilidade de conjuração. Com uma ação bônus, no seu turno, você pode mover a arma até 6 metros e repetir o ataque contra uma criatura a 1,5 metro dela. A arma pode ter a forma que você desejar. Clérigos de divindades associadas com uma arma em particular (como St. Cuthbert é conhecido por sua maça ou Thor por seu martelo) fazem o efeito dessa magia se assemelhar a essa arma. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 4° nível ou superior, o dano aumenta em 1d8 para cada dois níveis do espaço acima do 2°.",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 23,
                Nome = "Arma Mágica",
                Escola = "Transmutação",
                Alcance = "Toque",
                TempodeConjuracao = "1 ação bônus",
                Duracao = "Concentração, até 1 hora",
                Componente = "Verbal, Somático",
                Descricao = "Você toca uma arma não-mágica. Até a magia acabar, a arma se torna uma arma mágica com +1 de bônus nas jogadas de ataque e jogadas de dano. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 4° nível ou superior, o bônus aumenta para +2. Quando você usar um espaço de magia de 6° nível ou superior, o bônus aumenta para +3. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 24,
                Nome = "Armadura Arcana",
                Escola = "Abjuração",
                Alcance = "Toque",
                TempodeConjuracao = "1 ação",
                Duracao = "8 horas",
                Componente = "Verbal, Somático, Material (um pedaço de couro curado)",
                Descricao = "Você toca uma criatura voluntária que não esteja vestindo armadura e uma energia mágica protetora a envolve até a magia acabar. A CA base do alvo se torna 13 + o modificador de Destreza dele. A magia acaba se o alvo colocar uma armadura ou se você dissipa-la usando uma ação. ",
                IdTipoMagia = 2
            },
            new Magia
            {
                IdMagia = 25,
                Nome = "Armadura de Agathys",
                Escola = "Abjuração",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 ação",
                Duracao = "1 hora",
                Componente = "Verbal, Somático, Material (um copo de água)",
                Descricao = "Uma força magica protetora envolve você, manifestandose como um frio espectral que cobre você e seu equipamento. Você ganha 5 pontos de vida temporários pela duração. Se uma criatura atingir você com um ataque corpo-a-corpo enquanto estiver com esses pontos de vida, a criatura sofrerá 5 de dano de frio. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 2° nível ou superior, tanto os pontos de vida temporários quanto o dano de frio aumentam em 5 para cada nível do espaço acima do 1°. ",
                IdTipoMagia = 2
            },
            //26
            new Magia
            {
                IdMagia = 26,
                Nome = "Arrombar",
                Escola = "Transmutação",
                Alcance = "18 metros",
                TempodeConjuracao = "1 ação",
                Duracao = "Instantânea",
                Componente = "Verbal",
                Descricao = "Escolha um objeto que você possa ver, dentro do alcance. O objeto pode ser uma porta, uma caixa, um baú ou um par de algemas, um cadeado ou outro objeto que contenha um meio mundano ou mágico que previne o acesso. Um alvo que esteja fechado por uma fechadura mundana ou preso ou barrado torna-se destrancado, destravado ou desbloqueado. Se o objeto tiver múltiplas fechaduras, apenas uma delas é destrancada. Se você escolher um alvo que esteja travado pela magia tranca arcana, essa magia será suprimida por 10 minutos, durante esse período o alvo pode ser aberto e fechado normalmente. Quando você conjurar essa magia, uma batida forte, audível a até 90 metros de distância, emana do objeto alvo. ",
                IdTipoMagia = 2
            },
            //27
            new Magia
            {
                IdMagia = 27,
                Nome = "Assassino Fantasmagórico",
                Escola = "Ilusão",
                Alcance = "36 metros",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 minuto",
                Componente = "Verbal, Somático",
                Descricao = "Você mexe com os pesadelos de uma criatura que você possa ver, dentro do alcance, e cria uma manifestação ilusória dos seus medos mais profundos, visível apenas para a criatura. O alvo deve realizar um teste de resistência de Sabedoria. Se falhar na resistência, ele ficará amedrontado pela duração. No final de cada turno do alvo, antes da magia acabar, ele deve ser bem sucedido num teste de resistência de Sabedoria ou sofrerá 4d10 de dano psíquico. Se passar na resistência, a magia acaba. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 5° nível ou superior, o dano aumenta em 1d10 para cada nível do espaço acima do 4°",
                IdTipoMagia = 2
            },
            //28
            new Magia
            {
                IdMagia = 28,
                Nome = "Ataque Certeiro",
                Escola = "Adivinhação",
                Alcance = "9 metros",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 rodada",
                Componente = "Somático",
                Descricao = "Você estende sua mão e aponta o dedo para um alvo no alcance. Sua magia garante a você uma breve intuição sobre as defesas do alvo. No seu próximo turno, você terá vantagem na primeira jogada de ataque contra o alvo, considerando que essa magia não tenha acabado. ",
                IdTipoMagia = 1
            },
            //29
            new Magia
            {
                IdMagia = 29,
                Nome = "Ataque Visual",
                Escola = "Necromancia",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 minuto",
                Componente = "Verbal, Somático",
                Descricao = "Pela duração da magia, seus olhos tornam-se manchas vazias imbuídas com poder terrível. Uma criatura, à sua escolha, a até de 18 metros de você que você puder ver, deve ser bem sucedida num teste de resistência de Sabedoria ou será afetada por um dos efeitos a seguir, à sua escolha, pela duração. A cada um dos seus turnos, até a magia acabar, você pode usar sua ação para afetar outra criatura, mas não pode afetar uma criatura novamente se ela tiver sido bem sucedida no teste de resistência contra essa conjuração de ataque visual. Adormecer. O alvo cai inconsciente. Ele acorda se sofrer qualquer dano ou se outra criatura usar sua ação para sacudir o adormecido até acordá-lo. Apavorar. O alvo está amedrontado. Em cada um dos turnos dele, a criatura amedrontada deve realizar a ação de Disparada e se mover para longe de você pela rota segura mais curta disponível, a não ser que não haja lugar para se mover. Se o alvo se mover para um local a, pelo menos, 18 metros de distância de você onde ela não possa mais te ver, esse efeito termina. Adoecer. O alvo tem desvantagem nas jogadas de ataque e testes de habilidade. No final de cada um dos turnos dele, ele pode realizar outro teste de resistência de Sabedoria. Se for bem sucedido, o efeito termina. ",
                IdTipoMagia = 2
            },
            //30
            new Magia
            {
                IdMagia = 30,
                Nome = "Augúrio",
                Escola = "Adivinhação (ritual)",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 minuto",
                Duracao = "Instantânea",
                Componente = "Verbal, Somático, Material (varetas, ossos ou objetos similarmente marcados valendo, no mínimo, 25 Peças de Ouro",
                Descricao = "Ao lançar varetas cravejados com gemas, rolar ossos de dragão, puxar cartas ornamentadas ou usar outro tipo de ferramenta de adivinhação, você recebe um pressagio de uma entidade de outro mundo, sobre os resultados de cursos de ação específicos que você planeja tomar nos próximos 30 minutos. O Mestre escolhe dentre os possíveis presságios a seguir: • Êxito, para resultados bons • Fracasso, para resultados maus • Êxito e fracasso, para resultados bons e maus • Nada, para resultados que não são especialmente bons ou ruins A magia não leva em conta qualquer possível circunstancia que possa mudar o resultado, como a conjuração de magias adicionais ou a perda ou ganho de um companheiro. Se você conjurar a magia duas ou mais vezes antes de completar seu próximo descanso longo, existe uma chance cumulativa de 25 por cento de cada conjuração, depois da primeira que você fez, ter um resultado aleatório. O Mestre faz essa jogada secretamente. ",
                IdTipoMagia = 2
            },
            //31
            new Magia
            {
                IdMagia = 31,
                Nome = "Aumentar/Reduzir",
                Escola = "Transmutação",
                Alcance = "9 metros",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 minuto",
                Componente = "Verbal, Somático, Material (um pouco de pó de ferro",
                Descricao = "Você faz com que uma criatura ou um objeto que você possa ver dentro do alcance, fique maior ou menor, pela duração. Escolha entre uma criatura ou um objeto que não esteja sendo carregado nem vestido. Se o alvo for involuntário, ele deve realizar um teste de resistência de Constituição. Se for bem sucedido, a magia não surte efeito. Se o alvo for uma criatura, tudo que ele esteja vestindo ou carregando muda e tamanho com ela. Qualquer item largado por uma criatura afetada, retorna ao seu tamanho natural. Aumentar. O tamanho do alvo dobra em todas as dimensões e seu peso é multiplicado por oito. Esse aumento eleva seu tamanho em uma categoria – de Médio para Grande, por exemplo. Se não houver espaço suficiente para que o alvo dobre de tamanho, a criatura ou objeto alcança o tamanho máximo possível no espaço disponível. Até o fim da magia, o alvo também tem vantagem em testes de Força e testes de resistência de Força. O tamanho das armas do alvo crescem para se adequar ao seu novo tamanho. Quando essas armas são ampliadas, os ataques do alvo com elas causam 1d4 de dano extra. Reduzir. O tamanho do alvo é reduzido à metade em todas as dimensões e seu peso é reduzido a um oitavo do normal. Essa redução diminui o tamanho do alvo em uma categoria – de Médio para Pequeno, por exemplo. Até o fim da magia, o alvo tem desvantagem em testes de Força e testes de resistência de Força. O tamanho das armas doalvo diminuem para se adequar ao seu novo tamanho. Quando essas armas são reduzidas, os ataques do alvo com elas causam 1d4 de dano a menos (isso não pode reduzir o dano a menos de 1).",
                IdTipoMagia = 2
            },
            //32
            new Magia
            {
                IdMagia = 32,
                Nome = "Aura de Pureza",
                Escola = "Abjuração",
                Alcance = "Pessoal (9 metros de raio)",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 10 minutos",
                Componente = "Verbal",
                Descricao = "Energia purificante irradia de você em uma aura com 9 metros de raio. Até a magia acabar, a aura se move mantendo-se centrada em você. Todas as criaturas nãohostis na aura (incluindo você) não podem ficar doentes, tem resistência a dano de veneno e tem vantagem em testes de resistência contra efeitos que deixem ela com qualquer das condições a seguir: amedrontado, atordoado, cego, enfeitiçado, envenenado, paralisado e surdo. ",
                IdTipoMagia = 2
            },
            //33
            new Magia
            {
                IdMagia = 33,
                Nome = "Aura de Vida",
                Escola = "Abjuração",
                Alcance = "Pessoal (9 metros)",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 10 minutos",
                Componente = "Verbal",
                Descricao = "Energia de prevenção vital irradia de você em uma aura com 9 metros de raio. Até a magia acabar, a aura se move mantendo-se centrada em você. Todas as criaturas nãohostis na aura (incluindo você) tem resistência a dano necrótico e seu máximo de pontos de vida não pode ser reduzido. Além disso, uma criatura viva não-hostil, recupera 1 ponto de vida quando começa seu turno na aura com 0 pontos de vida. ",
                IdTipoMagia = 2
            },
            //34
            new Magia
            {
                IdMagia = 34,
                Nome = "Aura de Vitalidade",
                Escola = "Evocação",
                Alcance = "Pessoal (9 metros)",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 minuto",
                Componente = "Verbal",
                Descricao = "Energia de prevenção vital irradia de você em uma aura com 9 metros de raio. Até a magia acabar, a aura se move mantendo-se centrada em você. Todas as criaturas nãohostis na aura (incluindo você) tem resistência a dano necrótico e seu máximo de pontos de vida não pode ser reduzido. Além disso, uma criatura viva não-hostil, recupera 1 ponto de vida quando começa seu turno na aura com 0 pontos de vida. ",
                IdTipoMagia = 2
            },
            //35
            new Magia
            {
                IdMagia = 35,
                Nome = "Aura Mágica de Nystul",
                Escola = "Ilusão",
                Alcance = "Toque",
                TempodeConjuracao = "1 ação",
                Duracao = "24 horas",
                Componente = "Verbal, Somático, Material (um pequeno quadrade do seda)",
                Descricao = "Você coloca uma ilusão em uma criatura ou objeto que você tocar, então magias de adivinhação revelarão informações falsas sobre ele. O alvo pode ser uma criatura voluntária ou um objeto que não esteja sendo carregado ou vestido por outra criatura. Quando você conjura essa magia, escolha um ou ambos os efeitos seguintes. O efeito permanece pela duração. Se você conjurar essa magia na mesma criatura ou objeto a cada dia por 30 dias, colocando o mesmo efeito nele todas as vezes, a ilusão durará até ser dissipada. Aura Falsa. Você modifica a forma como o alvo aparece para magias e efeitos mágicos, como detectar magia, que detectam auras mágicas. Você pode fazer um objeto não-mágico parecer mágico ou mudar a aura mágica de um objeto para que ela pareça pertencer a outra escola de magia a sua escolha. Quando você usar esse efeito num objeto, você pode fazer a aura falsa aparente a qualquer criatura que manusear o item. Máscara. Você modifica a forma como o alvo aparece para magias e efeitos que detectam tipos de criaturas, como o Sentido Divino do paladino ou o gatilho de um magia símbolo. Você escolhe o tipo de criatura e outras magias e efeitos mágicos consideram o alvo como se ele fosse uma criatura desse tipo ou tendência.",
                IdTipoMagia = 2
            },
            //36
            new Magia
            {
                IdMagia = 36,
                Nome = "Aura Sagrada",
                Escola = "Abjuração",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 minuto",
                Componente = "Verbal, Somático, Material (um minúsculo relicário valendo, no mínimo, 1000 Peças de Ouro, contendo uma relíquia sagrada, como um pedaço de tecido do robe de um santo ou um pedaço de um pergaminho de um texto religioso",
                Descricao = "Luz divina emana de você e adere em uma aureola suave num raio de 9 metros, em volta de você. As criaturas de sua escolha, no raio, quando você conjurar essa magia, emitem penumbra num raio de 1,5 metro e tem vantagem em todos os testes de resistência e as outras criaturas tem desvantagem nas jogadas de ataque contra elas, até a magia acabar. Além disso, quando um corruptor ou morto-vivo atingir uma criatura afetada com um ataque corpo-a-corpo, a aura lampeja com luz plena. O atacante deve ser bem sucedido num teste de resistência de Constituição ou ficara cego até a magia acabar. ",
                IdTipoMagia = 2
            },
            //37
            new Magia
            {
                IdMagia = 37,
                Nome = "Auxílio Divino",
                Escola = "Evocação",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 ação bônus",
                Duracao = "Concentração, até 1 minuto",
                Componente = "Verbal, Somático",
                Descricao = "Sua oração fortalece você com radiação divina. Até o fim da magia, seus ataques com arma causam 1d4 de dano radiante extra ao atingirem.",
                IdTipoMagia = 2
            },
            //38
            new Magia
            {
                IdMagia = 38,
                Nome = "Banimento",
                Escola = "Abjuração",
                Alcance = "9 metros",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 minuto",
                Componente = "Verbal, Somático, Material (um item desagradável ao alvo",
                Descricao = "Você tenta enviar uma criatura que você pode ver dentro do alcance, para outro plano de existência. O alvo deve ser bem sucedido num teste de resistência de Carisma ou será banido. Se o alvo for nativo do plano de existência que você está, você bane o alvo para um semiplano inofensivo. Enquanto estiver lá, a criatura estará incapacitada. Ela permanece lá até a magia acabar, a partir desse ponto, o alvo reaparece no espaço em que ela deixou ou no espaço desocupado mais próximo, se o espaço dela estive ocupado. Se o alvo for nativo de um plano de existência diferente do que você está, o alvo é banido em um lampejo sutil, retornando para o seu plano natal. Se a magia acabar antes de 1 minuto se passar, o alvo reaparece no lugar em que estava ou no espaço desocupado mais próximo, se o espaço dela estiver ocupado. Do contrário, o alvo não retorna. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 5° nível ou superior, você pode afetar uma criatura adicional para cada nível do espaço acima do 4°.",
                IdTipoMagia = 2
            },
            //39
            new Magia
            {
                IdMagia = 39,
                Nome = "Banquete de Heróis",
                Escola = "Conjuração",
                Alcance = "9 metros",
                TempodeConjuracao = "10 minutos",
                Duracao = "Instantânea",
                Componente = "Verbal, Somático, Material (uma tigela encrustada de gemas valendo, no mínimo, 1000 Peças de Ouro, que é consumida pela magia",
                Descricao = "Você traz um grande banquete, incluindo comida e bebida magnificas. O banquete leva 1 hora para ser consumido e desaparece ao final desse tempo e os efeitos benéficos não se aplicam até essa hora terminar. Até doze criaturas podem participar do banquete. Uma criatura que participe do banquete ganha diversos benefícios. A criatura é curada de todas as doenças e venenos, torna-se imune a veneno e a ser amedrontada e faz todos os seus testes de resistência de Sabedoria com vantagem. Seu máximo de pontos de vida também aumenta em 2d10 e ela ganha a mesma quantidade de pontos de vida. Esses benefícios duram por 24 horas. ",
                IdTipoMagia = 2
            },
            //40
            new Magia
            {
                IdMagia = 40,
                Nome = "Barreira de Lâminas",
                Escola = "Evocação",
                Alcance = "24 metros",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 10 minutos",
                Componente = "Verbal, Somático",
                Descricao = "Você cria uma muralha vertical de lâminas giratórias, afiadas como navalhas, feitas de energia mágica. A muralha aparece dentro do alcance e permanece pela duração. Você pode fazer uma muralha reta de até 30 metros de comprimento por 6 metros de altura e 1,5 metro de largura ou uma muralha anelar com até 18 metros de diâmetro, 6 metros de altura e 1,5 metro de largura. A muralha confere três-quartos de cobertura a criaturas atrás dela e seu espaço é terreno difícil. Quando uma criatura entrar a área da muralha pela primeira vez em um turno, ou começar seu turno nela, a criatura deve realizar um teste de resistência de Destreza. Se falhar, a criatura sofrerá 6d10 de dano cortante. Em um sucesso, a criatura sofre metade desse dano",
                IdTipoMagia = 2
            },
            //41
            new Magia
            {
                IdMagia = 41,
                Nome = "Benção",
                Escola = "Encantamento",
                Alcance = "9 metros",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 minuto",
                Componente = "Verbal, Somático, Material (um borrifo de água benta)",
                Descricao = "Você abençoa até três criaturas, à sua escolha, dentro do alcance. Sempre que um alvo realizar uma jogada de ataque ou teste de resistência antes da magia acabar, o alvo pode jogar um d4 e adicionar o valor jogado ao ataque ou teste de resistência. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 2° nível ou superior, você pode afetar uma criatura adicional para cada nível do espaço acima do 1°. ",
                IdTipoMagia = 2
            },
            //42
            new Magia
            {
                IdMagia = 42,
                Nome = "Boca Encanta",
                Escola = "Ilusão (ritual)",
                Alcance = "9 metros",
                TempodeConjuracao = "1 minuto",
                Duracao = "Até ser dissipada",
                Componente = "Verbal, Somático, Material (um pedaço de favo de mel e pó de jade valendo, no mínimo, 10 Peças de Ouro, consumidos pela magia)",
                Descricao = "Você implanta uma mensagem em um objeto dentro do alcance, uma mensagem que é pronunciada quando uma condição de ativação é satisfeita. Escolha um objeto que você possa ver e não esteja sendo vestido ou carregado por outra criatura. Então, fale a mensagem, que deve conter 25 palavras ou menos, apesar de ela poder ser entregue durante um período de até 10 minutos. Finalmente, determine a circunstância que irá ativar a magia para que sua mensagem seja entregue. Quando essa circunstância ocorrer, a boca encantada aparecerá no objeto e recitará a mensagem com sua voz e com o mesmo volume que você falou. Se o objeto que você escolheu tiver uma boca ou algo semelhante a uma boca (por exemplo, a boca de uma estátua), a boca mágica aparece ai, então, as palavras parecerão vir da boca do objeto. Quando você conjura essa magia, você pode fazer a magia acabar depois de enviar sua mensagem ou ela pode permanecer e repetir a mensagem sempre que a circunstância de ativação ocorrer. A circunstância de ativação pode ser tão genérica ou tão detalhada quando você quiser, apesar de ela precisar ser baseada em condições visuais ou audíveis que ocorram a até 9 metros do objeto. Por exemplo, você pode instruir a boca a falar quando uma criatura se aproximar a menos de 9 metros do objeto ou quando um sino de prata tocar a menos de 9 metros dela",
                IdTipoMagia = 2
            },
            //43
            new Magia
            {
                IdMagia = 43,
                Nome = "Bola de Fogo",
                Escola = "Evocação",
                Alcance = "45 metros",
                TempodeConjuracao = "1 ação",
                Duracao = "Instantânea",
                Componente = "Verbal, Somática, Material (uma minúscula bola de guano de morcego e enxofre)",
                Descricao = "Um veio brilhante lampeja na ponta do seu dedo em direção a um ponto que você escolher, dentro do alcance, e então eclode com um estampido baixo, explodindo em chamas. Cada criatura em uma esfera de 6 metros de raio, centrada no ponto, deve realizar um teste de resistência de Destreza. Um alvo sofre 8d6 de dano de fogo se falhar na resistência, ou metade desse dano se obtiver sucesso. O fogo se espalha, dobrando esquinas. Ele incendeia objetos inflamáveis na área que não estejam sendo vestidos ou carregados. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 4° nível ou superior, o dano aumenta em 1d6 para cada nível do espaço acima do 3°. ",
                IdTipoMagia = 2
            },
            //44
            new Magia
            {
                IdMagia = 44,
                Nome = "Bola de Fogo Controlável",
                Escola = "Evocação",
                Alcance = "45 metros",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 minuto",
                Componente = "Verbal, Somático, Material (uma minúscula bola de guano de morcego e enxofre)",
                Descricao = "Um feixe de luz amarelada é disparado da ponta do seu dedo, então se condensa e aguarda no ponto escolhido, dentro do alcance, como uma conta brilhante, pela duração. Quando a magia termina, seja por sua concentração ter sido interrompida ou por você ter decidido termina-la, a conta eclode com um estampido baixo, explodindo em chamas que se espalhando, dobrando esquinas. Cada criatura numa esfera, com 6 metros de raio, centrada na conta, deve realizar um teste de resistência de Destreza. Uma criatura sofre dano igual ao total de dano acumulado se falhar na resistência, ou metade do total se obtiver sucesso. 224 O dano base da magia é 12d6. Se até o final do seu turno, a conta ainda não tiver sido detonada, o dano aumenta em 1d6. Se a conta brilhante for tocada antes do intervalo expirar, a criatura que a tocou deve realizar um teste de resistência de Destreza. Se falhar na resistência, a magia termina imediatamente, fazendo a conta explodir em chamas. Se obtiver sucesso na resistência, a criatura pode arremessar a conta a até 12 metros. Quando ela atinge uma criatura ou objeto solido, a magia termina e a conta explode. O fogo danifica objetos na área e incendeia objetos inflamáveis que não estejam sendo vestidos ou carregados. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 8° nível ou superior, o dano base aumenta e 1d6 para cada nível do espaço acima do 7°. ",
                IdTipoMagia = 2
            },
            //45
            new Magia
            {
                IdMagia = 45,
                Nome = "Bom Fruto",
                Escola = "Transmutação",
                Alcance = "Toque",
                TempodeConjuracao = "1 ação",
                Duracao = "Instantânea",
                Componente = "Verbal, Somática, Material (um raminho de visco)",
                Descricao = "Até dez frutos aparecem na sua mão e são infundidos com magia pela duração. Uma criatura pode usar sua ação para comer um fruto. Comer um fruto restaura 1 ponto de vida e um fruto produz nutrientes suficientes para sustentar uma criatura por um dia. Os frutos perdem seu potencial se não forem consumidos dentro de 24 horas da conjuração dessa magia",
                IdTipoMagia = 2
            },
            //46
            new Magia
            {
                IdMagia = 46,
                Nome = "Bordão Místico",
                Escola = "Transmutação",
                Alcance = "Toque",
                TempodeConjuracao = "1 ação bônus",
                Duracao = "1 minuto",
                Componente = "Verbal, Somático, Material (visco, uma folha de trevo e uma clava ou bordão)",
                Descricao = "A madeira de uma clava ou bordão, que você esteja segurando, é imbuída com o poder da natureza. Pela duração, você pode usar sua habilidade de conjuração ao invés da sua Força para as jogadas de ataque e dano corpo-a-corpo usando essa arma, e o dado de dano da arma se torna um d8. A arma também se torna mágica, se ela já não for. A magia acaba se você conjura-la novamente ou se você soltar a arma.",
                IdTipoMagia = 1
            },
            //47
            new Magia
            {
                IdMagia = 47,
                Nome = "Braços de Hadar",
                Escola = "Conjuração",
                Alcance = "Pessoal (3 metros de raio)",
                TempodeConjuracao = "1 ação",
                Duracao = "Instantânea",
                Componente = "Verbal, Somática",
                Descricao = "Você invoca o poder de Hadar, o Faminto Sombrio. Tentáculos de energia negra brotam de você e golpeiam todas as criaturas a até 3 metros de você. Cada criatura na área deve realizar um teste de resistência de Força. Se falhar, o alvo sofre 2d6 de dano necrótico e não pode fazer reações até o próximo turno dela. Em um sucesso, uma criatura sofre metade do dano e não sofre qualquer outro efeito. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 2° nível ou superior, o dano aumenta em 1d6 para cada nível do espaço acima do 1°.",
                IdTipoMagia = 2
            },
            //48
            new Magia
            {
                IdMagia = 48,
                Nome = "Bruxaria",
                Escola = "Encantamento",
                Alcance = "18 metros",
                TempodeConjuracao = "1 ação bônus",
                Duracao = "Concentração, até 1 hora",
                Componente = "Verbal, Somático, Material (o olho petrificado de um tritão)",
                Descricao = "Você coloca uma maldição em uma criatura que você possa ver, dentro do alcance. Até a magia acabar, você causa 1d6 de dano necrótico extra no alvo sempre que atingi-lo com um ataque. Além disso, escolha uma habilidade quando você conjurar a magia. O alvo tem desvantagem em testes de habilidade feitos com a habilidade escolhida. Se o alvo cair a 0 pontos de vida antes da magia acabar, você pode usar uma ação bônus, em um turno subsequente, para amaldiçoar outra criatura. Uma magia remover maldição conjurada no alvo acaba com a magia prematuramente. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 3° ou 4° nível, você poderá manter sua concentração na magia por até 8 horas. Quando você usar um espaço de magia de 5° nível ou superior, você poderá manter sua concentração na magia por até 24 horas.",
                IdTipoMagia = 2
            },
            //49
            new Magia
            {
                IdMagia = 49,
                Nome = "Caminhar em Árvores",
                Escola = "Conjuração",
                Alcance = "Pessoal",
                TempodeConjuracao = "1 ação",
                Duracao = "Concentração, até 1 minuto",
                Componente = "Verbal, Somático",
                Descricao = "Você adquire a habilidade de entrar em uma árvore e se mover de dentro dela para dentro de outra árvore de mesmo tipo à até 150 metros. Ambas as árvores devem estar vivas e ter, pelo menos, o mesmo tamanho que você. Você deve usar 1,5 metro de deslocamento para entrar numa árvore. Você, instantaneamente, sabe a localização de todas as outras árvores de mesmo tipo à 150 metros e, como parte do movimento usado para entrar na árvore, pode tanto passar por uma dessas árvores quanto sair da árvore em que você está. Você aparece no espaço que você quiser a 1,5 metro da árvore destino, usando outro movimento de 1,5 metro. Se você não tiver movimento restante, você aparece a 1,5 metro da árvore que você terminou seu movimento. Você pode usar esse habilidade de transporte uma vez por rodada pela duração. Você deve terminar cada turno fora da árvore. ",
                IdTipoMagia = 2
            },
            //50
            new Magia
            {
                IdMagia = 50,
                Nome = "Caminhar no Vento",
                Escola = "Transmutação",
                Alcance = "9 metros",
                TempodeConjuracao = "1 minuto",
                Duracao = "8 horas",
                Componente = "Verbal, Somático, Material (fogo e água benta)",
                Descricao = "Você e até dez criaturas voluntária que você possa ver, dentro do alcance, assumem uma forma gasosa pela duração, parecidas com pedaços de nuvem. Enquanto estiver na forma de nuvem, uma criatura tem deslocamento de voo de 90 metros e tem resistência a dano de concussão, cortante e perfurante de ataques nãomágicos. As únicas ações que uma criatura pode realizar nessa forma são a ação de Disparada ou para reverter a sua forma normal. Reverter leva 1 minuto, período pelo qual a criatura estará incapacitada e não poderá se mover. Até a magia acabar, uma criatura pode reverter para a forma de nuvem, o que também requer a transformação de 1 minuto. Se uma criatura estiver na forma de nuvem e voando quando o efeito acabar, a criatura descerá a 18 metros por rodada por 1 minuto, até aterrissar na solo, o que é feito com segurança. Se ela não puder aterrissar em 1 minuto, a criatura cairá a distância restante. ",
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
                Nome = "Anão",
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
                Nome = "Anão da Colina",
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
                Nome = "Anão da Montanha",
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
                Nome = "Pés Leves",
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
                Preco = "8 Peças de Ouro",
                Deslocamento = "12 metros",
                CapacidadedeCarga = "210 Kg"
            },
            //2, Camelo
            new VeiculoTerrestre{
                IdVeiculoTerrestre = 2,
                Nome = "Camelo",
                Preco = "50 Peças de Ouro",
                Deslocamento = "15 metros",
                CapacidadedeCarga = "240 Kg"
            },
            //3, Cavalo de Guerra
            new VeiculoTerrestre{
                IdVeiculoTerrestre = 3,
                Nome = "Cavalo de guerra",
                Preco = "400 Peças de Ouro",
                Deslocamento = "18 metros",
                CapacidadedeCarga = "270 Kg"
            },
            //4, Cavalo de montaria
            new VeiculoTerrestre{
                IdVeiculoTerrestre = 4,
                Nome = "Cavalo de montaria",
                Preco = "75 Peças de Ouro",
                Deslocamento = "18 metros",
                CapacidadedeCarga = "220 Kg"
            },
            //5, Cavalo Pesado
            new VeiculoTerrestre{
                IdVeiculoTerrestre = 5,
                Nome = "Cavalo Pesado",
                Preco = "50 Peças de Ouro",
                Deslocamento = "12 metros",
                CapacidadedeCarga = "270 Kg"
            },
            //6, Elefante
            new VeiculoTerrestre{
                IdVeiculoTerrestre = 6,
                Nome = "Elefante",
                Preco = "200 Peças de Ouro",
                Deslocamento = "12 metros",
                CapacidadedeCarga = "660 Kg"
            },
            //7, Mastim
            new VeiculoTerrestre{
                IdVeiculoTerrestre = 7,
                Nome = "Mastim",
                Preco = "25 Peças de Ouro",
                Deslocamento = "12 metros",
                CapacidadedeCarga = "100 Kg"
            },
            //8, Pônei
            new VeiculoTerrestre{
                IdVeiculoTerrestre = 8,
                Nome = "Pônei",
                Preco = "30 Peças de Ouro",
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
                    Preco = "3000 Peças de Ouro",
                    Velocidade = "1.5 km/h"
                },
                //2, Barco a remo
                new VeiculoAquatico{
                    IdVeiculoAquatico = 2,
                    Nome = "Barco a remo",
                    Preco = "50 Peças de Ouro",
                    Velocidade = "2 km/h"
                },
                //3, Dracar
                new VeiculoAquatico{
                    IdVeiculoAquatico = 3,
                    Nome = "Dracar",
                    Preco = "10000 Peças de Ouro",
                    Velocidade = "5 km/h"
                },
                //4, Galera
                new VeiculoAquatico{
                    IdVeiculoAquatico = 4,
                    Nome = "Galera",
                    Preco = "30000 Peças de Ouro",
                    Velocidade = "6.5 km/h"
                },
                //5, Navio de guerra
                new VeiculoAquatico{
                    IdVeiculoAquatico = 5,
                    Nome = "Navio de guerra",
                    Preco = "25000 Peças de Ouro",
                    Velocidade = "4 km/h"
                },
                //6, Veleiro
                new VeiculoAquatico{
                    IdVeiculoAquatico = 6,
                    Nome = "Veleiro",
                    Preco = "10000 Peças de Ouro",
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
                    Preco = "4 Peças de Ouro",
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
                    Preco = "250 Peças de Ouro",
                    Peso = "50 Kg"
                },
                //4, Carroça
                new ASVTracao{
                    IdASVTracao = 4,
                    Nome = "Carroça",
                    Preco = "15 Peças de Ouro",
                    Peso = "100 Kg"
                },
                //5, Carruagem
                new ASVTracao{
                    IdASVTracao = 5,
                    Nome = "Carruagem",
                    Preco = "100 Peças",
                    Peso = "300 Kg"
                },
                //6, Estábulo
                new ASVTracao{
                    IdASVTracao = 6,
                    Nome = "Estábulo",
                    Preco = "5 Peças de Prata",
                    Peso = "-"
                },
                //7, Freio e rédea
                new ASVTracao{
                    IdASVTracao = 7,
                    Nome = "Freio e rédea",
                    Preco = "2 Peças de Ouro",
                    Peso = "0.5 Kg"
                },
                //8, Ração (1 dia)
                new ASVTracao{
                    IdASVTracao = 8,
                    Nome = "Ração",
                    Preco = "5 Kg",
                    Peso = "5 Peças de Cobre"
                },
                //9, Sela Compacta
                new ASVTracao{
                    IdASVTracao = 9,
                    Nome = "Sela Compacta",
                    Preco = "5 Peças de Ouro",
                    Peso = "7.5 Kg"
                },
                //10, Sela Exótica
                new ASVTracao{
                    IdASVTracao = 10,
                    Nome = "Sela Exótica",
                    Preco = "60 Peças de Ouro",
                    Peso = "20 Kg"
                },
                //11, Sela Militar
                new ASVTracao{
                    IdASVTracao = 11,
                    Nome = "Sela Militar",
                    Preco = "20 Peças de Ouro",
                    Peso = "15 Kg"
                },
                //12, Sela p/ Viagem
                new ASVTracao{
                    IdASVTracao = 12,
                    Nome = "Sela p/ Viagem",
                    Preco = "10 Peças de Ouro",
                    Peso = "12.5 Kg"
                },
                //13, Trenó
                new ASVTracao{
                    IdASVTracao = 13,
                    Nome = "Trenó",
                    Preco = "20 Peças de Ouro",
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