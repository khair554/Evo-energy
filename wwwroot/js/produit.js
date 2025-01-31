const productTypeSelect = document.getElementById('product-type');
const productNameSelect = document.getElementById('product-name');

const productNames = {
  panneaux_photovoltaiques: ['Alpha-T-370', 'Alpha-T-375', 'Alpha-T-400','Alpha-T-370',


  'AE505MD-132',
   'AE440MC-144',
   'AE445MC-144',
   'AE400MD-108',
   'AE450MD-120',
   'AE440MD-120',
   'AE415MD-108',
   'AE585ME-120',
   'AE590ME-120',
   'AE595ME-120',
   'AE600ME-120',
   'AE495MD-132',
   'AE500MD-132',
   'AE450MC-144',
   'AE530MD-144',
   'AE535MD-144',
   'AE540MD-144',
   'AE545MD-144',
   'AE550MD-144',
'AE450MC-144',
'DHM-72X10-550W',
'DHM-54X10-395W',
'DHM-54X10-400W',
'DHM-54X10-405W',
'DHM-54X10-410W',
'DHM-54X10-415W',
'HS-B120DSN390',
'HS-B144DS450',
'HS-B144DS455',
'HS-210-B132DS670',
'HS-210-B132DS675',
'AC-450MH/144V',
'AC-370MH/120V',
'AC-530MH/144V',
'AC-275P/60S',
'AC-540MH/144V',
'AC-545MH/144V',
'AC-400MH/108V',
'CS3Y-490MS',
'CS6W-545MS',
],
  onduleurs: ['UNO-DM-1.2-TL-PLUS',
  'UNO-DM-2.0-TL-PLUS',
  'UNO-DM-3.0-TL-PLUS',
  'UNO-DM-3.3-TL-PLUS',
  'UNO-DM-4.0-TL-PLUS',
  'UNO-DM-4.6-TL-PLUS',
  'UNO-DM-5.0-TL-PLUS',
  'UNO-DM-6.0-TL-PLUS',
  'UNO-DM-3.3-TL-PLUS-XYK-JVN(1)',
  'UNO-DM-4.0-TL-PLUS-XYK-JVN(1)',
  'UNO-DM-4.6-TL-PLUS-XYK-JVN(1)',
  'UNO-DM-5-TL-PLUS-XYK-JVN(1)',
  'UNO-DM-1.2-TL-PLUS-Q',
  'UNO-DM-2.0-TL-PLUS-Q',
  'UNO-DM-3.0-TL-PLUS-Q',
  'UNO-DM-3.3-TL-PLUS-Q',
  'UNO-DM-4.0-TL-PLUS-Q',
  'UNO-DM-4.6-TL-PLUS-Q',
  'UNO-DM-5.0-TL-PLUS-Q',
  'UNO-DM-6.0-TL-PLUS-Q',
  'TRIO-5.8-TL-OUTD',
  'TRIO-7.5-TL-OUTD',
  'TRIO-8.5-TL-OUTD',
  'PVI-10.0-TL-OUTD',
  'PVI-12.5-TL-OUTD',
  'TRIO-20.0-TL-OUTD',
  'TRIO-27.6-TL-OUTD',
  'PRO-33.0-TL-OUTD',
  'PVS-50-TL',
  'PVS-50-TL-S',
  'PVS-50-TL-SX',
  'PVS-50-TL-SX2',
  'PVS-100-TL',
  'AFORE HNS1000TL-1',
  'HNS1500TL-1',
  'HNS2000TL-1',
  'HNS2500TL-1',
  'HNS3000TL-1',
  'HNS3600TL',
  'HNS4000TL',
  'HNS5000TL',
  'HNS6000T',
  'DELTA RPI M30A',
  'DELTA RPI M50A',
  'DELTA M88H',
  'DELTA M50A_260',
  'DELTA M70A_260',
  'S1000',
  'S1500',
  'S2000',
  'S2500',
  'S3000',
  'S700-G2',
  'S1000-G2',
  'S1500-G2',
  'S2000-G2',
  'S2500-G2',],
  micro_onduleurs: ['INV315-50EU',
    'APsystems DS3',
    'DS3-L',
    'Omnik New Energy Omniksol-SMP300',
    'Omnik New Energy Omniksol-SMP600',
    'DEYE SUN300G3-EU-230',
    'DEYE SUN500G3-EU-230',
    'DEYE SUN600G3-EU-230',
    'DEYE SUN800G3-EU-230',
    'DEYE SUN1000G3-EU-230',
    'HOYMILES HM-300',
    'HOYMILES HM-350',
    'HOYMILES HM-400',
    'PEAK SOLAR PMI-300-Plus',
    'PEAK SOLAR PMI-500-Plus',
    'PEAK SOLAR PMI-600-Plus',
    'PEAK SOLAR PMI-800-Plus',
    'PEAK SOLAR PMI-1000-Plus',
    'TSUN TSOL-M350',
    'TSUN TSOL-M400',
    'TSUN TSOL-M800'],
  coffrets: ['AC', 'AC/DC'],
  lampes_solaires: ['Lanterne solaire rechargeable portable', 'Lampe solaire murale', 'Lampe solaire de jardin','Lampe solaire flottante','Lampadaire solaire'],
  batteries: ['SPW series', 'GSL Industrial & Commercial BESS-372K', ' PowerBase X1',' Lithium',' RENON EBrick ',' W5000 ',' LDP 24-100',' MOON5-R',' EStore ESI215-100K ',' EGS Series 15/20/30K',' T-one']
};

productTypeSelect.addEventListener('change', () => {
  const selectedProductType = productTypeSelect.value;
  const availableProductNames = productNames[selectedProductType] || [];  // Handle non-existent types

  productNameSelect.innerHTML = '';  // Clear previous options

  if (selectedProductType) {
    productNameSelect.disabled = false;  // Enable product name selection

    availableProductNames.forEach(productName => {
      const option = document.createElement('option');
      option.value = productName;
      option.textContent = productName;
      productNameSelect.appendChild(option);
    });
  } else {
    productNameSelect.disabled = true;  // Disable product name selection if no type is chosen
  }
});
