# VolumePlanning4.8

VolumePlanning: Общий проект с интерфейсом для работы с алгоритмом Агмона-Моцкина и решения задачи объёмного планирования

Agmon_Motzkin: Реализация метода Агмона-Моцкина приближённого решения системы линейных двусторонних неравенств с проверкой на совместность

SLAN: Библиотека с неравенствами, системами неравенствами и алгебраическим вектором с вещественными коэффициентами

GeneraliezedSystem: Реализация алгоритма решения задачи объёмного планирования с заданными предпочтениями

Формат входных данных (.txt):

Для Агмона-Моцкина:
Первая строка – пара чисел: n = количество неизвестных и m = количество неравенств. 
В последующих m строках записана матрица коэффициентов А системы.
В последней строке записан вектор правых частей b.

Для задачи объёмного планирования:
Первая строка – пара чисел: n = количество неизвестных, m = количество контролируемых ограничений.
В последующих m строках записаны контролируемые ограничения мат. модели в следующем формате:
A | C | B | [A, B] [A_2,B_2] … [A_p,B_p]
Далее до конца файла записаны двусторонние ограничения мат. модели в следующем формате:
A | C | B
И односторонние ограничения мат. модели в следующем формате:
A | C
В вышеописанных форматах: A – целое число, минимум ограничения; C – вектор размерности n, коэффициенты перед неизвестными; B – целое число, максимум ограничения. Допускается любое количество пробелов в строке. Предполагается, что первое из контролируемых ограничений наиболее «значимое», а последнее – наименее «значимое».
Количество вложенных отрезков в первых m ограничениях может быть произвольным, однако первый из них обязан быть [A,B] и каждый последующий отрезок должен быть вложен в предыдущий. Предполагается, что первый отрезок – «наихудший», последний – «наилучший». Для записи отрезков допустимо использование круглых скобок и\или отсутствие скобок. 
