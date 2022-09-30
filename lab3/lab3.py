import os
import csv

FILE_PATH = os.path.abspath('lab3\\titanic.csv')

# Part 1.
print('========== Part 1 ==========')
with open(FILE_PATH, 'r') as file:
    reader = csv.reader(file)
    # Statistical data
    fares = []
    fareMax = 0
    fareMin = 0
    fareSum = 0
    numberEntries = 0
    medianFare = 0

    for line in reader:
        try:
            fares.append(float(line[9]))
            numberEntries += 1
            fareSum += fares[-1]
            if (fareMin > fares[-1]):
                fareMin = fares[-1]
            if (fareMax < fares[-1]):
                fareMax = fares[-1]
            print(line)
        except:
            continue
        
    centralIndex = int(len(fares) / 2)
    if (len(fares) % 2 == 1):
        medianFare = fares[centralIndex]
    else:
        medianFare = (fares[centralIndex] + fares[centralIndex - 1]) / 2

    print(f'Number of tickets: {numberEntries}\n' +
        f'Maximum fare: {fareMax}\n' +
        f'Minimum fare: {fareMin}\n' +
        f'Total fare: {fareSum}\n' +
        f'Average ticket price: {fareSum / numberEntries}\n' +
        f'Median fare: {medianFare}')

# Part 2.
print('========== Part 2 ==========')
import pandas as pnd

# Settings / Config
pnd.set_option('display.max_rows', None)
pnd.set_option('display.max_columns', None)
pnd.set_option('display.max_colwidth', None)

dataFrame = pnd.read_csv(FILE_PATH)
print('Number of tickets: ' + str(dataFrame['PassengerId'].count()))
print('Maximum fare: ' + str(dataFrame['Fare'].max()))
print('Minimum fare: ' + str(dataFrame['Fare'].min()))
print('Total fare: ' + str(dataFrame['Fare'].sum()))
print('Average ticket price: ' + str(dataFrame['Fare'].mean()))
print('Median fare: ' + str(dataFrame['Fare'].median()))
print(dataFrame.describe([.20, .40, .60, .80]))
print('===== DEAD CHILDREN =====')
print(dataFrame.query("Age < 18 & Survived == 0"))
print('=== Age / Count ===')
dataFrame1 = dataFrame.query("Age < 18 & Survived == 0")
print(dataFrame1.groupby('Age')['PassengerId'].count())