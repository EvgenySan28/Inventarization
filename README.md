# Инвентаризация  
Проект, показывающий навык работы с базой данных, в частности mysql при помощи entity framework core  
В проекте используется свободная библиотека компонентов Blazorize.  
Описание структуры представляющей интерес:
 - папка [data/db](https://github.com/EvgenySan28/Inventarization/tree/master/Inventarization/Data/DB) содержит класс контекста [MyDbContext.cs](https://github.com/EvgenySan28/Inventarization/blob/master/Inventarization/Data/DB/MyDbContext.cs)
 - папка [data/db/Entities](https://github.com/EvgenySan28/Inventarization/tree/master/Inventarization/Data/DB/Entities) содержит сущности базы данных.  
 - папка [Pages](https://github.com/EvgenySan28/Inventarization/tree/master/Inventarization/Pages) содержит [index.razor](https://github.com/EvgenySan28/Inventarization/blob/master/Inventarization/Pages/Index.razor) аналог index.html
 - папка [Pages/InventarizationPages](https://github.com/EvgenySan28/Inventarization/tree/master/Inventarization/Pages/InventarizationPages) содержит страницы, созданные для заполнения таблиц.
 - страница [NomenklaturePage.razor](https://github.com/EvgenySan28/Inventarization/blob/master/Inventarization/Pages/InventarizationPages/NomenklaturePage.razor) содержит страницу с выводом информации из базы и возможность отбора по комнате и ответственному. Так же есть кнопка вывода печатной формы, в которой убрано все лишнее оформление.  

Ссылка на рабочий пример https://inventarization.azurewebsites.net
