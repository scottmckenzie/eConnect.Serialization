dotnet tool install --global dotnet-xscgen
$Namespace = 'eConnect.Serialization'
xscgen -n =$Namespace --output=$Namespace --collectionType='System.Collections.Generic.List`1' eConnect.xsd
