# chat

Контрольные вопросы 2

1. Перечислите основные разновидности клиент-серверной архитектуры? 
Разновидности двухуровневой архитектуры клиент-сервер
- Архитектуры файл-сервера (толстый клиент). 
- Клиент-сервер базы данных 
Трехзвенная архитектура клиент-сервер

2. Опишите стек протоколов, используемых при организации клиент-серверной архитектуры?

Взаимодействие клиента и сервера обеспечивается коммуникационным программным обеспечением. Примерами такого программного обеспечения являются набор протоколов TCP/IP, - протоколы OSI, а также различные фирменные архитектуры, вродеSNA. Разумеется, назначение всего этого программного обеспечения поддержки (протоколов и операционной системы) заключается в предоставлении базы для распределенных приложений.

3. Какие компоненты платформы .NET используются для прослушивания входящих подключений на определённом порте?

Класс TcpListener прослушивает входящие подключения по определенному порту.

Для создания объекта слушателя надо передать ему в конструктор объект IPAddress и порт, по которому будет вестись прослушивание входящих подключений:

Для запуска сервера вызывается метод Start().

Когда к серверу обращается клиент, то мы можем использовать один из двух методов AcceptSocket или AcceptTcpClient для получения соответственно объекта Socket или TcpClient, которые будут использоваться для взаимодействия с подключенным клиентом.

Методы AcceptSocket и AcceptTcpClient блокируют выполняющий поток, пока сервер не обслужит подключенного клиента. Затем через методы, определенные в классах TcpClient и Socket, можно взаимодействовать с подключенным клиентом: получать от него данные или, наоборот, отправлять ему.

В конце по завершению работы сервера надо вызвать метод Stop().

4. Что такое потоки в программировании?

В программировании поток (stream) — это логическое устройство, предусматривающее:

· потребление (получение) информации. В этом случае определяют термин поток ввода;

· выработка (передача) информации. В этом случае определяют термин поток вывода.

Поток представляет собой абстракцию, которая обеспечивает ввод/вывод информации в программе.

5. Как реализуются потоки в языке C#?

Перво-наперво для работы с потоками в C# необходимо подключить специальную директиву: using System.Threading;

Именно она позволяет нам реализовывать необходимые потоки и их настройку.

Дальше стоит понять, что любой поток в C# должен обязательно происходить в каком-либо методе или функции, поэтому для работы с новым потоком необходимо сначала создать для него, например, метод, который и будет точкой входа для этого потока.

Для примера создадим пустой метод под именем fornewthread, который ничего не возвращает:

static void fornewthread()

{ //в действительности здесь должны находиться инструкции, которые будут выполняться в нашем новом потоке}

Теперь мы можем создать сам поток (например, в главном методе Main). Назовём его mythread:

Thread mythread = new Thread(fornewthread);


Контрольные вопросы 3

1. Опишите механизм построения графического пользовательского интерфейса в платформе .NET.

В платформе .NET для реализации графического интерфейса используются разные технологии, такие как Windows Forms и Windows Presentation Foundation (WPF). В пособии рассматривается только технология Windows Forms. Данная технология включает множество типов (классы, структуры, перечисления, делегаты), которые объединены в два основных пространства имен System.Windows.Forms (для реализации элементов интерфейса) и System.Drawing (для рисования в клиентской области).

Основными элементами графического интерфейса являются специальные классы, называемые элементами управления (ЭУ), которые обладают двумя особенностями:

1) реализуют работу с различными типами окон ОС Windows;

2) поддерживают работу в двух режимах:

• режим проектирования (design mode), в котором с ними работает среда разработки;

• режим выполнения (run mode), в котором выполняется взаимодействие пользователей с ЭУ.

Базовым классом для всех элементов управления является класс Control, реализующий самую базовую функциональность. Класс Control задает важные свойства, методы и события, наследуемые всеми его потомками. Все классы элементов управления (ЭУ) являются наследниками класса Control. Базовый класс Control содержит достаточно большой интерфейс (79 свойств, 56 методов, 67 событий), который доступен во всех производных классах.

2. Опишите принцип работы делегатов в языке C#.

Делегаты в C# подобны функциональным указателям в C или C++. Они объявляются в качестве объектов, содержащих адрес метода. Делегаты — референсный класс, инкапсулирующий метод со специфичной сигнатурой и типом возвращаемого значения.

«Делегат ссылается на метод и после назначения метода ведёт себя идентично ему. Делегат можно использовать как любую функцию с параметром и возвращаемым значением», — официальная документация MSDN.

Несмотря на то, что .NET использует концепцию функционального указателя посредством делегатов, есть несколько существенных отличий:

делегаты нечувствительны к ошибкам ввода;

объектно-ориентированы;

безопасны.

Делегаты C# обладают следующими свойствами:

позволяют обрабатывать методы в качестве аргумента;

могут быть связаны вместе;

несколько методов могут быть вызваны по одному событию;

тип делегата определяется его именем;

не зависят от класса объекта, на который ссылается;

сигнатура метода должна совпадать с сигнатурой делегата.

3. Опишите механизм обновления пользовательского интерфейса из параллельного потока.

Чтобы обновить пользовательский интерфейс из параллельного потока нужно использовать делегат Invoke.

Invoke(Delegate)

Выполняет указанный делегат в том потоке, которому принадлежит базовый дескриптор окна элемента управления.

Invoke(Delegate, Object[])

Выполняет указанный делегат в том потоке, которому принадлежит основной дескриптор окна элемента управления, с указанным списком аргументов.
