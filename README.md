# SpaceRace
Документација за Space Race

SpaceRace е игра во која двајца играчи во форма на кругови имаат цел да се тркаат меѓусебно до горниот крај додека ги избегнуваат астероидите кои се појавуваат од лева и десна страна. Играчот кој ќе собере најмногу поени пред времето да истече е победник. Целта на SpaceRace e да играчите имаат забава и комплетно задоволство додека ја играат нашата игра која користи ретро графика.
На почетниот прозорец имаме можност да започнеме со играта, како и да го исклучиме прозорецот. Кога ќе кликнеме на копчето Start се отвара нов прозорец и започнуваме со играта, а при клик на копчето Quit се исклучува прозорецот.

 ![Screenshot (42)](https://user-images.githubusercontent.com/72814951/121820655-577d7d00-cc94-11eb-9161-4012faa10e14.png)
 
Играта има можност да се игра со два играчи. Должината на играта е регулирана со тајмер од две минути што започнува откако ќе се притисне копчето за Start. Играчите се движат во сите насоки (горе, лево, доле, десно) со користење на копчињата W A S D за играчот 1, односно стрелките на тастатурата за играчот 2. Астероидите летаат од лево кон десно и од десно кон лево и играчите треба да ги избегнуваат астероидите. Доколку играчот е погоден од астероид, по кратко време тој започнува повторно на долниот дел од екранот. Кога играчот ќе стигне до горниот дел од екранот тој добива еден поен. Победник во играта е играчот со најмногу поени.
Откако ќе се кликне на копчето Start при MainMenu, се почнува со играта. Прозорецот кој се отвора изгледа вака:

 ![Screenshot (41)](https://user-images.githubusercontent.com/72814951/121821592-3a4bad00-cc9a-11eb-9887-35692dce2ecc.png)

Како што може да се види, прозорецот е поделен на два дела, заклучно со вертикалната линија на средина. Секој од играчите е претставен како круг оцртан со бела боја. Астероидите се претставени како бели полни топки, кои се движат хоризонтално со брзина од 2 пиксели на 1 милисекунда. Најгоре е прикажано останатото време кое почнува од 2 минути и на секоја секунда се намалува времето со помош на Timer. Во најдолниот дел од прозорецот има ProgressBar, кој е синхронизиран со тимерот кој го контролира времето, односно на секоја секунда се намалува за една единица. Во најдолниот лев и десен агол може да се видат моменталните поени на секој од играчите соодветно. Тие се ажурираат секогаш кога некој од играчите ќе постигне поен. Играч добива поен доколку успее да стигне до најгорната точка од прозорецот, притоа избегнувајќи ги сите астероиди. Со клик на Save може да се зачува играта, а со клик на Open може да се продолжи со играње некоја веќе зачувана игра. Откако ќе истече времето, се појавува MessageBox, при што се соопштува победникот, а астероидите престануваат да се движат. Тука ве прашува дали сакате нова игра, и имате две опции, Yes и No. Доколку кликнете Yes се отвора нова игра, а при No се затвора прозорецот.

Играчите можат да се движат со користење на копчињата W A S D за Играч 1,  и со користење на стрелките за Играч 2. При секое притискање на копчињата за движење, прво се прави проверка дали играчот може да се придвижи во посакуваната насока. Пример: Играч 1 не може да се придвижи десно доколку следната позиција на играчот ја преминува вертикалната линија во средина. Следно е прикажано како изгледа функцијата која го поместува Играчот 1 на десно:


![Screenshot (46)](https://user-images.githubusercontent.com/72814951/121821603-4d5e7d00-cc9a-11eb-8352-b5b0de8c6f5c.png)


Доколку следната позиција е возможна, играчот се поместува во соодветната насока за онолку пиксели колку што е int променливата MoveIndex (предефинирана вредност е 23).

Класата Ball ни претставува класа во која се чува објект Center од класата Point и една int променлива Radius. Исто така ги содржи и методите MoveLeft(), MoveRight() и IsTouching(Ball that). MoveLeft и MoveRight го поместуваат центарот на кружницата на лево и на десно, а IsTouching враќа Boolean вредност, односно true доколку објектот од кој се повикува функцијата се допира со објектот проследен како аргумент, а во спротивно враќа false.  

![Screenshot (47)](https://user-images.githubusercontent.com/72814951/121821609-50f20400-cc9a-11eb-971b-f9d6f78af942.png)


Класата Line во овој проект нема голема улога, односно нејзината улога е прикажување на вертикалната линија на средина. 

Класите PlayerLeft и PlayerRight го претставуваат секој од играчите, Играч 1 е PlayerLeft, а Играч 2 е PlayerRight. Овие две класи наследуваат од апстрактната класа Player. Во Player се чуваат неколку објекти, како што се Ball од класата Ball, кој ја претставува кружницата со која се прикажува играчот, Center од класата Point во кој се чува моменталната позиција на играчот, како и int променливите Width и Height кои ја претставуваат ширината и висината на прозорецот. Во наследените класи се препокриени соодветните методи за придвижување со потребните проверки.

Во класата Scene се чуваат сите астероиди, двата играчи, еден Random објект и висината и ширината на прозорецот, како и линијата на средина.

![Screenshot (49)](https://user-images.githubusercontent.com/72814951/121822633-69651d00-cca0-11eb-8f65-0b15e57bb9b0.png)

Астероидите се чуваат во две листи. Во едната листа се чуваат само тие што се движат од лево кон десно, а во другата се чуваат оние кои се движат од десно кон лево. На топчињата од првата листа им се повика методата MoveRight(), а на оние од другата се повикува MoveLeft().
Една функција во класата Scene е GenerateBall(), којашто при случаен избор додава една топка во некоја од двете листи. Секоја топка се иницијализира на случајна позиција на y-оската. Следно е прикажано како изгледа оваа функција:
 
![Screenshot (50)](https://user-images.githubusercontent.com/72814951/121822639-7124c180-cca0-11eb-816d-f1a270f3448b.png)

Во класата на формата се чува еден објект од класата Scene, како и int променлива за преостанатото време.


Изработено од: Игор Огњанов, Мартин Стефанов.
