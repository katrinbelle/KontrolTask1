# **Итоговая проверочная работа**
## Задача
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше лиьо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать  на старте  выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
##  Описание решение задачи 
#### 
1. Создаем  два массива:
   * пустой массив *stringArray*, в который запишем строки от пользователя.  
   * пустой массив *stringQuantityUpToFour* , в который запишем  те данные, где символы <=3 из первого массива.
   * Создаем счетчик *count* для массива  *stringQuantityUpToFour*.
2. Получаем строки от пользователя. Провереям, чтобы данные были не пустые от пользователя. Если всё хорошо, делаем запись в массив, если пустое значение или нет символов больше 4 выводим сообщение  *Нет символов, где длина равна или меньше 3 в данном массиве !* . Разбивку делаем через *slip* .
3. Выводим массив  *stringArray* .
4. В цикле *for* делаем проверку, что символов **<=3** , количество циклов это длина самого массива.
* Если по условию совпадает , записываем строку в новый массив *stringQuantityUpToFour*. Прибавляем 1 к счетчику *count*/
* Если нет, переходим к следующему индексу массива *stringArray*.
1. После выхода из цикла выводим новый массив *stringQuantityUpToFour* на экран.


_______

## Ссылка на блок схему по работе кода [Блок-схема](https://1drv.ms/u/s!An6NyIQJ5LL7hSnWisLLjKx5sFDw?e=hRNfTg)