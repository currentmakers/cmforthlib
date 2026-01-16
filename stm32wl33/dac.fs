\
\ @file dac.fs
\ @brief DAC address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CR register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DAC_CR_EN                                        \ EN: DAC channel enable This bit is set and cleared by software to enable/disable DAC channel. 0: DAC channel disabled 1: DAC channel enabled
$00000002 constant DAC_CR_BON                                       \ BON: DAC channel output buffer enable. This bit is set and cleared by software to enable/disable DAC channel output buffer. 0: DAC channel output buffer disabled 1: DAC channel output buffer enabled
$00000004 constant DAC_CR_TEN                                       \ TEN: DAC channel trigger enable This bit is set and cleared by software to enable/disable DAC channel trigger. 0: DAC channel trigger disabled and data written into the DAC_DHR register are transferred one APB0 clock cycle later to the DAC_DOR register 1: DAC channel trigger enabled and data from the DAC_DHR register are transferred three APB0 clock cycles later to the DAC_DOR register Note: When software trigger is selected, the transfer from the DAC_DHR register to the DAC_DOR register takes only one APB0 clock cycle.
$00000038 constant DAC_CR_TSEL                                      \ TSEL[2:0]: DAC channel trigger selection These bits select the external event used to trigger DAC channel. 000: Timer 16 TRGO event 001: PA8 pin event from SYSCFG 010 to 011: Reserved 111: Software trigger Only used if bit TEN = 1 (DAC channel trigger enabled).
$000000c0 constant DAC_CR_WAVE                                      \ WAVE[1:0]: DAC channel noise/triangle wave generation enable These bits are set and cleared by software. 00: wave generation disabled 01: Noise wave generation enabled 1x: Triangle wave generation enabled Note: Only used if bit TEN = 1 (DAC channel trigger enabled).
$00000f00 constant DAC_CR_MAMP                                      \ MAMP[3:0]: DAC channel mask amplitude selector These bits are written by software to select mask in wave generation mode or amplitude in triangle generation mode. 0000: Unmask bit0 of LFSR triangle amplitude equal to 1 0001: Unmask bits[1:0] of LFSR triangle amplitude equal to 3 0010: Unmask bits[2:0] of LFSR triangle amplitude equal to 7 0011: Unmask bits[3:0] of LFSR triangle amplitude equal to 15 0100: Unmask bits[4:0] of LFSR triangle amplitude equal to 31 greater than or equal to 0101: Unmask bits[5:0] of LFSR triangle amplitude equal to 63
$00001000 constant DAC_CR_DMAEN                                     \ DMAEN: DAC channel DMA enable This bit is set and cleared by software. 0: DAC channel DMA mode disabled 1: DAC channel DMA mode enabled
$00002000 constant DAC_CR_DMAUDRIE                                  \ DMAUDRIE: DAC channel DMA Underrun Interrupt enable This bit is set and cleared by software. 0: DAC channel DMA Underrun Interrupt disabled 1: DAC channel DMA Underrun Interrupt enabled
$00004000 constant DAC_CR_CMPEN                                     \ CMPEN: DAC channel output to COMP INMINUS enable. This bit is set and cleared by software. 0: DAC channel output to COMP INMINUS disabled 1: DAC channel output to COMP INMINUS enabled
$00008000 constant DAC_CR_VCMEN                                     \ VCMEN: DAC channel output to VCM BUFFER enable. This bit is set and cleared by software. 0: DAC channel output to VCM BUFFER disabled 1: DAC channel output to VCM BUFFER enabled
$00010000 constant DAC_CR_VCMON                                     \ VCMON: VCMBUFF power-up. This bit is set and cleared by software. 0: VCM BUFFER OFF 1: VCM BUFFER ON


\
\ @brief SWTRIGR register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DAC_SWTRIGR_SWTRIG                               \ SWTRIG: DAC channel software trigger This bit is set by software to enable/disable the software trigger. 0: Software trigger disabled 1: Software trigger enabled Note: This bit is cleared by hardware (one APB0 clock cycle later) once the DAC_DHR register value has been loaded into the DAC_DOR register.


\
\ @brief DHR register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000003f constant DAC_DHR_DACDHR                                   \ DACDHR[5:0]: DAC channel 6-bit data These bits are written by software which specifies 6-bit data for DAC channel.


\
\ @brief DOR register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000003f constant DAC_DOR_DACDOR                                   \ DACDOR[5:0]: DAC channel data output These bits are read-only, they contain data output for DAC channel.


\
\ @brief SR register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00002000 constant DAC_SR_DMAUDR                                    \ DMAUDR: DAC channel DMA underrun flag This bit is set by hardware and cleared by software (by writing it to 1). 0: No DMA underrun error condition occurred for DAC channel 1: DMA underrun error condition occurred for DAC channel (the currently selected trigger is driving DAC channel conversion at a frequency higher than the DMA service capability rate)


\
\ @brief DAC address block description
\
$40006000 constant DAC_CR         \ offset: 0x00 : CR register
$40006004 constant DAC_SWTRIGR    \ offset: 0x04 : SWTRIGR register
$40006010 constant DAC_DHR        \ offset: 0x10 : DHR register
$4000602c constant DAC_DOR        \ offset: 0x2C : DOR register
$40006034 constant DAC_SR         \ offset: 0x34 : SR register

