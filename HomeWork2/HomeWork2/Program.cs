// See https://aka.ms/new-console-template for more information
// 1. uzdevums 
//// 1. Pajautāt lietotājam ievadīt savu vārdu
Console.WriteLine("Kā Tevi sauc ?");

//// 2. Sagaidīt lietotāja vārda ievadi
string userName = Console.ReadLine();

//// 3. sasveicināties ar lietotāju ar viņa vārdu
string userGreeting = "Sveiks " + userName + "!";
Console.WriteLine(userGreeting);

Console.WriteLine();
Console.WriteLine("===================================");
Console.WriteLine();

// 2. uzdevums
//// 1. Pajautāt lietotājam ievadīt vecumu
Console.WriteLine("Kāds ir Tavs vecums ?");

//// 2. Sagaidīt lietotāja vecuma ievadi
string userNumberText = Console.ReadLine();
int userNumber = int.Parse(userNumberText);

//// 3. Norādīt cik gadi lietotājam paliks nākamgad
int addedToUserNumber = userNumber + 1;
Console.WriteLine("Nākamgad Tev paliks " + addedToUserNumber);

Console.WriteLine();
Console.WriteLine("===================================");
Console.WriteLine();

// 3. uzdevums
//// 1. pajautāt pirmo skaitli
Console.WriteLine("Lūdzu, ievadi pirmo skaitli ");

//// 2. sagaidīt pirmā skaitļa ievadi
int firstNumber = int.Parse(Console.ReadLine());

//// 3. pajautāt otro skaitli
Console.WriteLine("Lūdzu, ievadi otro skaitli ");

//// 4. sagaidīt otrā skaitļa ievadi
int secondNumber = int.Parse(Console.ReadLine());

//// 5. pajautāt trešo skaitli
Console.WriteLine("Lūdzu, ievadi trešo skaitli ");

//// 6. sagaidīt trešā skaitļa ievadi
int thirdNumber = int.Parse(Console.ReadLine());

//// 7. pajautāt ceturto skaitli
Console.WriteLine("Lūdzu, ievadi ceturto skaitli ");

//// 8. sagaidīt ceturtā skaitļa ievadi
int fourthNumber = int.Parse(Console.ReadLine());

//// 9. norādīt lietotājam lielāko skaitli
int firstMaxNumber = Math.Max(firstNumber, secondNumber);
int secondMaxNumber = Math.Max(thirdNumber, fourthNumber);
int maxNumber = Math.Max(firstMaxNumber, secondMaxNumber);

Console.WriteLine("Lielākais skaitlis ir " + maxNumber);

Console.WriteLine();
Console.WriteLine("===================================");
Console.WriteLine();

// 4. uzdevums
//// 1. pajautāt pirmo skaitli
Console.WriteLine("Lūdzu, ievadi pirmo skaitli ");

//// 2. sagaidīt pirmā skaitļa ievadi
int fifthNumber = int.Parse(Console.ReadLine());

//// 3. pajautāt otro skaitli
Console.WriteLine("Lūdzu, ievadi otro skaitli ");

//// 4. sagaidīt otrā skaitļa ievadi
int sixthNumber = int.Parse(Console.ReadLine());

//// 5. pajautāt trešo skaitli
Console.WriteLine("Lūdzu, ievadi trešo skaitli ");

//// 6. sagaidīt trešā skaitļa ievadi
int seventhNumber = int.Parse(Console.ReadLine());


//// 9. norādīt lietotājam lielāko skaitli
int firstMinNumber = Math.Min(fifthNumber, sixthNumber);
int secondMinNumber = Math.Min(firstMinNumber, seventhNumber);
int minNumber = Math.Min(firstMinNumber, secondMinNumber);

Console.WriteLine("Mazākais skaitlis ir " + minNumber);


Console.WriteLine();
Console.WriteLine("===================================");
Console.WriteLine();

// 5. uzdevums
//// 1. pajautāt pirmo skaitli
Console.WriteLine("Lūdzu, ievadi pirmo skaitli ");

//// 2. sagaidīt pirmā skaitļa ievadi
int eightNumber = int.Parse(Console.ReadLine());

//// 3. pajautāt otro skaitli
Console.WriteLine("Lūdzu, ievadi otro skaitli ");

//// 4. sagaidīt otrā skaitļa ievadi
int ninthNumber = int.Parse(Console.ReadLine());

//// 5. norādīt dalījuma atlikumu
///
var result = eightNumber % ninthNumber;
Console.WriteLine("Izvēlēto skaitļu dalījuma atlikums ir " + result);

Console.WriteLine();
Console.WriteLine("===================================");
Console.WriteLine();


// 6. uzdevums
//// 1. pajautāt lietotājam skaitli
Console.WriteLine("Lūdzu, ievadi skaitli ");

//// 2. sagaidīt skaitļa ievadīšanu
int number = int.Parse(Console.ReadLine());

//// 3. parādīt vai ievadītais skaitlis ir pāra vai nepāra skaitlis
bool isEven = number % 2 == 0;
Console.WriteLine("Ievadītais skaitlis ir pāra skaitlis " + isEven);


Console.WriteLine();
Console.WriteLine("===================================");
Console.WriteLine();

// 7. uzdevums
//// 1. pajautāt pirmo skaitli
Console.WriteLine("Lūdzu, ievadi taisnstūra pirmās malas garumu ");

//// 2. sagaidīt pirmā skaitļa ievadi
int tenthNumber = int.Parse(Console.ReadLine());

//// 3. pajautāt otro skaitli
Console.WriteLine("Lūdzu, ievadi taisnstūra otrās malas garumu ");

//// 4. sagaidīt otrā skaitļa ievadi
int eleventhNumber = int.Parse(Console.ReadLine());

//// 5. aprēķināt taisnstūra laukumu
int area = tenthNumber * eleventhNumber;
Console.WriteLine("Taisnstūra laukums ir " + area);


Console.WriteLine();
Console.WriteLine("===================================");
Console.WriteLine();

// 8. uzdevums
//// 1. pajautāt pirmo skaitli
Console.WriteLine("Lūdzu, ievadi trijstūra pirmās malas garumu ");

//// 2. sagaidīt pirmā skaitļa ievadi
double twelfthNumber = double.Parse(Console.ReadLine());

//// 3. pajautāt otro skaitli
Console.WriteLine("Lūdzu, ievadi trijstūra otrās malas garumu ");

//// 4. sagaidīt otrā skaitļa ievadi
double thirteenthNumber = double.Parse(Console.ReadLine());

//// 5. aprēķināt  taisnleņķa vienādsānu trijstūra laukumu 
double Area = twelfthNumber * thirteenthNumber / 2;
Console.WriteLine("Taisnleņķa vienādsānu trijstūra laukums ir " + Area);

Console.WriteLine();
Console.WriteLine("===================================");
Console.WriteLine();

// 9. uzdevums
//// 1. pajautā lietāja vārdu
Console.WriteLine("Kāds ir Tavs vārds ?");

//// 2. saigadīt vārda ievadi
string UserName = Console.ReadLine();

//// 3. pajautā lietotāja vecumu
Console.WriteLine("Kāds ir Tavs vecums ?");

//// 4. saigadīt vecuma ievadi
int UserAge = int.Parse(Console.ReadLine());

//// 5. izvada lietotājam vārdu un vecumu izmantojot interpolāciju
Console.WriteLine("Sveiks, " + UserName + ",Tavs vecums ir " + UserAge);