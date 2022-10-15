from pathlib import Path
import numpy as nmp
import csv

def getDataFrameStatistics():
    path = Path(Path.cwd(), 'lab3', 'dataFrame.csv')
    with open(path, 'r', encoding = 'utf-16') as file:
        genders = []
        salaries = []
        yearOfBirth = []
        reader = csv.reader(file)
        for line in reader:
            try:
                genders.append(line[2]) # Добавление гендеров.
                yearOfBirth.append(int(line[3])) # Добавление года рождения.
                salaries.append(int(line[7])) # Добавление оклада.
            except:
                continue

        # Type - Gender.
        print('==========GENDER==========')
        print(f'Number of genders: {nmp.count_nonzero(genders)}')
        print(f'Maximum length of the name of the genger: {nmp.max(nmp.char.str_len(genders))}')
        print(f'Minimum length of the name of the genger: {nmp.min(nmp.char.str_len(genders))}')

        # Type - yearOfBirth.
        print('==========YearOfBirth==========')
        print(f'The youngest employee: {nmp.max(yearOfBirth)}')
        print(f'The oldest employee: {nmp.min(yearOfBirth)}')
        print(f'Average age of the employee: {nmp.average(yearOfBirth)}')

        # Type - Salary.
        print('==========SALARY==========')
        print(f'Number of salaries: {nmp.count_nonzero(salaries)}')
        print(f'Maximum salary: {nmp.max(salaries)}')
        print(f'Minimum salary: {nmp.min(salaries)}')
        print(f'Sum of salaries: {nmp.sum(salaries)}')
        print(f'Arithmetic mean of salaries: {round(nmp.mean(salaries), 2)}')
        print(f'Median salaries: {nmp.median(salaries)}')
        print(f'Salary scale: {nmp.max(salaries) - nmp.min(salaries)}')
        print(f'Salary variance: {nmp.var(salaries)}')
        print(f'Standard deviation: {nmp.std(salaries)}')

getDataFrameStatistics()