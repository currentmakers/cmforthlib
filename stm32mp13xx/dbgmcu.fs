\
\ @file dbgmcu.fs
\ @brief Microcontroller Debug Unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DBGMCU identity code register
\ Address offset: 0x00
\ Reset value: 0x10006501
\

$00000fff constant DBGMCU_DBGMCU_IDC_DEV_ID                         \ device ID
$ffff0000 constant DBGMCU_DBGMCU_IDC_REV_ID                         \ revision 0x1000 = Rev. 1


\
\ @brief DBGMCU configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000004 constant DBGMCU_DBGMCU_CR_DBGLP                           \ Low power mode debug enable


\
\ @brief DBGMCU APB4 peripheral freeze register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000004 constant DBGMCU_DBGMCU_APB4FZ_IWDG2                       \ IWDG2 stop in debug


\
\ @brief DBGMCU APB1 peripheral freeze register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_APB1FZ_TIM2                        \ TIM2 stop in debug
$00000002 constant DBGMCU_DBGMCU_APB1FZ_TIM3                        \ TIM3 stop in debug
$00000004 constant DBGMCU_DBGMCU_APB1FZ_TIM4                        \ TIM4 stop in debug
$00000008 constant DBGMCU_DBGMCU_APB1FZ_TIM5                        \ TIM5 stop in debug
$00000010 constant DBGMCU_DBGMCU_APB1FZ_TIM6                        \ TIM6 stop in debug
$00000020 constant DBGMCU_DBGMCU_APB1FZ_TIM7                        \ TIM7 stop in debug
$00000200 constant DBGMCU_DBGMCU_APB1FZ_LPTIM1                      \ LPTIM1 stop in debug
$00040000 constant DBGMCU_DBGMCU_APB1FZ_I2C1                        \ I2C1 SMBUS timeout stop in debug
$00080000 constant DBGMCU_DBGMCU_APB1FZ_I2C2                        \ I2C2 SMBUS timeout stop in debug


\
\ @brief DBGMCU APB2 peripheral freeze register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_APB2FZ_TIM1                        \ TIM1 stop in debug
$00000002 constant DBGMCU_DBGMCU_APB2FZ_TIM8                        \ TIM8 stop in debug
$00008000 constant DBGMCU_DBGMCU_APB2FZ_FDCAN                       \ FDCAN stop in debug


\
\ @brief DBGMCU APB3 peripheral freeze register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000002 constant DBGMCU_DBGMCU_APB3FZ_LPTIM2                      \ LPTIM2 stop in debug
$00000004 constant DBGMCU_DBGMCU_APB3FZ_LPTIM3                      \ LPTIM3 stop in debug
$00000008 constant DBGMCU_DBGMCU_APB3FZ_LPTIM4                      \ LPTIM4 stop in debug
$00000010 constant DBGMCU_DBGMCU_APB3FZ_LPTIM5                      \ LPTIM5 stop in debug


\
\ @brief DBGMCU APB5 peripheral freeze register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000008 constant DBGMCU_DBGMCU_APB5FZ_IWDG1                       \ independent watchdog 1 stop in debug
$00000010 constant DBGMCU_DBGMCU_APB5FZ_RTC                         \ RTC stop in debug


\
\ @brief DBGMCU APB6 peripheral freeze register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000010 constant DBGMCU_DBGMCU_APB6FZ_I2C3                        \ I2C3 SMBUS stop in debug
$00000020 constant DBGMCU_DBGMCU_APB6FZ_I2C4                        \ I2C4 SMBUS stop in debug
$00000040 constant DBGMCU_DBGMCU_APB6FZ_I2C5                        \ I2C5 SMBUS stop in debug
$00000080 constant DBGMCU_DBGMCU_APB6FZ_TIM12                       \ TIM12 stop in debug
$00000100 constant DBGMCU_DBGMCU_APB6FZ_TIM13                       \ TIM13 stop in debug
$00000200 constant DBGMCU_DBGMCU_APB6FZ_TIM14                       \ TIM14 stop in debug
$00000400 constant DBGMCU_DBGMCU_APB6FZ_TIM15                       \ TIM15 stop in debug
$00000800 constant DBGMCU_DBGMCU_APB6FZ_TIM16                       \ TIM16 stop in debug
$00001000 constant DBGMCU_DBGMCU_APB6FZ_TIM17                       \ TIM17 stop in debug


\
\ @brief DBGMCU peripheral ID4 register
\ Address offset: 0xFD0
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_DBGMCU_PIDR4_DES_2                        \ JEDEC continuation code Indicates the designer of the component, together with the identity code.
$000000f0 constant DBGMCU_DBGMCU_PIDR4_SIZE                         \ component memory size indicator Indicates the total contiguous size of the memory window used by the component in powers of two from the standard 4Â Kbytes. If a component only requires the standard 4Â Kbytes, this bit field must read as 0x0. For 8Â Kbytes it is set to 0x1. For 16Â Kbytes it set to 0x2. For 32Â Kbytes it is set to 0x3, and similarly for larger memory windows.


\
\ @brief DBGMCU peripheral ID0 register
\ Address offset: 0xFE0
\ Reset value: 0x00000000
\

$000000ff constant DBGMCU_DBGMCU_PIDR0_PART_0                       \ bits [7:0] of the component part number This field is specified by the designer of the component.


\
\ @brief DBGMCU peripheral ID1 register
\ Address offset: 0xFE4
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_DBGMCU_PIDR1_PART_1                       \ bits [11:8] of the component part number Specified by the designer of the component.
$000000f0 constant DBGMCU_DBGMCU_PIDR1_DES_0                        \ bits [3:0] of the JEDEC identity code Indicates the designer of the component, together with the continuation code.


\
\ @brief DBGMCU peripheral ID2 register
\ Address offset: 0xFE8
\ Reset value: 0x0000000A
\

$00000007 constant DBGMCU_DBGMCU_PIDR2_DES_1                        \ bits [6:4] of the JEDEC identity code Indicates the designer of the component, together with the continuation code.
$00000008 constant DBGMCU_DBGMCU_PIDR2_JEDEC                        \ JEDEC assigned value usage Indicates the use of a JEDEC assigned value. This bit is always set.
$000000f0 constant DBGMCU_DBGMCU_PIDR2_REVISION                     \ incremental component design version An incremental value starting from 0x0 for the first design of this component. The value increases by one at both major and minor revisions and is used as a look-up to establish the exact major and minor revisions.


\
\ @brief DBGMCU peripheral ID3 register
\ Address offset: 0xFEC
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_DBGMCU_PIDR3_CMOD                         \ customer modification indicator When the component is a reusable IP, this value indicates if the customer has modified the behavior of the component. In most cases this field is 0x0.
$000000f0 constant DBGMCU_DBGMCU_PIDR3_REVAND                       \ minor fix indicator Indicates minor errata fixes specific to the design, for example metal fixes after implementation. In most cases this field is 0x0. ArmÂ® recommends that the component designers ensure that the bit field can be changed by a metal fix if required, for example by driving the bit field from registers that reset to zero.


\
\ @brief DBGMCU component ID0 register
\ Address offset: 0xFF0
\ Reset value: 0x0000000D
\

$000000ff constant DBGMCU_DBGMCU_CIDR0_PRMBL_0                      \ bits [31:24] of component identification Component identification register, that indicates that the identification registers are present.


\
\ @brief DBGMCU component ID1 register
\ Address offset: 0xFF4
\ Reset value: 0x000000F0
\

$0000000f constant DBGMCU_DBGMCU_CIDR1_PRMBL_1                      \ bits [19:16] of component identification. Component identification register, that indicates that the identification registers are present.
$000000f0 constant DBGMCU_DBGMCU_CIDR1_CLASS                        \ component class Indicates the class of the component, for example, ROM table or CoreSightâ¢ component.


\
\ @brief DBGMCU component ID2 register
\ Address offset: 0xFF8
\ Reset value: 0x00000005
\

$000000ff constant DBGMCU_DBGMCU_CIDR2_PRMBL_2                      \ bits [15:8] of component identification Component identification register, that indicates that the identification registers are present.


\
\ @brief DBGMCU component ID3 register
\ Address offset: 0xFFC
\ Reset value: 0x000000B1
\

$000000ff constant DBGMCU_DBGMCU_CIDR3_PRMBL_3                      \ bits [7:0] of component identification Component identification register, that indicates that the identification registers are present.


\
\ @brief Microcontroller Debug Unit
\
$50081000 constant DBGMCU_DBGMCU_IDC  \ offset: 0x00 : DBGMCU identity code register
$50081004 constant DBGMCU_DBGMCU_CR  \ offset: 0x04 : DBGMCU configuration register
$5008102c constant DBGMCU_DBGMCU_APB4FZ  \ offset: 0x2C : DBGMCU APB4 peripheral freeze register
$50081034 constant DBGMCU_DBGMCU_APB1FZ  \ offset: 0x34 : DBGMCU APB1 peripheral freeze register
$5008103c constant DBGMCU_DBGMCU_APB2FZ  \ offset: 0x3C : DBGMCU APB2 peripheral freeze register
$50081044 constant DBGMCU_DBGMCU_APB3FZ  \ offset: 0x44 : DBGMCU APB3 peripheral freeze register
$5008104c constant DBGMCU_DBGMCU_APB5FZ  \ offset: 0x4C : DBGMCU APB5 peripheral freeze register
$50081054 constant DBGMCU_DBGMCU_APB6FZ  \ offset: 0x54 : DBGMCU APB6 peripheral freeze register
$50081fd0 constant DBGMCU_DBGMCU_PIDR4  \ offset: 0xFD0 : DBGMCU peripheral ID4 register
$50081fe0 constant DBGMCU_DBGMCU_PIDR0  \ offset: 0xFE0 : DBGMCU peripheral ID0 register
$50081fe4 constant DBGMCU_DBGMCU_PIDR1  \ offset: 0xFE4 : DBGMCU peripheral ID1 register
$50081fe8 constant DBGMCU_DBGMCU_PIDR2  \ offset: 0xFE8 : DBGMCU peripheral ID2 register
$50081fec constant DBGMCU_DBGMCU_PIDR3  \ offset: 0xFEC : DBGMCU peripheral ID3 register
$50081ff0 constant DBGMCU_DBGMCU_CIDR0  \ offset: 0xFF0 : DBGMCU component ID0 register
$50081ff4 constant DBGMCU_DBGMCU_CIDR1  \ offset: 0xFF4 : DBGMCU component ID1 register
$50081ff8 constant DBGMCU_DBGMCU_CIDR2  \ offset: 0xFF8 : DBGMCU component ID2 register
$50081ffc constant DBGMCU_DBGMCU_CIDR3  \ offset: 0xFFC : DBGMCU component ID3 register

