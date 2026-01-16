\
\ @file dts.fs
\ @brief Digital temperature sensor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Temperature sensor configuration register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_CFGR1_TS1_EN                             \ Temperature sensor 1 enable bit This bit is set and cleared by software. Note: Once enabled, the temperature sensor is active after a specific delay time. The TS1_RDY flag will be set when the sensor is ready.
$00000010 constant DTS_DTS_CFGR1_TS1_START                          \ Start frequency measurement on temperature sensor 1 This bit is set and cleared by software.
$00000f00 constant DTS_DTS_CFGR1_TS1_INTRIG_SEL                     \ Input trigger selection bit for temperature sensor 1 These bits are set and cleared by software. They select which input triggers a temperature measurement. Refer to Section 30.3.10: Trigger input.
$000f0000 constant DTS_DTS_CFGR1_TS1_SMP_TIME                       \ Sampling time for temperature sensor 1 These bits allow increasing the sampling time to improve measurement precision. When the PCLK clock is selected as reference clock (REFCLK_SEL = 0), the measurement will be performed at TS1_SMP_TIME period of CLK_PTAT. When the LSE is selected as reference clock (REFCLK_SEL =1), the measurement will be performed at TS1_SMP_TIME period of LSE.
$00100000 constant DTS_DTS_CFGR1_REFCLK_SEL                         \ Reference clock selection bit This bit is set and cleared by software. It indicates whether the reference clock is the high speed clock (PCLK) or the low speed clock (LSE).
$00200000 constant DTS_DTS_CFGR1_Q_MEAS_OPT                         \ Quick measurement option bit This bit is set and cleared by software. It is used to increase the measurement speed by suppressing the calibration step. It is effective only when the LSE clock is used as reference clock (REFCLK_SEL=1).
$7f000000 constant DTS_DTS_CFGR1_HSREF_CLK_DIV                      \ High speed clock division ratio These bits are set and cleared by software. They can be used to define the division ratio for the main clock in order to obtain the internal frequency lower than 1 MHz required for the calibration. They are applicable only for calibration when PCLK is selected as reference clock (REFCLK_SEL=0). ...


\
\ @brief Temperature sensor T0 value register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_T0VALR1_TS1_FMT0                         \ Engineering value of the frequency measured at T0 for temperature sensor 1 This value is expressed in 0.1 kHz.
$00030000 constant DTS_DTS_T0VALR1_TS1_T0                           \ Engineering value of the T0 temperature for temperature sensor 1. Others: Reserved, must not be used.


\
\ @brief Temperature sensor ramp value register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_RAMPVALR_TS1_RAMP_COEFF                  \ Engineering value of the ramp coefficient for the temperature sensor 1. This value is expressed in Hz/ C.


\
\ @brief Temperature sensor interrupt threshold register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_ITR1_TS1_LITTHD                          \ Low interrupt threshold for temperature sensor 1 These bits are set and cleared by software. They indicate the lowest value than can be reached before raising an interrupt signal.
$ffff0000 constant DTS_DTS_ITR1_TS1_HITTHD                          \ High interrupt threshold for temperature sensor 1 These bits are set and cleared by software. They indicate the highest value than can be reached before raising an interrupt signal.


\
\ @brief Temperature sensor data register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_DR_TS1_MFREQ                             \ Value of the counter output value for temperature sensor 1


\
\ @brief Temperature sensor status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_SR_TS1_ITEF                              \ Interrupt flag for end of measurement on temperature sensor 1, synchronized on PCLK. This bit is set by hardware when a temperature measure is done. It is cleared by software by writing 1 to the TS2_CITEF bit in the DTS_ICIFR register. Note: This bit is active only when the TS1_ITEFEN bit is set
$00000002 constant DTS_DTS_SR_TS1_ITLF                              \ Interrupt flag for low threshold on temperature sensor 1, synchronized on PCLK. This bit is set by hardware when the low threshold is set and reached. It is cleared by software by writing 1 to the TS1_CITLF bit in the DTS_ICIFR register. Note: This bit is active only when the TS1_ITLFEN bit is set
$00000004 constant DTS_DTS_SR_TS1_ITHF                              \ Interrupt flag for high threshold on temperature sensor 1, synchronized on PCLK This bit is set by hardware when the high threshold is set and reached. It is cleared by software by writing 1 to the TS1_CITHF bit in the DTS_ICIFR register. Note: This bit is active only when the TS1_ITHFEN bit is set
$00000010 constant DTS_DTS_SR_TS1_AITEF                             \ Asynchronous interrupt flag for end of measure on temperature sensor 1 This bit is set by hardware when a temperature measure is done. It is cleared by software by writing 1 to the TS1_CAITEF bit in the DTS_ICIFR register. Note: This bit is active only when the TS1_AITEFEN bit is set
$00000020 constant DTS_DTS_SR_TS1_AITLF                             \ Asynchronous interrupt flag for low threshold on temperature sensor 1 This bit is set by hardware when the low threshold is reached. It is cleared by software by writing 1 to the TS1_CAITLF bit in the DTS_ICIFR register. Note: This bit is active only when the TS1_AITLFEN bit is set
$00000040 constant DTS_DTS_SR_TS1_AITHF                             \ Asynchronous interrupt flag for high threshold on temperature sensor 1 This bit is set by hardware when the high threshold is reached. It is cleared by software by writing 1 to the TS1_CAITHF bit in the DTS_ICIFR register. Note: This bit is active only when the TS1_AITHFEN bit is set
$00008000 constant DTS_DTS_SR_TS1_RDY                               \ Temperature sensor 1 ready flag This bit is set and reset by hardware. It indicates that a measurement is ongoing.


\
\ @brief Temperature sensor interrupt enable register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_ITENR_TS1_ITEEN                          \ Interrupt enable flag for end of measurement on temperature sensor 1, synchronized on PCLK. This bit are set and cleared by software. It enables the synchronous interrupt for end of measurement.
$00000002 constant DTS_DTS_ITENR_TS1_ITLEN                          \ Interrupt enable flag for low threshold on temperature sensor 1, synchronized on PCLK. This bit are set and cleared by software. It enables the synchronous interrupt when the measure reaches or is below the low threshold.
$00000004 constant DTS_DTS_ITENR_TS1_ITHEN                          \ Interrupt enable flag for high threshold on temperature sensor 1, synchronized on PCLK. This bit are set and cleared by software. It enables the interrupt when the measure reaches or is above the high threshold.
$00000010 constant DTS_DTS_ITENR_TS1_AITEEN                         \ Asynchronous interrupt enable flag for end of measurement on temperature sensor 1 This bit are set and cleared by software. It enables the asynchronous interrupt for end of measurement (only when REFCLK_SEL = 1).
$00000020 constant DTS_DTS_ITENR_TS1_AITLEN                         \ Asynchronous interrupt enable flag for low threshold on temperature sensor 1. This bit are set and cleared by software. It enables the asynchronous interrupt when the temperature is below the low threshold (only when REFCLK_SEL= 1)
$00000040 constant DTS_DTS_ITENR_TS1_AITHEN                         \ Asynchronous interrupt enable flag on high threshold for temperature sensor 1. This bit are set and cleared by software. It enables the asynchronous interrupt when the temperature is above the high threshold (only when REFCLK_SEL= 1)


\
\ @brief Temperature sensor clear interrupt flag register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_ICIFR_TS1_CITEF                          \ Interrupt clear flag for end of measurement on temperature sensor 1 Writing 1 to this bit clears the TS1_ITEF flag in the DTS_SR register.
$00000002 constant DTS_DTS_ICIFR_TS1_CITLF                          \ Interrupt clear flag for low threshold on temperature sensor 1 Writing 1 to this bit clears the TS1_ITLF flag in the DTS_SR register.
$00000004 constant DTS_DTS_ICIFR_TS1_CITHF                          \ Interrupt clear flag for high threshold on temperature sensor 1 Writing this bit to 1 clears the TS1_ITHF flag in the DTS_SR register.
$00000010 constant DTS_DTS_ICIFR_TS1_CAITEF                         \ Write once bit. Clear the asynchronous IT flag for End Of Measure for thermal sensor 1. Writing 1 clears the TS1_AITEF flag of the DTS_SR register.
$00000020 constant DTS_DTS_ICIFR_TS1_CAITLF                         \ Asynchronous interrupt clear flag for low threshold on temperature sensor 1 Writing 1 to this bit clears the TS1_AITLF flag in the DTS_SR register.
$00000040 constant DTS_DTS_ICIFR_TS1_CAITHF                         \ Asynchronous interrupt clear flag for high threshold on temperature sensor 1 Writing 1 to this bit clears the TS1_AITHF flag in the DTS_SR register.


\
\ @brief Temperature sensor option register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_OR_TS_OP0                                \ general purpose option bits
$00000002 constant DTS_DTS_OR_TS_OP1                                \ general purpose option bits
$00000004 constant DTS_DTS_OR_TS_OP2                                \ general purpose option bits
$00000008 constant DTS_DTS_OR_TS_OP3                                \ general purpose option bits
$00000010 constant DTS_DTS_OR_TS_OP4                                \ general purpose option bits
$00000020 constant DTS_DTS_OR_TS_OP5                                \ general purpose option bits
$00000040 constant DTS_DTS_OR_TS_OP6                                \ general purpose option bits
$00000080 constant DTS_DTS_OR_TS_OP7                                \ general purpose option bits
$00000100 constant DTS_DTS_OR_TS_OP8                                \ general purpose option bits
$00000200 constant DTS_DTS_OR_TS_OP9                                \ general purpose option bits
$00000400 constant DTS_DTS_OR_TS_OP10                               \ general purpose option bits
$00000800 constant DTS_DTS_OR_TS_OP11                               \ general purpose option bits
$00001000 constant DTS_DTS_OR_TS_OP12                               \ general purpose option bits
$00002000 constant DTS_DTS_OR_TS_OP13                               \ general purpose option bits
$00004000 constant DTS_DTS_OR_TS_OP14                               \ general purpose option bits
$00008000 constant DTS_DTS_OR_TS_OP15                               \ general purpose option bits
$00010000 constant DTS_DTS_OR_TS_OP16                               \ general purpose option bits
$00020000 constant DTS_DTS_OR_TS_OP17                               \ general purpose option bits
$00040000 constant DTS_DTS_OR_TS_OP18                               \ general purpose option bits
$00080000 constant DTS_DTS_OR_TS_OP19                               \ general purpose option bits
$00100000 constant DTS_DTS_OR_TS_OP20                               \ general purpose option bits
$00200000 constant DTS_DTS_OR_TS_OP21                               \ general purpose option bits
$00400000 constant DTS_DTS_OR_TS_OP22                               \ general purpose option bits
$00800000 constant DTS_DTS_OR_TS_OP23                               \ general purpose option bits
$01000000 constant DTS_DTS_OR_TS_OP24                               \ general purpose option bits
$02000000 constant DTS_DTS_OR_TS_OP25                               \ general purpose option bits
$04000000 constant DTS_DTS_OR_TS_OP26                               \ general purpose option bits
$08000000 constant DTS_DTS_OR_TS_OP27                               \ general purpose option bits
$10000000 constant DTS_DTS_OR_TS_OP28                               \ general purpose option bits
$20000000 constant DTS_DTS_OR_TS_OP29                               \ general purpose option bits
$40000000 constant DTS_DTS_OR_TS_OP30                               \ general purpose option bits
$80000000 constant DTS_DTS_OR_TS_OP31                               \ general purpose option bits


\
\ @brief Digital temperature sensor
\
$58006800 constant DTS_DTS_CFGR1  \ offset: 0x00 : Temperature sensor configuration register 1
$58006808 constant DTS_DTS_T0VALR1  \ offset: 0x08 : Temperature sensor T0 value register 1
$58006810 constant DTS_DTS_RAMPVALR  \ offset: 0x10 : Temperature sensor ramp value register
$58006814 constant DTS_DTS_ITR1   \ offset: 0x14 : Temperature sensor interrupt threshold register 1
$5800681c constant DTS_DTS_DR     \ offset: 0x1C : Temperature sensor data register
$58006820 constant DTS_DTS_SR     \ offset: 0x20 : Temperature sensor status register
$58006824 constant DTS_DTS_ITENR  \ offset: 0x24 : Temperature sensor interrupt enable register
$58006828 constant DTS_DTS_ICIFR  \ offset: 0x28 : Temperature sensor clear interrupt flag register
$5800682c constant DTS_DTS_OR     \ offset: 0x2C : Temperature sensor option register

