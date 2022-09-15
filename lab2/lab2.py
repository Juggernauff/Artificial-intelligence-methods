# Created by Danila Khodarev.
# Option: 20.

from math import floor, ceil
import matplotlib.pyplot as plt
import numpy

def printMatrix(matrix, matrixName = None, description = None):
    if (matrixName != None):
        print(f"====={matrixName}=====")
    else:
        print("=====NoNameMatrix=====")
    if (description != None):
        print(f'Description: {description}')
    print(matrix)
    print("================")

def createMatrix(n, m, minRandValue, maxRandValue):
    return numpy.random.randint(minRandValue, maxRandValue, size=(n, m))
def copyMatrix(matrix):
    return numpy.copy(matrix)
try:
    n = int(input('Введите N: '))
    k = int(input('Введите K: '))
    matrixA = createMatrix(n, n, -10, 11)
    matrixF = copyMatrix(matrixA)
    printMatrix(matrixA, "MatrixA")
    printMatrix(matrixF, "MatrixF", "Copying matrix A.")

    numNumbers = 0
    proNumbers = 1

    for i in range(0, ceil(n / 2)):
        for j in range(0, ceil(n / 2)):
            if (j % 2 == 0 and matrixF[i][j] > k):
                numNumbers += 1
            if (i % 2 == 1):
                proNumbers *= matrixF[i][j]

    if (numNumbers > proNumbers):
        for i in range(0, ceil(n / 2)): # Symmetrical swap C and E.
            for j in range(0, ceil(n / 2)):
                matrixF[i][j], matrixF[n - 1 - j][n - 1 - i] = matrixF[n - 1 - j][n - 1 - i], matrixF[i][j]
        printMatrix(matrixF, "MatrixF", "Symmetrical swap C and E.")
    else:
        for i in range(0, ceil(n / 2)): # Non-symmetrical swap C and B.
            for j in range(floor(n / 2), n):
                matrixF[i][j], matrixF[floor(n / 2) + i][j] = matrixF[floor(n / 2) + i][j], matrixF[i][j]
        printMatrix(matrixF, "MatrixF", "Non-symmetrical swap C and B.")

    detA = numpy.linalg.det(matrixA)
    print(f"DetA = {detA}.")
    sumDiagonalElements = numpy.trace(matrixF)
    print(f"Sum of diagonal elements = {sumDiagonalElements}.")
    result = 0
    if (detA > sumDiagonalElements):
        result = matrixA * matrixA.transpose() - k * numpy.linalg.matrix_power(matrixF, -1)
        printMatrix(matrixA.transpose(), "MatrixA", "Transposition.")
        printMatrix(numpy.linalg.matrix_power(matrixF, -1), "MatrixF", "Exponentiation to -1.")
    else:
        result = (numpy.linalg.matrix_power(matrixA, -1) + numpy.tril(matrixA) - numpy.linalg.matrix_power(matrixF, -1)) * k
        printMatrix(numpy.linalg.matrix_power(matrixA, -1), "MatrixA", "Exponentiation to -1.")
        printMatrix(numpy.tril(matrixA), "MatrixA", "Lower triangular matrix.")
        printMatrix(numpy.linalg.matrix_power(matrixF, -1), "MatrixF", "Exponentiation to -1.")
    print(f"Result = {result}.")
    
    plt.plot(matrixF)         # Graph 1.
    plt.show()

    for i in range(0, n):     # Graph 2.
        for j in range(0, n):
            plt.bar(i, matrixF[i][j])
    plt.show()

    x = numpy.arange(0, n, 1) # Graph 3.
    f0 = matrixF[0]
    a0 = matrixA[0]
    labels = ["F[0]", "A[0]"]
    fig, ax = plt.subplots()
    ax.stackplot(x, f0, a0, labels=labels)
    ax.legend(loc='upper left')
    plt.show()

except:
    print('[EXCEPT] An unknown exception has been encountered!')