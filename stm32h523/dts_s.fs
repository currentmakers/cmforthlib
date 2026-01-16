\
\ @file dts_s.fs
\ @brief DTS address block description
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

$00000001 constant DTS_S_DTS_CFGR1_TS1_EN                           \ Temperature sensor 1 enable bit
$00000010 constant DTS_S_DTS_CFGR1_TS1_START                        \ Start frequency measurement on temperature sensor 1
$00000f00 constant DTS_S_DTS_CFGR1_TS1_INTRIG_SEL                   \ Input trigger selection bit for temperature sensor 1
$000f0000 constant DTS_S_DTS_CFGR1_TS1_SMP_TIME                     \ Sampling time for temperature sensor 1
$00100000 constant DTS_S_DTS_CFGR1_REFCLK_SEL                       \ Reference clock selection bit
$00200000 constant DTS_S_DTS_CFGR1_Q_MEAS_OPT                       \ Quick measurement option bit
$7f000000 constant DTS_S_DTS_CFGR1_HSREF_CLK_DIV                    \ High speed clock division ratio


\
\ @brief Temperature sensor T0 value register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000ffff constant DTS_S_DTS_T0VALR1_TS1_FMT0                       \ Engineering value of the frequency measured at T0 for
$00030000 constant DTS_S_DTS_T0VALR1_TS1_T0                         \ Engineering value of the T0 temperature for temperature sensor 1.


\
\ @brief Temperature sensor ramp value register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant DTS_S_DTS_RAMPVALR_TS1_RAMP_COEFF                \ Engineering value of the ramp coefficient for the temperature sensor 1.


\
\ @brief Temperature sensor interrupt threshold register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant DTS_S_DTS_ITR1_TS1_LITTHD                        \ Low interrupt threshold for temperature sensor 1
$ffff0000 constant DTS_S_DTS_ITR1_TS1_HITTHD                        \ High interrupt threshold for temperature sensor 1


\
\ @brief Temperature sensor data register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant DTS_S_DTS_DR_TS1_MFREQ                           \ Value of the counter output value for temperature sensor 1


\
\ @brief Temperature sensor status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant DTS_S_DTS_SR_TS1_ITEF                            \ Interrupt flag for end of measurement on temperature sensor 1, synchronized on PCLK.
$00000002 constant DTS_S_DTS_SR_TS1_ITLF                            \ Interrupt flag for low threshold on temperature sensor 1, synchronized on PCLK.
$00000004 constant DTS_S_DTS_SR_TS1_ITHF                            \ Interrupt flag for high threshold on temperature sensor 1, synchronized on PCLK
$00000010 constant DTS_S_DTS_SR_TS1_AITEF                           \ Asynchronous interrupt flag for end of measure on temperature sensor 1
$00000020 constant DTS_S_DTS_SR_TS1_AITLF                           \ Asynchronous interrupt flag for low threshold on temperature sensor 1
$00000040 constant DTS_S_DTS_SR_TS1_AITHF                           \ Asynchronous interrupt flag for high threshold on temperature sensor 1
$00008000 constant DTS_S_DTS_SR_TS1_RDY                             \ Temperature sensor 1 ready flag


\
\ @brief Temperature sensor interrupt enable register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant DTS_S_DTS_ITENR_TS1_ITEEN                        \ Interrupt enable flag for end of measurement on temperature sensor 1, synchronized on PCLK.
$00000002 constant DTS_S_DTS_ITENR_TS1_ITLEN                        \ Interrupt enable flag for low threshold on temperature sensor 1, synchronized on PCLK.
$00000004 constant DTS_S_DTS_ITENR_TS1_ITHEN                        \ Interrupt enable flag for high threshold on temperature sensor 1, synchronized on PCLK.
$00000010 constant DTS_S_DTS_ITENR_TS1_AITEEN                       \ Asynchronous interrupt enable flag for end of measurement on temperature sensor 1
$00000020 constant DTS_S_DTS_ITENR_TS1_AITLEN                       \ Asynchronous interrupt enable flag for low threshold on temperature sensor 1.
$00000040 constant DTS_S_DTS_ITENR_TS1_AITHEN                       \ Asynchronous interrupt enable flag on high threshold for temperature sensor 1.


\
\ @brief Temperature sensor clear interrupt flag register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant DTS_S_DTS_ICIFR_TS1_CITEF                        \ Interrupt clear flag for end of measurement on temperature sensor 1
$00000002 constant DTS_S_DTS_ICIFR_TS1_CITLF                        \ Interrupt clear flag for low threshold on temperature sensor 1
$00000004 constant DTS_S_DTS_ICIFR_TS1_CITHF                        \ Interrupt clear flag for high threshold on temperature sensor 1
$00000010 constant DTS_S_DTS_ICIFR_TS1_CAITEF                       \ Write once bit.
$00000020 constant DTS_S_DTS_ICIFR_TS1_CAITLF                       \ Asynchronous interrupt clear flag for low threshold on temperature sensor 1
$00000040 constant DTS_S_DTS_ICIFR_TS1_CAITHF                       \ Asynchronous interrupt clear flag for high threshold on temperature sensor 1


\
\ @brief Temperature sensor option register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant DTS_S_DTS_OR_TS_OP0                              \ general purpose option bits
$00000002 constant DTS_S_DTS_OR_TS_OP1                              \ general purpose option bits
$00000004 constant DTS_S_DTS_OR_TS_OP2                              \ general purpose option bits
$00000008 constant DTS_S_DTS_OR_TS_OP3                              \ general purpose option bits
$00000010 constant DTS_S_DTS_OR_TS_OP4                              \ general purpose option bits
$00000020 constant DTS_S_DTS_OR_TS_OP5                              \ general purpose option bits
$00000040 constant DTS_S_DTS_OR_TS_OP6                              \ general purpose option bits
$00000080 constant DTS_S_DTS_OR_TS_OP7                              \ general purpose option bits
$00000100 constant DTS_S_DTS_OR_TS_OP8                              \ general purpose option bits
$00000200 constant DTS_S_DTS_OR_TS_OP9                              \ general purpose option bits
$00000400 constant DTS_S_DTS_OR_TS_OP10                             \ general purpose option bits
$00000800 constant DTS_S_DTS_OR_TS_OP11                             \ general purpose option bits
$00001000 constant DTS_S_DTS_OR_TS_OP12                             \ general purpose option bits
$00002000 constant DTS_S_DTS_OR_TS_OP13                             \ general purpose option bits
$00004000 constant DTS_S_DTS_OR_TS_OP14                             \ general purpose option bits
$00008000 constant DTS_S_DTS_OR_TS_OP15                             \ general purpose option bits
$00010000 constant DTS_S_DTS_OR_TS_OP16                             \ general purpose option bits
$00020000 constant DTS_S_DTS_OR_TS_OP17                             \ general purpose option bits
$00040000 constant DTS_S_DTS_OR_TS_OP18                             \ general purpose option bits
$00080000 constant DTS_S_DTS_OR_TS_OP19                             \ general purpose option bits
$00100000 constant DTS_S_DTS_OR_TS_OP20                             \ general purpose option bits
$00200000 constant DTS_S_DTS_OR_TS_OP21                             \ general purpose option bits
$00400000 constant DTS_S_DTS_OR_TS_OP22                             \ general purpose option bits
$00800000 constant DTS_S_DTS_OR_TS_OP23                             \ general purpose option bits
$01000000 constant DTS_S_DTS_OR_TS_OP24                             \ general purpose option bits
$02000000 constant DTS_S_DTS_OR_TS_OP25                             \ general purpose option bits
$04000000 constant DTS_S_DTS_OR_TS_OP26                             \ general purpose option bits
$08000000 constant DTS_S_DTS_OR_TS_OP27                             \ general purpose option bits
$10000000 constant DTS_S_DTS_OR_TS_OP28                             \ general purpose option bits
$20000000 constant DTS_S_DTS_OR_TS_OP29                             \ general purpose option bits
$40000000 constant DTS_S_DTS_OR_TS_OP30                             \ general purpose option bits
$80000000 constant DTS_S_DTS_OR_TS_OP31                             \ general purpose option bits


\
\ @brief DTS address block description
\
$50008c00 constant DTS_S_DTS_CFGR1  \ offset: 0x00 : Temperature sensor configuration register 1
$50008c08 constant DTS_S_DTS_T0VALR1  \ offset: 0x08 : Temperature sensor T0 value register 1
$50008c10 constant DTS_S_DTS_RAMPVALR  \ offset: 0x10 : Temperature sensor ramp value register
$50008c14 constant DTS_S_DTS_ITR1  \ offset: 0x14 : Temperature sensor interrupt threshold register 1
$50008c1c constant DTS_S_DTS_DR   \ offset: 0x1C : Temperature sensor data register
$50008c20 constant DTS_S_DTS_SR   \ offset: 0x20 : Temperature sensor status register
$50008c24 constant DTS_S_DTS_ITENR  \ offset: 0x24 : Temperature sensor interrupt enable register
$50008c28 constant DTS_S_DTS_ICIFR  \ offset: 0x28 : Temperature sensor clear interrupt flag register
$50008c2c constant DTS_S_DTS_OR   \ offset: 0x2C : Temperature sensor option register

