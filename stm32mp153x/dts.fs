\
\ @file dts.fs
\ @brief DTS register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DTS_CFGR1 is the configuration register for temperature sensor 1.
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_CFGR1_TS1_EN                             \ TS1_EN
$00000010 constant DTS_DTS_CFGR1_TS1_START                          \ TS1_START
$00000f00 constant DTS_DTS_CFGR1_TS1_INTRIG_SEL                     \ TS1_INTRIG_SEL
$000f0000 constant DTS_DTS_CFGR1_TS1_SMP_TIME                       \ TS1_SMP_TIME
$00100000 constant DTS_DTS_CFGR1_REFCLK_SEL                         \ REFCLK_SEL
$00200000 constant DTS_DTS_CFGR1_Q_MEAS_OPT                         \ Q_MEAS_opt
$7f000000 constant DTS_DTS_CFGR1_HSREF_CLK_DIV                      \ HSREF_CLK_DIV


\
\ @brief DTS_T0VALR1 contains the value of the factory calibration temperature (T0) for temperature sensor 1. The system reset value is factory trimmed.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_T0VALR1_TS1_FMT0                         \ TS1_FMT0
$00030000 constant DTS_DTS_T0VALR1_TS1_T0                           \ TS1_T0


\
\ @brief The DTS_RAMPVALR is the ramp coefficient for the temperature sensor. The system reset value is factory trimmed.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_RAMPVALR_TS1_RAMP_COEFF                  \ TS1_RAMP_COEFF


\
\ @brief DTS_ITR1 contains the threshold values for sensor 1.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_ITR1_TS1_LITTHD                          \ TS1_LITTHD
$ffff0000 constant DTS_DTS_ITR1_TS1_HITTHD                          \ TS1_HITTHD


\
\ @brief The DTS_DR contains the number of REF_CLK cycles used to compute the FM(T) frequency.
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_DR_TS1_MFREQ                             \ TS1_MFREQ


\
\ @brief Temperature sensor status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_SR_TS1_ITEF                              \ TS1_ITEF
$00000002 constant DTS_DTS_SR_TS1_ITLF                              \ TS1_ITLF
$00000004 constant DTS_DTS_SR_TS1_ITHF                              \ TS1_ITHF
$00000010 constant DTS_DTS_SR_TS1_AITEF                             \ TS1_AITEF
$00000020 constant DTS_DTS_SR_TS1_AITLF                             \ TS1_AITLF
$00000040 constant DTS_DTS_SR_TS1_AITHF                             \ TS1_AITHF
$00008000 constant DTS_DTS_SR_TS1_RDY                               \ TS1_RDY


\
\ @brief Temperature sensor interrupt enable register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_ITENR_TS1_ITEEN                          \ TS1_ITEEN
$00000002 constant DTS_DTS_ITENR_TS1_ITLEN                          \ TS1_ITLEN
$00000004 constant DTS_DTS_ITENR_TS1_ITHEN                          \ TS1_ITHEN
$00000010 constant DTS_DTS_ITENR_TS1_AITEEN                         \ TS1_AITEEN
$00000020 constant DTS_DTS_ITENR_TS1_AITLEN                         \ TS1_AITLEN
$00000040 constant DTS_DTS_ITENR_TS1_AITHEN                         \ TS1_AITHEN


\
\ @brief DTS_ICIFR is the control register for the interrupt flags.
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_ICIFR_TS1_CITEF                          \ TS1_CITEF
$00000002 constant DTS_DTS_ICIFR_TS1_CITLF                          \ TS1_CITLF
$00000004 constant DTS_DTS_ICIFR_TS1_CITHF                          \ TS1_CITHF
$00000010 constant DTS_DTS_ICIFR_TS1_CAITEF                         \ TS1_CAITEF
$00000020 constant DTS_DTS_ICIFR_TS1_CAITLF                         \ TS1_CAITLF
$00000040 constant DTS_DTS_ICIFR_TS1_CAITHF                         \ TS1_CAITHF


\
\ @brief The DTS_OR contains general-purpose option bits.
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_OR_TS_OP0                                \ TS_Op0
$00000002 constant DTS_DTS_OR_TS_OP1                                \ TS_Op1
$00000004 constant DTS_DTS_OR_TS_OP2                                \ TS_Op2
$00000008 constant DTS_DTS_OR_TS_OP3                                \ TS_Op3
$00000010 constant DTS_DTS_OR_TS_OP4                                \ TS_Op4
$00000020 constant DTS_DTS_OR_TS_OP5                                \ TS_Op5
$00000040 constant DTS_DTS_OR_TS_OP6                                \ TS_Op6
$00000080 constant DTS_DTS_OR_TS_OP7                                \ TS_Op7
$00000100 constant DTS_DTS_OR_TS_OP8                                \ TS_Op8
$00000200 constant DTS_DTS_OR_TS_OP9                                \ TS_Op9
$00000400 constant DTS_DTS_OR_TS_OP10                               \ TS_Op10
$00000800 constant DTS_DTS_OR_TS_OP11                               \ TS_Op11
$00001000 constant DTS_DTS_OR_TS_OP12                               \ TS_Op12
$00002000 constant DTS_DTS_OR_TS_OP13                               \ TS_Op13
$00004000 constant DTS_DTS_OR_TS_OP14                               \ TS_Op14
$00008000 constant DTS_DTS_OR_TS_OP15                               \ TS_Op15
$00010000 constant DTS_DTS_OR_TS_OP16                               \ TS_Op16
$00020000 constant DTS_DTS_OR_TS_OP17                               \ TS_Op17
$00040000 constant DTS_DTS_OR_TS_OP18                               \ TS_Op18
$00080000 constant DTS_DTS_OR_TS_OP19                               \ TS_Op19
$00100000 constant DTS_DTS_OR_TS_OP20                               \ TS_Op20
$00200000 constant DTS_DTS_OR_TS_OP21                               \ TS_Op21
$00400000 constant DTS_DTS_OR_TS_OP22                               \ TS_Op22
$00800000 constant DTS_DTS_OR_TS_OP23                               \ TS_Op23
$01000000 constant DTS_DTS_OR_TS_OP24                               \ TS_Op24
$02000000 constant DTS_DTS_OR_TS_OP25                               \ TS_Op25
$04000000 constant DTS_DTS_OR_TS_OP26                               \ TS_Op26
$08000000 constant DTS_DTS_OR_TS_OP27                               \ TS_Op27
$10000000 constant DTS_DTS_OR_TS_OP28                               \ TS_Op28
$20000000 constant DTS_DTS_OR_TS_OP29                               \ TS_Op29
$40000000 constant DTS_DTS_OR_TS_OP30                               \ TS_Op30
$80000000 constant DTS_DTS_OR_TS_OP31                               \ TS_Op31


\
\ @brief DTS register block
\
$50028000 constant DTS_DTS_CFGR1  \ offset: 0x00 : DTS_CFGR1 is the configuration register for temperature sensor 1.
$50028008 constant DTS_DTS_T0VALR1  \ offset: 0x08 : DTS_T0VALR1 contains the value of the factory calibration temperature (T0) for temperature sensor 1. The system reset value is factory trimmed.
$50028010 constant DTS_DTS_RAMPVALR  \ offset: 0x10 : The DTS_RAMPVALR is the ramp coefficient for the temperature sensor. The system reset value is factory trimmed.
$50028014 constant DTS_DTS_ITR1   \ offset: 0x14 : DTS_ITR1 contains the threshold values for sensor 1.
$5002801c constant DTS_DTS_DR     \ offset: 0x1C : The DTS_DR contains the number of REF_CLK cycles used to compute the FM(T) frequency.
$50028020 constant DTS_DTS_SR     \ offset: 0x20 : Temperature sensor status register
$50028024 constant DTS_DTS_ITENR  \ offset: 0x24 : Temperature sensor interrupt enable register
$50028028 constant DTS_DTS_ICIFR  \ offset: 0x28 : DTS_ICIFR is the control register for the interrupt flags.
$5002802c constant DTS_DTS_OR     \ offset: 0x2C : The DTS_OR contains general-purpose option bits.

