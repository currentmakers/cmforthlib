\
\ @file ri.fs
\ @brief Routing interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RI input capture register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000000f constant RI_ICR_IC1IOS                                    \ Input capture 1 select bits
$000000f0 constant RI_ICR_IC2IOS                                    \ Input capture 2 select bits
$00000f00 constant RI_ICR_IC3IOS                                    \ Input capture 3 select bits
$0000f000 constant RI_ICR_IC4IOS                                    \ Input capture 4 select bits
$00030000 constant RI_ICR_TIM                                       \ Timer select bits
$00040000 constant RI_ICR_IC1                                       \ IC1
$00080000 constant RI_ICR_IC2                                       \ IC2
$00100000 constant RI_ICR_IC3                                       \ IC3
$00200000 constant RI_ICR_IC4                                       \ IC4


\
\ @brief RI analog switches control register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant RI_ASCR1_CH0GR1_1                                \ Analog switch control
$00000002 constant RI_ASCR1_CH1GR1_2                                \ Analog switch control
$00000004 constant RI_ASCR1_CH2GR1_3                                \ Analog switch control
$00000008 constant RI_ASCR1_CH3GR1_4                                \ Analog switch control
$00000010 constant RI_ASCR1_CH31GR11_5                              \ Analog switch control
$00000020 constant RI_ASCR1_COMP1_SW1                               \ Comparator 1 analog switch
$00000040 constant RI_ASCR1_CH6GR2_1                                \ Analog switch control
$00000080 constant RI_ASCR1_CH7GR2_2                                \ Analog switch control
$00000100 constant RI_ASCR1_CH8GR3_1                                \ Analog switch control
$00000200 constant RI_ASCR1_CH9GR3_2                                \ Analog switch control
$00000400 constant RI_ASCR1_CH10GR8_1                               \ Analog switch control
$00000800 constant RI_ASCR1_CH11GR8_2                               \ Analog switch control
$00001000 constant RI_ASCR1_CH12GR8_3                               \ Analog switch control
$00002000 constant RI_ASCR1_CH13GR8_4                               \ Analog switch control
$00004000 constant RI_ASCR1_CH14GR9_1                               \ Analog switch control
$00008000 constant RI_ASCR1_CH15GR9_2                               \ Analog switch control
$00010000 constant RI_ASCR1_CH31GR7_1                               \ Analog switch control
$00040000 constant RI_ASCR1_CH18GR7_1                               \ Analog switch control
$00080000 constant RI_ASCR1_CH19GR7_2                               \ Analog switch control
$00100000 constant RI_ASCR1_CH20GR7_3                               \ Analog switch control
$00200000 constant RI_ASCR1_CH21GR7_4                               \ Analog switch control
$00400000 constant RI_ASCR1_CH22                                    \ Analog I/O switch control of channel CH22
$00800000 constant RI_ASCR1_CH23                                    \ Analog I/O switch control of channel CH23
$01000000 constant RI_ASCR1_CH24                                    \ Analog I/O switch control of channel CH24
$02000000 constant RI_ASCR1_CH25                                    \ Analog I/O switch control of channel CH25
$04000000 constant RI_ASCR1_VCOMP                                   \ ADC analog switch selection for internal node to comparator 1
$08000000 constant RI_ASCR1_CH27GR11_1                              \ Analog switch control
$10000000 constant RI_ASCR1_CH28GR11_2                              \ Analog switch control
$20000000 constant RI_ASCR1_CH29GR11_3                              \ Analog switch control
$40000000 constant RI_ASCR1_CH30GR11_4                              \ Analog switch control
$80000000 constant RI_ASCR1_SCM                                     \ Switch control mode


\
\ @brief RI analog switches control register 2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant RI_ASCR2_GR10_1                                  \ GR10_1 analog switch control
$00000002 constant RI_ASCR2_GR10_2                                  \ GR10_2 analog switch control
$00000004 constant RI_ASCR2_GR10_3                                  \ GR10_3 analog switch control
$00000008 constant RI_ASCR2_GR10_4                                  \ GR10_4 analog switch control
$00000010 constant RI_ASCR2_GR6_1                                   \ GR6_1 analog switch control
$00000020 constant RI_ASCR2_GR6_2                                   \ GR6_2 analog switch control
$00000040 constant RI_ASCR2_GR5_1                                   \ GR5_1 analog switch control
$00000080 constant RI_ASCR2_GR5_2                                   \ GR5_2 analog switch control
$00000100 constant RI_ASCR2_GR5_3                                   \ GR5_3 analog switch control
$00000200 constant RI_ASCR2_GR4_1                                   \ GR4_1 analog switch control
$00000400 constant RI_ASCR2_GR4_2                                   \ GR4_2 analog switch control
$00000800 constant RI_ASCR2_GR4_3                                   \ GR4_3 analog switch control
$00010000 constant RI_ASCR2_GR3_3                                   \ GR3_3 analog switch control
$00020000 constant RI_ASCR2_GR3_4                                   \ GR3_4 analog switch control
$00040000 constant RI_ASCR2_GR3_5                                   \ GR3_5 analog switch control
$00080000 constant RI_ASCR2_GR9_3                                   \ GR9_3 analog switch control
$00100000 constant RI_ASCR2_GR9_4                                   \ GR9_4 analog switch control
$00200000 constant RI_ASCR2_GR2_3                                   \ GR2_3 analog switch control
$00400000 constant RI_ASCR2_GR2_4                                   \ GR2_4 analog switch control
$00800000 constant RI_ASCR2_GR2_5                                   \ GR2_5 analog switch control
$01000000 constant RI_ASCR2_GR7_5                                   \ GR7_5 analog switch control
$02000000 constant RI_ASCR2_GR7_6                                   \ GR7_6 analog switch control
$04000000 constant RI_ASCR2_GR7_7                                   \ GR7_7 analog switch control
$08000000 constant RI_ASCR2_GR6_3                                   \ GR6_3 analog switch control
$10000000 constant RI_ASCR2_GR6_4                                   \ GR6_4 analog switch control
$20000000 constant RI_ASCR2_GR5_4                                   \ GR5_4 analog switch control


\
\ @brief RI hysteresis control register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant RI_HYSCR1_PA                                     \ Port A hysteresis control on/off
$ffff0000 constant RI_HYSCR1_PB                                     \ Port B hysteresis control on/off


\
\ @brief RI hysteresis control register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant RI_HYSCR2_PC                                     \ Port C hysteresis control on/off
$ffff0000 constant RI_HYSCR2_PD                                     \ Port D hysteresis control on/off


\
\ @brief RI hysteresis control register 3
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant RI_HYSCR3_PE                                     \ Port E hysteresis control on/off
$ffff0000 constant RI_HYSCR3_PF                                     \ Port F hysteresis control on/off


\
\ @brief Hysteresis control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant RI_HYSCR4_PG                                     \ Port G hysteresis control on/off


\
\ @brief Analog switch mode register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant RI_ASMR1_PA                                      \ Port A analog switch mode selection


\
\ @brief Channel mask register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant RI_CMR1_PA                                       \ Port A channel masking


\
\ @brief Channel identification for capture register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant RI_CICR1_PA                                      \ Port A channel identification for capture


\
\ @brief Analog switch mode register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant RI_ASMR2_PB                                      \ Port B analog switch mode selection


\
\ @brief Channel mask register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant RI_CMR2_PB                                       \ Port B channel masking


\
\ @brief Channel identification for capture register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant RI_CICR2_PB                                      \ Port B channel identification for capture


\
\ @brief Analog switch mode register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant RI_ASMR3_PC                                      \ Port C analog switch mode selection


\
\ @brief Channel mask register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant RI_CMR3_PC                                       \ Port C channel masking


\
\ @brief Channel identification for capture register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant RI_CICR3_PC                                      \ Port C channel identification for capture


\
\ @brief Analog switch mode register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant RI_ASMR4_PF                                      \ Port F analog switch mode selection


\
\ @brief Channel mask register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant RI_CMR4_PF                                       \ Port F channel masking


\
\ @brief Channel identification for capture register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant RI_CICR4_PF                                      \ Port F channel identification for capture


\
\ @brief Analog switch mode register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant RI_ASMR5_PG                                      \ Port G analog switch mode selection


\
\ @brief Channel mask register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000ffff constant RI_CMR5_PG                                       \ Port G channel masking


\
\ @brief Channel identification for capture register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0000ffff constant RI_CICR5_PG                                      \ Port G channel identification for capture


\
\ @brief Routing interface
\
$40007c04 constant RI_ICR         \ offset: 0x00 : RI input capture register
$40007c08 constant RI_ASCR1       \ offset: 0x04 : RI analog switches control register 1
$40007c0c constant RI_ASCR2       \ offset: 0x08 : RI analog switches control register 2
$40007c10 constant RI_HYSCR1      \ offset: 0x0C : RI hysteresis control register 1
$40007c14 constant RI_HYSCR2      \ offset: 0x10 : RI hysteresis control register 2
$40007c18 constant RI_HYSCR3      \ offset: 0x14 : RI hysteresis control register 3
$40007c1c constant RI_HYSCR4      \ offset: 0x18 : Hysteresis control register
$40007c20 constant RI_ASMR1       \ offset: 0x1C : Analog switch mode register
$40007c24 constant RI_CMR1        \ offset: 0x20 : Channel mask register
$40007c28 constant RI_CICR1       \ offset: 0x24 : Channel identification for capture register
$40007c2c constant RI_ASMR2       \ offset: 0x28 : Analog switch mode register
$40007c30 constant RI_CMR2        \ offset: 0x2C : Channel mask register
$40007c34 constant RI_CICR2       \ offset: 0x30 : Channel identification for capture register
$40007c38 constant RI_ASMR3       \ offset: 0x34 : Analog switch mode register
$40007c3c constant RI_CMR3        \ offset: 0x38 : Channel mask register
$40007c40 constant RI_CICR3       \ offset: 0x3C : Channel identification for capture register
$40007c44 constant RI_ASMR4       \ offset: 0x40 : Analog switch mode register
$40007c48 constant RI_CMR4        \ offset: 0x44 : Channel mask register
$40007c4c constant RI_CICR4       \ offset: 0x48 : Channel identification for capture register
$40007c50 constant RI_ASMR5       \ offset: 0x4C : Analog switch mode register
$40007c54 constant RI_CMR5        \ offset: 0x50 : Channel mask register
$40007c58 constant RI_CICR5       \ offset: 0x54 : Channel identification for capture register

