\
\ @file syscfg_comp.fs
\ @brief System configuration controller and       Comparator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SYSCFG configuration register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SYSCFG_COMP_CFGR1_MEM_MODE                       \ Memory mapping selection bits
$00000300 constant SYSCFG_COMP_CFGR1_BOOT_MODE                      \ Boot mode selected by the boot pins status bits


\
\ @brief SYSCFG configuration register 2
\ Address offset: 0x04
\ Reset value: 0x00000001
\

$00000001 constant SYSCFG_COMP_CFGR2_FWDISEN                        \ Firewall disable bit
$00000100 constant SYSCFG_COMP_CFGR2_I2C_PB6_FMP                    \ Fm+ drive capability on PB6 enable bit
$00000200 constant SYSCFG_COMP_CFGR2_I2C_PB7_FMP                    \ Fm+ drive capability on PB7 enable bit
$00000400 constant SYSCFG_COMP_CFGR2_I2C_PB8_FMP                    \ Fm+ drive capability on PB8 enable bit
$00000800 constant SYSCFG_COMP_CFGR2_I2C_PB9_FMP                    \ Fm+ drive capability on PB9 enable bit
$00001000 constant SYSCFG_COMP_CFGR2_I2C1_FMP                       \ I2C1 Fm+ drive capability enable bit
$00002000 constant SYSCFG_COMP_CFGR2_I2C2_FMP                       \ I2C2 Fm+ drive capability enable bit


\
\ @brief external interrupt configuration register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_COMP_EXTICR1_EXTI0                        \ EXTI x configuration (x = 0 to 3)
$000000f0 constant SYSCFG_COMP_EXTICR1_EXTI1                        \ EXTI x configuration (x = 0 to 3)
$00000f00 constant SYSCFG_COMP_EXTICR1_EXTI2                        \ EXTI x configuration (x = 0 to 3)
$0000f000 constant SYSCFG_COMP_EXTICR1_EXTI3                        \ EXTI x configuration (x = 0 to 3)


\
\ @brief external interrupt configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_COMP_EXTICR2_EXTI4                        \ EXTI x configuration (x = 4 to 7)
$000000f0 constant SYSCFG_COMP_EXTICR2_EXTI5                        \ EXTI x configuration (x = 4 to 7)
$00000f00 constant SYSCFG_COMP_EXTICR2_EXTI6                        \ EXTI x configuration (x = 4 to 7)
$0000f000 constant SYSCFG_COMP_EXTICR2_EXTI7                        \ EXTI x configuration (x = 4 to 7)


\
\ @brief external interrupt configuration register 3
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_COMP_EXTICR3_EXTI8                        \ EXTI x configuration (x = 8 to 11)
$000000f0 constant SYSCFG_COMP_EXTICR3_EXTI9                        \ EXTI x configuration (x = 8 to 11)
$00000f00 constant SYSCFG_COMP_EXTICR3_EXTI10                       \ EXTI10
$0000f000 constant SYSCFG_COMP_EXTICR3_EXTI11                       \ EXTI x configuration (x = 8 to 11)


\
\ @brief external interrupt configuration register 4
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_COMP_EXTICR4_EXTI12                       \ EXTI12
$000000f0 constant SYSCFG_COMP_EXTICR4_EXTI13                       \ EXTI13
$00000f00 constant SYSCFG_COMP_EXTICR4_EXTI14                       \ EXTI14
$0000f000 constant SYSCFG_COMP_EXTICR4_EXTI15                       \ EXTI x configuration (x = 12 to 15)


\
\ @brief Comparator 1 control and status register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_COMP_COMP1_CSR_COMP1EN                    \ Comparator 1 enable bit
$00000030 constant SYSCFG_COMP_COMP1_CSR_COMP1INNSEL                \ Comparator 1 Input Minus connection configuration bit
$00000100 constant SYSCFG_COMP_COMP1_CSR_COMP1WM                    \ Comparator 1 window mode selection bit
$00001000 constant SYSCFG_COMP_COMP1_CSR_COMP1LPTIMIN1              \ Comparator 1 LPTIM input propagation bit
$00008000 constant SYSCFG_COMP_COMP1_CSR_COMP1POLARITY              \ Comparator 1 polarity selection bit
$40000000 constant SYSCFG_COMP_COMP1_CSR_COMP1VALUE                 \ Comparator 1 output status bit
$80000000 constant SYSCFG_COMP_COMP1_CSR_COMP1LOCK                  \ COMP1_CSR register lock bit


\
\ @brief Comparator 2 control and status register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_COMP_COMP2_CSR_COMP2EN                    \ Comparator 2 enable bit
$00000008 constant SYSCFG_COMP_COMP2_CSR_COMP2SPEED                 \ Comparator 2 power mode selection bit
$00000070 constant SYSCFG_COMP_COMP2_CSR_COMP2INNSEL                \ Comparator 2 Input Minus connection configuration bit
$00000700 constant SYSCFG_COMP_COMP2_CSR_COMP2INPSEL                \ Comparator 2 Input Plus connection configuration bit
$00001000 constant SYSCFG_COMP_COMP2_CSR_COMP2LPTIMIN2              \ Comparator 2 LPTIM input 2 propagation bit
$00002000 constant SYSCFG_COMP_COMP2_CSR_COMP2LPTIMIN1              \ Comparator 2 LPTIM input 1 propagation bit
$00008000 constant SYSCFG_COMP_COMP2_CSR_COMP2POLARITY              \ Comparator 2 polarity selection bit
$40000000 constant SYSCFG_COMP_COMP2_CSR_COMP2VALUE                 \ Comparator 2 output status bit
$80000000 constant SYSCFG_COMP_COMP2_CSR_COMP2LOCK                  \ COMP2_CSR register lock bit


\
\ @brief SYSCFG configuration register 3
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_COMP_CFGR3_EN_BGAP                        \ Vref Enable bit
$00000030 constant SYSCFG_COMP_CFGR3_SEL_VREF_OUT                   \ BGAP_ADC connection bit
$00000100 constant SYSCFG_COMP_CFGR3_ENBUF_BGAP_ADC                 \ VREFINT reference for ADC enable bit
$00000200 constant SYSCFG_COMP_CFGR3_ENBUF_SENSOR_ADC               \ Sensor reference for ADC enable bit
$00001000 constant SYSCFG_COMP_CFGR3_ENBUF_VREFINT_COMP             \ VREFINT reference for comparator 2 enable bit
$00002000 constant SYSCFG_COMP_CFGR3_ENREF_RC48MHZ                  \ VREFINT reference for 48 MHz RC oscillator enable bit
$04000000 constant SYSCFG_COMP_CFGR3_REF_RC48MHZ_RDYF               \ VREFINT for 48 MHz RC oscillator ready flag
$08000000 constant SYSCFG_COMP_CFGR3_SENSOR_ADC_RDYF                \ Sensor for ADC ready flag
$10000000 constant SYSCFG_COMP_CFGR3_VREFINT_ADC_RDYF               \ VREFINT for ADC ready flag
$20000000 constant SYSCFG_COMP_CFGR3_VREFINT_COMP_RDYF              \ VREFINT for comparator ready flag
$40000000 constant SYSCFG_COMP_CFGR3_VREFINT_RDYF                   \ VREFINT ready flag
$80000000 constant SYSCFG_COMP_CFGR3_REF_LOCK                       \ REF_CTRL lock bit


\
\ @brief System configuration controller and Comparator
\
$40010000 constant SYSCFG_COMP_CFGR1  \ offset: 0x00 : SYSCFG configuration register 1
$40010004 constant SYSCFG_COMP_CFGR2  \ offset: 0x04 : SYSCFG configuration register 2
$40010008 constant SYSCFG_COMP_EXTICR1  \ offset: 0x08 : external interrupt configuration register 1
$4001000c constant SYSCFG_COMP_EXTICR2  \ offset: 0x0C : external interrupt configuration register 2
$40010010 constant SYSCFG_COMP_EXTICR3  \ offset: 0x10 : external interrupt configuration register 3
$40010014 constant SYSCFG_COMP_EXTICR4  \ offset: 0x14 : external interrupt configuration register 4
$40010018 constant SYSCFG_COMP_COMP1_CSR  \ offset: 0x18 : Comparator 1 control and status register
$4001001c constant SYSCFG_COMP_COMP2_CSR  \ offset: 0x1C : Comparator 2 control and status register
$40010020 constant SYSCFG_COMP_CFGR3  \ offset: 0x20 : SYSCFG configuration register 3

