\
\ @file dac.fs
\ @brief DAC address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DAC_DEF

  [ifdef] DAC_CR_DEF
    \
    \ @brief CR register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DAC_EN                         \ [0x00] EN: DAC channel enable This bit is set and cleared by software to enable/disable DAC channel. 0: DAC channel disabled 1: DAC channel enabled
    $01 constant DAC_BON                        \ [0x01] BON: DAC channel output buffer enable. This bit is set and cleared by software to enable/disable DAC channel output buffer. 0: DAC channel output buffer disabled 1: DAC channel output buffer enabled
    $02 constant DAC_TEN                        \ [0x02] TEN: DAC channel trigger enable This bit is set and cleared by software to enable/disable DAC channel trigger. 0: DAC channel trigger disabled and data written into the DAC_DHR register are transferred one APB0 clock cycle later to the DAC_DOR register 1: DAC channel trigger enabled and data from the DAC_DHR register are transferred three APB0 clock cycles later to the DAC_DOR register Note: When software trigger is selected, the transfer from the DAC_DHR register to the DAC_DOR register takes only one APB0 clock cycle.
    $03 constant DAC_TSEL                       \ [0x03 : 3] TSEL[2:0]: DAC channel trigger selection These bits select the external event used to trigger DAC channel. 000: Timer 16 TRGO event 001: PA8 pin event from SYSCFG 010 to 011: Reserved 111: Software trigger Only used if bit TEN = 1 (DAC channel trigger enabled).
    $06 constant DAC_WAVE                       \ [0x06 : 2] WAVE[1:0]: DAC channel noise/triangle wave generation enable These bits are set and cleared by software. 00: wave generation disabled 01: Noise wave generation enabled 1x: Triangle wave generation enabled Note: Only used if bit TEN = 1 (DAC channel trigger enabled).
    $08 constant DAC_MAMP                       \ [0x08 : 4] MAMP[3:0]: DAC channel mask amplitude selector These bits are written by software to select mask in wave generation mode or amplitude in triangle generation mode. 0000: Unmask bit0 of LFSR triangle amplitude equal to 1 0001: Unmask bits[1:0] of LFSR triangle amplitude equal to 3 0010: Unmask bits[2:0] of LFSR triangle amplitude equal to 7 0011: Unmask bits[3:0] of LFSR triangle amplitude equal to 15 0100: Unmask bits[4:0] of LFSR triangle amplitude equal to 31 greater than or equal to 0101: Unmask bits[5:0] of LFSR triangle amplitude equal to 63
    $0c constant DAC_DMAEN                      \ [0x0c] DMAEN: DAC channel DMA enable This bit is set and cleared by software. 0: DAC channel DMA mode disabled 1: DAC channel DMA mode enabled
    $0d constant DAC_DMAUDRIE                   \ [0x0d] DMAUDRIE: DAC channel DMA Underrun Interrupt enable This bit is set and cleared by software. 0: DAC channel DMA Underrun Interrupt disabled 1: DAC channel DMA Underrun Interrupt enabled
    $0e constant DAC_CMPEN                      \ [0x0e] CMPEN: DAC channel output to COMP INMINUS enable. This bit is set and cleared by software. 0: DAC channel output to COMP INMINUS disabled 1: DAC channel output to COMP INMINUS enabled
    $0f constant DAC_VCMEN                      \ [0x0f] VCMEN: DAC channel output to VCM BUFFER enable. This bit is set and cleared by software. 0: DAC channel output to VCM BUFFER disabled 1: DAC channel output to VCM BUFFER enabled
    $10 constant DAC_VCMON                      \ [0x10] VCMON: VCMBUFF power-up. This bit is set and cleared by software. 0: VCM BUFFER OFF 1: VCM BUFFER ON
  [then]


  [ifdef] DAC_SWTRIGR_DEF
    \
    \ @brief SWTRIGR register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DAC_SWTRIG                     \ [0x00] SWTRIG: DAC channel software trigger This bit is set by software to enable/disable the software trigger. 0: Software trigger disabled 1: Software trigger enabled Note: This bit is cleared by hardware (one APB0 clock cycle later) once the DAC_DHR register value has been loaded into the DAC_DOR register.
  [then]


  [ifdef] DAC_DHR_DEF
    \
    \ @brief DHR register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACDHR                     \ [0x00 : 6] DACDHR[5:0]: DAC channel 6-bit data These bits are written by software which specifies 6-bit data for DAC channel.
  [then]


  [ifdef] DAC_DOR_DEF
    \
    \ @brief DOR register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACDOR                     \ [0x00 : 6] DACDOR[5:0]: DAC channel data output These bits are read-only, they contain data output for DAC channel.
  [then]


  [ifdef] DAC_SR_DEF
    \
    \ @brief SR register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $0d constant DAC_DMAUDR                     \ [0x0d] DMAUDR: DAC channel DMA underrun flag This bit is set by hardware and cleared by software (by writing it to 1). 0: No DMA underrun error condition occurred for DAC channel 1: DMA underrun error condition occurred for DAC channel (the currently selected trigger is driving DAC channel conversion at a frequency higher than the DMA service capability rate)
  [then]

  \
  \ @brief DAC address block description
  \
  $00 constant DAC_CR                   \ CR register
  $04 constant DAC_SWTRIGR              \ SWTRIGR register
  $10 constant DAC_DHR                  \ DHR register
  $2C constant DAC_DOR                  \ DOR register
  $34 constant DAC_SR                   \ SR register

: DAC_DEF ; [then]
