# ListNumbers

- Задача:
Есть массив целых чисел. Нужно найти в этом списке каждый индекс (отсчитываемый от нуля), который имеет следующее свойство:
Сумма целых чисел, предшествующих (но не включая) индексу, равна сумме целых чисел следующей (опять же не включая).
То есть: (Обратимся к нашему массиву целых чисел как «A[]» и число целых чисел в списке N) нам нужен каждый индекс, для которого
верно следующее:
A[0] + A[1] + ... +A[idx - 1] == A[idx + 1] + A[idx + 2]... +A[N]

В списке может быть более одного индекса, удовлетворяющего этому свойству.

Напишите код, который находит каждый индекс в массиве чисел, обладающий этим свойством.
Затем просуммируйте каждый индекс, который нашли.

Для справки: для массива [-7, 1, 5, 2, -4, 3, 0] ответом будет 9, потому что у индексов 3 и 6 есть недвижимость, которую мы ищем
7 + 1 + 5 == -4 + 3 + 0 и -7 + 1 + 5 + 2 + -4 + 3 == 0) => 3 + 6 = 9.

- Пояснения к запуску:
Необходимо выбрать тестовый файл с компьютера.
В текстовом файле должны идти числа через запятую и без пробелов.
