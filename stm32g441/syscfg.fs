\
\ @file syscfg.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Remap Memory register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000007 constant SYSCFG_MEMRMP_MEM_MODE                           \ Memory mapping selection
$00000100 constant SYSCFG_MEMRMP_FB_MODE                            \ User Flash Bank mode


\
\ @brief peripheral mode configuration register
\ Address offset: 0x04
\ Reset value: 0x7C000001
\

$00000100 constant SYSCFG_CFGR1_BOOSTEN                             \ BOOSTEN
$00000200 constant SYSCFG_CFGR1_ANASWVDD                            \ GPIO analog switch control voltage selection
$00010000 constant SYSCFG_CFGR1_I2C_PB6_FMP                         \ FM+ drive capability on PB6
$00020000 constant SYSCFG_CFGR1_I2C_PB7_FMP                         \ FM+ drive capability on PB6
$00040000 constant SYSCFG_CFGR1_I2C_PB8_FMP                         \ FM+ drive capability on PB6
$00080000 constant SYSCFG_CFGR1_I2C_PB9_FMP                         \ FM+ drive capability on PB6
$00100000 constant SYSCFG_CFGR1_I2C1_FMP                            \ I2C1 FM+ drive capability enable
$00200000 constant SYSCFG_CFGR1_I2C2_FMP                            \ I2C1 FM+ drive capability enable
$00400000 constant SYSCFG_CFGR1_I2C3_FMP                            \ I2C1 FM+ drive capability enable
$00800000 constant SYSCFG_CFGR1_I2C4_FMP                            \ I2C1 FM+ drive capability enable
$fc000000 constant SYSCFG_CFGR1_FPU_IE                              \ FPU Interrupts Enable


\
\ @brief external interrupt configuration register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_EXTICR1_EXTI0                             \ EXTI x configuration (x = 0 to 3)
$000000f0 constant SYSCFG_EXTICR1_EXTI1                             \ EXTI x configuration (x = 0 to 3)
$00000f00 constant SYSCFG_EXTICR1_EXTI2                             \ EXTI x configuration (x = 0 to 3)
$0000f000 constant SYSCFG_EXTICR1_EXTI3                             \ EXTI x configuration (x = 0 to 3)


\
\ @brief external interrupt configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_EXTICR2_EXTI4                             \ EXTI x configuration (x = 4 to 7)
$000000f0 constant SYSCFG_EXTICR2_EXTI5                             \ EXTI x configuration (x = 4 to 7)
$00000f00 constant SYSCFG_EXTICR2_EXTI6                             \ EXTI x configuration (x = 4 to 7)
$0000f000 constant SYSCFG_EXTICR2_EXTI7                             \ EXTI x configuration (x = 4 to 7)


\
\ @brief external interrupt configuration register 3
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_EXTICR3_EXTI8                             \ EXTI x configuration (x = 8 to 11)
$000000f0 constant SYSCFG_EXTICR3_EXTI9                             \ EXTI x configuration (x = 8 to 11)
$00000f00 constant SYSCFG_EXTICR3_EXTI10                            \ EXTI10
$0000f000 constant SYSCFG_EXTICR3_EXTI11                            \ EXTI x configuration (x = 8 to 11)


\
\ @brief external interrupt configuration register 4
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_EXTICR4_EXTI12                            \ EXTI x configuration (x = 12 to 15)
$000000f0 constant SYSCFG_EXTICR4_EXTI13                            \ EXTI x configuration (x = 12 to 15)
$00000f00 constant SYSCFG_EXTICR4_EXTI14                            \ EXTI x configuration (x = 12 to 15)
$0000f000 constant SYSCFG_EXTICR4_EXTI15                            \ EXTI x configuration (x = 12 to 15)


\
\ @brief CCM SRAM control and status register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SCSR_CCMER                                \ CCM SRAM Erase
$00000002 constant SYSCFG_SCSR_CCMBSY                               \ CCM SRAM busy by erase operation


\
\ @brief configuration register 2
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_CFGR2_CLL                                 \ Core Lockup Lock
$00000002 constant SYSCFG_CFGR2_SPL                                 \ SRAM Parity Lock
$00000004 constant SYSCFG_CFGR2_PVDL                                \ PVD Lock
$00000008 constant SYSCFG_CFGR2_ECCL                                \ ECC Lock
$00000100 constant SYSCFG_CFGR2_SPF                                 \ SRAM Parity Flag


\
\ @brief SRAM Write protection register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SWPR_PAGE0_WP                             \ Write protection
$00000002 constant SYSCFG_SWPR_PAGE1_WP                             \ Write protection
$00000004 constant SYSCFG_SWPR_PAGE2_WP                             \ Write protection
$00000008 constant SYSCFG_SWPR_PAGE3_WP                             \ Write protection
$00000010 constant SYSCFG_SWPR_PAGE4_WP                             \ Write protection
$00000020 constant SYSCFG_SWPR_PAGE5_WP                             \ Write protection
$00000040 constant SYSCFG_SWPR_PAGE6_WP                             \ Write protection
$00000080 constant SYSCFG_SWPR_PAGE7_WP                             \ Write protection
$00000100 constant SYSCFG_SWPR_PAGE8_WP                             \ Write protection
$00000200 constant SYSCFG_SWPR_PAGE9_WP                             \ Write protection
$00000400 constant SYSCFG_SWPR_PAGE10_WP                            \ Write protection
$00000800 constant SYSCFG_SWPR_PAGE11_WP                            \ Write protection
$00001000 constant SYSCFG_SWPR_PAGE12_WP                            \ Write protection
$00002000 constant SYSCFG_SWPR_PAGE13_WP                            \ Write protection
$00004000 constant SYSCFG_SWPR_PAGE14_WP                            \ Write protection
$00008000 constant SYSCFG_SWPR_PAGE15_WP                            \ Write protection
$00010000 constant SYSCFG_SWPR_PAGE16_WP                            \ Write protection
$00020000 constant SYSCFG_SWPR_PAGE17_WP                            \ Write protection
$00040000 constant SYSCFG_SWPR_PAGE18_WP                            \ Write protection
$00080000 constant SYSCFG_SWPR_PAGE19_WP                            \ Write protection
$00100000 constant SYSCFG_SWPR_PAGE20_WP                            \ Write protection
$00200000 constant SYSCFG_SWPR_PAGE21_WP                            \ Write protection
$00400000 constant SYSCFG_SWPR_PAGE22_WP                            \ Write protection
$00800000 constant SYSCFG_SWPR_PAGE23_WP                            \ Write protection
$01000000 constant SYSCFG_SWPR_PAGE24_WP                            \ Write protection
$02000000 constant SYSCFG_SWPR_PAGE25_WP                            \ Write protection
$04000000 constant SYSCFG_SWPR_PAGE26_WP                            \ Write protection
$08000000 constant SYSCFG_SWPR_PAGE27_WP                            \ Write protection
$10000000 constant SYSCFG_SWPR_PAGE28_WP                            \ Write protection
$20000000 constant SYSCFG_SWPR_PAGE29_WP                            \ Write protection
$40000000 constant SYSCFG_SWPR_PAGE30_WP                            \ Write protection
$80000000 constant SYSCFG_SWPR_PAGE31_WP                            \ Write protection


\
\ @brief SRAM2 Key Register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant SYSCFG_SKR_KEY                                   \ SRAM2 Key for software erase


\
\ @brief System configuration controller
\
$40010000 constant SYSCFG_MEMRMP  \ offset: 0x00 : Remap Memory register
$40010004 constant SYSCFG_CFGR1   \ offset: 0x04 : peripheral mode configuration register
$40010008 constant SYSCFG_EXTICR1  \ offset: 0x08 : external interrupt configuration register 1
$4001000c constant SYSCFG_EXTICR2  \ offset: 0x0C : external interrupt configuration register 2
$40010010 constant SYSCFG_EXTICR3  \ offset: 0x10 : external interrupt configuration register 3
$40010014 constant SYSCFG_EXTICR4  \ offset: 0x14 : external interrupt configuration register 4
$40010018 constant SYSCFG_SCSR    \ offset: 0x18 : CCM SRAM control and status register
$4001001c constant SYSCFG_CFGR2   \ offset: 0x1C : configuration register 2
$40010020 constant SYSCFG_SWPR    \ offset: 0x20 : SRAM Write protection register 1
$40010024 constant SYSCFG_SKR     \ offset: 0x24 : SRAM2 Key Register

