' Author: Scott Alton
' Last Modified: March 11, 2020
' Description: This class represents the car objects that will be used for the CarInventory application that will be built
'              for Lab #4.

Option Strict On

Public Class Car

    ' VARIABLE DECLARATIONS
    Private Shared carCount As Integer = 0
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As Integer = 0
    Private carPrice As Decimal = 0.0D
    Private carNewStatus As Boolean = True


    ' CONSTRUCTORS

    ''' <summary>
    ''' Default Constructor - increments carCount and leave all other properties as default values
    ''' </summary>
    Friend Sub New()

        carCount += 1
        carIdentificationNumber = carCount

    End Sub

    ''' <summary>
    ''' Parameterized Constructor - sets all arguments based on what is passed in 
    ''' </summary>
    ''' <param name="makeValue">a car's manufacturer</param>
    ''' <param name="modelValue">a car's model</param>
    ''' <param name="yearValue">car's year made</param>
    ''' <param name="priceValue">car's price</param>
    ''' <param name="newValue">whether the car is new or not</param>
    Friend Sub New(makeValue As String, modelValue As String, yearValue As Integer, priceValue As Decimal, newValue As Boolean)

        Me.New()

        carMake = makeValue
        carModel = modelValue
        carYear = yearValue
        carPrice = priceValue
        carNewStatus = newValue

    End Sub

    ' PROPERTY PROCEDURES

    ''' <summary>
    ''' Returns the number of car objects that have been instantiated 
    ''' </summary>
    ''' <returns></returns>
    Friend Shared ReadOnly Property Count As Integer
        Get
            Return carCount
        End Get
    End Property


    ''' <summary>
    ''' Returns the car's unique identification number
    ''' </summary>
    ''' <returns></returns>
    Friend ReadOnly Property Id As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' Returns the car's manufacturer
    ''' </summary>
    ''' <returns>car's manufacturer as a string</returns>
    Friend Property Make As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' Returns the car's model
    ''' </summary>
    ''' <returns>car's model as a string</returns>
    Friend Property Model As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' Returns the car's year of manufacturing
    ''' </summary>
    ''' <returns>car's year as an integer</returns>
    Friend Property Year As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Returns the car's price
    ''' </summary>
    ''' <returns>car's price as a decimal</returns>
    Friend Property Price As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' Returns whether or not the car is in new condition
    ''' </summary>
    ''' <returns>whether the car is new or not as a boolean</returns>
    Friend Property IsNew As Boolean
        Get
            Return carNewStatus
        End Get
        Set(value As Boolean)
            carNewStatus = value
        End Set
    End Property

    ' METHODS 

    ''' <summary>
    ''' A string describing the car's specifications for sale
    ''' </summary>
    ''' <returns>A string describing the car's specifications for sale</returns>
    Friend Function GetCarData() As String
        Return IIf(carNewStatus, "New ", "Used ").ToString & carYear & " " & carMake & " " & carModel & " on sale for " & carPrice.ToString("c")
    End Function
End Class
