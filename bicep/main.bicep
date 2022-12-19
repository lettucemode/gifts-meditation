@description('Specifies the location for resources.')
param location string = resourceGroup().location

resource plan 'Microsoft.Web/serverfarms@2022-03-01' = {
  name: 'plan-giftsformeditation'
  location: location
  sku: {
    name: 'B1'
  }
  kind: 'linux'
  properties: {
    reserved: true
  }
}

resource webapp 'Microsoft.Web/sites@2022-03-01' = {
  name: 'giftsformeditation'
  location: location
  properties: {
    httpsOnly: true
    serverFarmId: plan.id
    siteConfig: {
      http20Enabled: true
      linuxFxVersion: 'DOTNETCORE|7.0'
      minTlsVersion: '1.2'
      ftpsState: 'Disabled'
    }
  }
  identity: {
    type: 'SystemAssigned'
  }
}
