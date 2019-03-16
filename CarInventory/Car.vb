Option Strict On

Public Class Car

    Private Shared carCount As Integer
    Private carIdentificationNumner As Integer
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As String = String.Empty
    Private carPrice As String = String.Empty
    Private newOld As Boolean = False
    Private priceCar As Decimal = 0.0D


    Public Sub New()
        carCount += 1
        carIdentificationNumner = carCount
    End Sub

    Public Sub New(make As String, model As String, year As String, price As String, isNew As Boolean)
        Me.New()

        carMake = make
        carModel = model
        carYear = year
        carPrice = price
        newOld = isNew
    End Sub


    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumner
        End Get
    End Property

    Public Property IsCarNew() As Boolean
        Get
            Return newOld
        End Get
        Set(ByVal value As Boolean)
            newOld = value
        End Set
    End Property

    ''''''''''''''''''''''''
    Public Property CarpMake() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    Public Property CarpPrice() As String
        Get
            Decimal.TryParse(carPrice, priceCar)
            priceCar = Math.Round(priceCar, 2)

            carPrice = FormatCurrency(priceCar.ToString())
            Return carPrice
        End Get
        Set(ByVal value As String)

            carPrice = value
        End Set
    End Property

    Public Property CarpModel() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    Public Property CarpYear() As String
        Get
            Return carYear
        End Get
        Set(ByVal value As String)
            carYear = value
        End Set
    End Property

End Class
