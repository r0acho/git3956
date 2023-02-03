## Инструкция пользователя для настройки Git (GB Разработчик)

1. Скачайте и установите Git c ресурса [GIT](https://git-scm.com/ "https://git-scm.com/")

   * Используйте версию для своей операционной системы  

   * Следуйте указаниям установщика.  

### Создание репозитория
1. Перейдите в рабочую папку проекта, откройте с помощью контекстного меню терминал:  

> ![Рис.1][pic-2-1]

   Выполните команды:  
  `git status` - если результатом будет какая-нибудь из ошибок, выполните следующую команду  
  `git init`  
   
____
## Создание файла проекта

   Создайте файл проекта в рабочей папке
   > **Имя файла:** impress  
   > **Расширение:** mdа

   Оформите что-нибудь по своему усмотрению.  
### Сохранение результатов  
Проверьте результат после сохранения файла командой   
`git status` - результат должен быть следующим:  
<html>
<ol>
Untracked files:<br>
<ol>
    <p style="color:orange">project_file_name.ext</p>
</ol>
nothing added to commit but untracked files present (use "git add" to track)<br>   
</ol>
</html>
Добавьте созданный файл в репозиторий командой  

* `git add .\project_file_name.ext`  

Сохраните результаты своей работы командой  

* `gıt commit -m 'commit message'`  

Просмотрите свои коммиты:  

* `git log`  

 Попробуйте переключить на предыдущий коммит:  

* `git checkout 611a`  

Переключитесь на основное состояние репозитория  

* `git checkout master`
___
## Другие команды Git

Просмотреть различия между актуальными версиями файла и файлами в репозитории  

* `git diff`

Не забывайте про коммиты!:  
`git commit -a -m 'final'`  
![pic-2-2]

## Основные команды 2-го семинара  
Команда выводит лог в усеченном режиме
* `git log --oneline`    

Создание ветки и переключение на нее  

* `git checkout -b <name_new_branch>`  

Переименование ветки  

* `git branch -m <old_name> <new_name>`  

Создание конфликта версий перед слияниемThis line will generate a conflict **result of combine two differences**  

Отмена слияния веток и ручное исправление конфликта в файлах
* `git merge --abort`  

Восстановление удаленной ветки
* `git branch <name_deleted_branch> <sh1_code_deleted_branch>`

## Команды 3-го семинара

* Создание нового репозитория на GitHub
* Добавляем созданный удаленный репо в текущий локальный

`git remote set-url origin https://github.com/zzergAtStage/git3956.git`  

* Rename local branch  
`git branch -M main`  

* Push local repository

`git push -u origin main`

* making a new clone
   adding new folder (not parent directory!)  
   `git clone <url>`  

[pic-2-1]: 2-1.jpg
[pic-2-2]: 2-2.jpg