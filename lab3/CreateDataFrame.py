from pathlib import Path
import random as rnd
import csv

subdivisions = []
jobTitles = []
fullNames = {}
genders = []

def getGenders():
    path = Path(Path.cwd(), 'lab3', 'random', 'genders.txt')
    with open(path, 'r') as file:
        for line in file:
            genders.append(line.strip())

def getSubdivisions():
    path = Path(Path.cwd(), 'lab3', 'random', 'subdivisions.txt')
    with open(path, 'r') as file:
        for line in file:
            subdivisions.append(line.strip())

def getJobTitles():
    path = Path(Path.cwd(), 'lab3', 'random', 'jobTitles.txt')
    with open(path, 'r') as file:
        for line in file:
            jobTitles.append(line.strip())

def getFullNames():
    try:
        for gender in genders:
            mainPath = Path(Path.cwd(), 'lab3', 'random', gender)
            lastNames = []
            firstNames = []
            middleNames = []
            tmpFullNames = []
            with open(Path(mainPath, 'lastNames.txt'), 'r') as file:
                for line in file:
                    lastNames.append(line.strip())
            with open(Path(mainPath, 'firstNames.txt'), 'r') as file:
                for line in file:
                    firstNames.append(line.strip())
            with open(Path(mainPath, 'middleNames.txt'), 'r') as file:
                for line in file:
                    middleNames.append(line.strip())
            for lastName in lastNames:
                for firstName in firstNames:
                    for middleName in middleNames:
                        tmpFullNames.append(lastName + ' ' + firstName + ' ' + middleName)
            fullNames[gender] = tmpFullNames
    except:
        pass

def getData():
    getGenders()
    getFullNames()
    getJobTitles()
    getSubdivisions()

def createDataFrame(numberOfValue):
    getData()
    path = Path(Path.cwd(), 'lab3', 'dataFrame.csv')
    with open(path, 'w', encoding = 'utf-16', newline='') as file:
        fieldtitles = [
            'Табельный номер',
            'Фамилия И.О.',
            'Пол',
            'Год рождения',
            'Год начала работы в компании',
            'Подразделение',
            'Должность',
            'Оклад',
            'Количество выполненных проектов'
        ]
        writer = csv.DictWriter(file, fieldnames = fieldtitles)
        writer.writeheader()
        for i in range(1, numberOfValue + 1):
            gender = rnd.choice(genders)
            fullName = rnd.choice(fullNames[gender])
            yearOfBirth = rnd.randint(1980, 2000)
            yearOfStartingWorkInTheCompany = rnd.randint(yearOfBirth + 18, yearOfBirth + 22)
            subdivision = rnd.choice(subdivisions)
            jobTitle = rnd.choice(jobTitles)
            salary = rnd.randrange(20000, 250000, 5000)
            numberOfCompletedProjects = rnd.randint(2, 12)
            writer.writerow({
                'Табельный номер': i,
                'Фамилия И.О.': fullName,
                'Пол': gender,
                'Год рождения': yearOfBirth,
                'Год начала работы в компании': yearOfStartingWorkInTheCompany,
                'Подразделение': subdivision,
                'Должность': jobTitle,
                'Оклад': salary,
                'Количество выполненных проектов': numberOfCompletedProjects
            })

try:
    value = int(input('Введмте желаемое количество записей: '))
    createDataFrame(value)
except:
    print('Error!')