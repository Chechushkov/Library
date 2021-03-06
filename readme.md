        Система электронной библиотеки.

Система управления библиотекой - это программное обеспечение, предназначенное для выполнения основных служебных функций библиотеки.
Система управления библиотеками помогают библиотекам отслеживать книги и их кассовые сборы, а также подписки и профили участников.
Система управления библиотекой также включают ведение базы данных для ввода новых книг и книг с записями, которые были заимствованы с соответствующими сроками.

1. Любой член библиотеки должен иметь возможность искать книги по названию, автору, тематической категории, а также по дате публикации.

2. Каждая книга будет иметь уникальный идентификационный номер и другие детали, включая номер стеллажа, который поможет физически найти книгу.

3. Может быть несколько экземпляров книги, и члены библиотеки должны иметь возможность выписать и зарезервировать любой экземпляр. Мы будем называть каждый экземпляр книги книжным предметом.

4. Система должна иметь возможность получать информацию, например, кто взял ту или иную книгу или какие книги были извлечены конкретным членом библиотеки.

5. Должен быть установлен максимальный лимит (5) на количество книг, которые участник может выписать.

6. Должно быть установлено максимальное количество дней (10), в течение которых участник может хранить книгу.

7. Система должна иметь возможность взимать штрафы за книги, возвращенные после установленного срока.

8. Участники должны иметь возможность резервировать книги, которые в настоящее время недоступны.

9. Система должна иметь возможность отправлять уведомления всякий раз, когда зарезервированные книги становятся доступными, а также когда книга не возвращается в установленный срок.

10. Каждая книга и членская карта будут иметь уникальный штрих-код. Система сможет считывать штрих-коды с книг и библиотечных карточек участников.


        Диаграмма вариантов использования #
В нашей системе есть три основных участника:

1. Библиотекарь: в основном отвечает за добавление и изменение книг, элементов книг и пользователей. Библиотекарь также может выдавать, резервировать и возвращать книги.
2. Клиент: все клиенты могут выполнять поиск в каталоге, а также оформлять заказ, резервировать, обновлять и возвращать книгу.
3. Система: в основном отвечает за отправку уведомлений о просроченных книгах, отмененных бронированиях и т.д.

       Основные варианты использования системы управления библиотеками:

- Добавить / удалить / изменить книгу: чтобы добавить, удалить или изменить книгу или атрибут книги.
- Каталог поиска: для поиска книг по названию, автору, теме или дате публикации.
- Регистрация новой учетной записи / отмена членства: чтобы добавить нового клиента или отменить членство существующего клиента.
- Получение книги: взять книгу в библиотеке.
- Зарезервировать книгу: чтобы зарезервировать книгу, которая в настоящее время недоступна.
- Продлить пользование книгой: продление пользовани уже взятой книги.
- Вернуть книгу: вернуть в библиотеку книгу, выданную клиенту.


      Диаграмма классов
- Library: центральная часть организации, для которой было разработано это программное обеспечение. У него есть такие атрибуты, как «Имя», чтобы отличать его от других библиотек, и «Адрес», чтобы описать его местонахождение.

- Book: основной строительный блок системы. У каждой книги будет ISBN, название, тема, издатели и т.д.

- BookItem: Любая книга может иметь несколько копий, каждая копия будет считаться книгой в нашей системе. Каждый предмет книги будет иметь уникальный штрих-код.

- Account: У нас будет два типа учетных записей в системе: одна будет общим членом, а другая - библиотекарем.

- LibraryCard: каждому пользователю библиотеки будет выдана библиотечная карта, которая будет использоваться для идентификации пользователей при выдаче или возврате книг.

- BookReservation: отвечает за управление бронированием книг.

- BookLending: Управляйте выпиской из книг.

- Catalog: каталоги содержат список книг, отсортированных по определенным критериям. Наша система поддерживает поиск по четырем каталогам: Название, Автор, Тема и Дата публикации.

- Fine: этот класс будет отвечать за расчет и сбор штрафов с членов библиотеки.

- Author: этот класс инкапсулирует автора книги.

- Rack: книги будут размещены на стеллажах. Каждая стойка будет идентифицироваться по номеру стойки и иметь идентификатор местоположения, описывающий физическое расположение стойки в библиотеке.

- Notification: этот класс позаботится об отправке уведомлений членам библиотеки.