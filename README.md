# Горнолыжный курорт "Игора"

Данная программа предназначена для управления системой проката, работы с данными (добавление, удаление, редактирование), хранящимися в базе данных.

 # Начало работы
 Данный проект разработан на языке программирования C# с использованием технологии Windows Forms для создания интерфейса и пакета Microsoft.Data.SqlClient для работы приложения с базой данных на SQL-сервере.
 
 Для работы данного проекта необходима связь приложения с базой данных.
 Сама база данных, а точнее её резервная копия прикладывается к проекту в его папке.
 Её необходимо развернуть на сервере, используя Microsoft Sql Server Management Studio.
 Для этого необходимо в MSSQL Server Management Studio, в Обозревателе серверов, выбрать раздел "Базы данных", клинкнуть по нему ПКМ и нажать "Импорт приложения уровня данных"
 
 ![image](https://user-images.githubusercontent.com/70949553/222973287-875a0a95-9b29-4d32-ba13-7482025542d0.png)

Откроется мастер импорта приложения уровня базы данных

![image](https://user-images.githubusercontent.com/70949553/222973419-44ab58e0-3d96-492f-8024-a3146b472867.png)

Нажимаем "Далее"

![image](https://user-images.githubusercontent.com/70949553/222973458-4f2d2939-6f58-4348-b0b6-e3d25eb64407.png)

В данном окне необходимо указать путь до файла резервной копии базы данных


![image](https://user-images.githubusercontent.com/70949553/222973484-cbdd666e-2395-409c-a9c5-006edd154ba3.png)

![image](https://user-images.githubusercontent.com/70949553/222973494-37b3d7ea-86bf-4692-9180-9ee41050db28.png)

В данном разделе указывается подключение к серверу SQL и название базы данных. Необходимо ввести строку подключения (адрес сервера SQL в MSSQL Management Studio) и дать название вновь созданной базе данных и нажать кнопку "Далее"

![image](https://user-images.githubusercontent.com/70949553/222973607-801d47b2-1097-4ffa-aef2-4cbe056dbb8d.png)

В данном окне представлена сводка по параметрам добавления базы данных. Нажимаем "Готово"

![image](https://user-images.githubusercontent.com/70949553/222973857-c53ffe1d-1517-4ff7-b3d2-86fddb6a1d64.png)

Операция завершена!

![image](https://user-images.githubusercontent.com/70949553/222973886-97797119-ea06-4966-82af-28800bda5e4e.png)

Результат — резервная копия базы расположена на сервере и готова к использованию

![image](https://user-images.githubusercontent.com/70949553/222973970-b6004656-e68c-4d7f-8546-f872a134ada0.png)


# Что необходимо для работы
Для работы с базой данных требуется пакет Microsoft.Data.SqlClient.
Процесс установки следующий.

1. Открыть решение проекта (файл с расширением .sln) в Visual Studio, затем на панели меню выбрать раздел "Средства" -> "Диспетчер пакетов NuGet" -> "Управление пакетами NuGet для решения..."

![image](https://user-images.githubusercontent.com/70949553/222974416-b5af7bf9-4c1b-4462-95a8-29ea5bcf9299.png)


2. В разделе "Обзор" необходимо ввести "Microsoft.Data.SqlClient" для скачивания и установки данного пакета.

![image](https://user-images.githubusercontent.com/70949553/222974501-77aa49bd-2b98-4e2d-9e70-4fa127b5ce42.png)


3. По нажатию на него откроется меню установки пакета в проект

![image](https://user-images.githubusercontent.com/70949553/222974598-e1afb83c-0285-4c27-987f-4f015aaaef33.png)


4. Нажать кнопку "Установить", процесс запустится автоматически. При необходимости, перезапустить Visual Studio

После всех манипуляций данный проект готов к полноценному использованию.

# Важно!
При добавлении резервной копии базы данных на сервер указывать исходное имя — Igora, во избежание ошибок, которые потребуется решать посредством вмешательства в исходный код всех файлов и строку подключения в файле App.Config

# Автор
Минаков Павел aka vanga997