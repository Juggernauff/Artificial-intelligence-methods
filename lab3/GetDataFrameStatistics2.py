from pathlib import Path
import pandas as pnd

# Settings / Config
# pnd.set_option('display.max_rows', None)
# pnd.set_option('display.max_columns', None)
# pnd.set_option('display.max_colwidth', None)

path = Path(Path.cwd(), 'lab3', 'dataFrame.csv')
dataFrame = pnd.read_csv(path, encoding='utf-16')
print('Number of salaries: ' + str(dataFrame['Табельный номер'].count()))
print('Maximum salary: ' + str(dataFrame['Оклад'].max()))
print('Minimum salary: ' + str(dataFrame['Оклад'].min()))
print('Sum of salaries: ' + str(dataFrame['Оклад'].sum()))
print('Arithmetic mean of salaries: ' + str(dataFrame['Оклад'].mean()))
print('Median salaries: ' + str(dataFrame['Оклад'].median()))
print(dataFrame.describe([.20, .40, .60, .80]))
print('==========RAISE SALARY==========')
print(dataFrame.query(f"Оклад < {dataFrame['Оклад'].mean()} & `Количество выполненных проектов` > 5"))