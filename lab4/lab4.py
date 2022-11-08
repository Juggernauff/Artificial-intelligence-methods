import matplotlib.pyplot as plt
import pandas as pnd
import numpy as nmp
import csv

def distance(x11, x12, x21, x22):
    return(abs(x11 - x21) ** 2 + abs(x12 - x22) ** 2) ** 0.5

"""Фрукт = 0; Овощ = 1; Протеин = 2"""

data = [['Продукт', 'Сладость', 'Хруст', 'Класс'],
        ['Яблоко', 7, 7, '0'],
        ['Банан', 9, 1, '0'],
        ['Виноград', 8, 1, '0'],
        ['Апельсин', 6, 1, '0'],
        ['Груша', 8, 2, '0'],
        ['Мандарин', 8, 1, '0'],
        ['Салат', 2, 5, '1'],
        ['Морковь', 3, 8, '1'],
        ['Огурец', 2, 6, '1'],
        ['Помидор', 3, 1, '1'],
        ['Свекла', 3, 2, '1'],
        ['Орехи', 1, 5, '2'],
        ['Бекон', 1, 2, '2'],
        ['Рыба', 1, 1, '2'],
        ['Сыр', 1, 1, '2']]

with open('dataframe.csv', 'w') as file:
    writer = csv.writer(file)
    for row in data:
        writer.writerow(row)

with open('dataframe.csv', 'r') as file:
    print(file.read())

new_dist = nmp.zeros((5, 10))
print(new_dist)

for i in range(5):
    for j in range(10):
        new_dist[i][j] = distance(int(data[i + 11][1]), int(data[i + 11][2]), int(data[j + 1][1]), int(data[j + 1][2]))
print(new_dist)

er_k = [0] * 10
for k in range(10):
    print('классификация для k = ', k + 1)
    klas = [0, 0, 0, 0, 0]
    er = [0, 0, 0, 0, 0]
    for i in range(5):
        qwant_dist = [0, 0, 0]
        print('классификация', data[i + 11][0])
        tmp = nmp.array(new_dist[i,:])
        for j in range(k + 1):
            ind_min = list(tmp).index(min(tmp))
            print(ind_min)
            qwant_dist[int(data[ind_min + i + 1][3])] += 1
            print(ind_min + i + 1, int(data[ind_min + i + 1][3]))
            tmp[ind_min] = 1000
            print(qwant_dist)
            max1 = max(qwant_dist)
            print(int(data[ind_min + i + 1][3]), int(data[i + 11][3]))
            if qwant_dist.count(max1) > 1:
                er[i] = 0.5
            elif (int(data[ind_min + i + 1][3])) != int(data[i + 11][3]):
                er[i] = 1
            print(er)
        er_k[k] = nmp.mean(er)
    print('errors', er_k)
    
    plt.plot([i for i in range(1,11)], er_k)
    plt.title('График ошибки в зависимости от k')
    plt.xlabel('k')
    plt.ylabel('error')
    plt.show()
    
    df = pnd.read_csv('dataframe.csv', encoding='cp1251')
    print(df)
    sweet = df['Сладость']
    crun = df['Хруст']
    print(sweet, crun)
    
    plt.scatter(sweet, crun)
    plt.show()
    