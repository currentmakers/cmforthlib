\
\ @file gtzc1.fs
\ @brief Global privilege controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GTZC1 TZSC privilege configuration register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_TIM2PRIV              \ privileged access mode for TIM2
$00000002 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_TIM3PRIV              \ privileged access mode for TIM3
$00000010 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_TIM6PRIV              \ privileged access mode for TIM6
$00000020 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_TIM7PRIV              \ privileged access mode for TIM7
$00000200 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_WWDGPRIV              \ privileged access mode for WWDG
$00000400 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_IWDGPRIV              \ privileged access mode for IWDG
$00000800 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_SPI2PRIV              \ privileged access mode for SPI2
$00001000 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_SPI3PRIV              \ privileged access mode for SPI3
$00002000 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_USART2PRIV            \ privileged access mode for USART2
$00004000 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_USART3PRIV            \ privileged access mode for USART3
$00020000 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_I2C1PRIV              \ privileged access mode for I2C1
$00040000 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_I2C2PRIV              \ privileged access mode for I2C2
$00080000 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_I3C1PRIV              \ privileged access mode for I3C1
$00100000 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_CRSPRIV               \ privileged access mode for CRS
$02000000 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_DAC1PRIV              \ privileged access mode for DAC1
$40000000 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_DTSPRIV               \ privileged access mode for DTS
$80000000 constant GTZC1_GTZC1_TZSC_PRIVCFGR1_LPTIM2PRIV            \ privileged access mode for LPTIM2


\
\ @brief GTZC1 TZSC privilege configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_TZSC_PRIVCFGR2_FDCAN1PRIV            \ privileged access mode for FDCAN1
$00000008 constant GTZC1_GTZC1_TZSC_PRIVCFGR2_OPAMPPRIV             \ privileged access mode for OPAMP
$00000010 constant GTZC1_GTZC1_TZSC_PRIVCFGR2_COMPPRIV              \ privileged access mode for COMP
$00000100 constant GTZC1_GTZC1_TZSC_PRIVCFGR2_TIM1PRIV              \ privileged access mode for TIM1
$00000200 constant GTZC1_GTZC1_TZSC_PRIVCFGR2_SPI1PRIV              \ privileged access mode for SPI1
$00000800 constant GTZC1_GTZC1_TZSC_PRIVCFGR2_USART1PRIV            \ privileged access mode for USART1
$00080000 constant GTZC1_GTZC1_TZSC_PRIVCFGR2_USBFSPRIV             \ privileged access mode for USBSF
$02000000 constant GTZC1_GTZC1_TZSC_PRIVCFGR2_LPUART1PRIV           \ privileged access mode for LPUART
$10000000 constant GTZC1_GTZC1_TZSC_PRIVCFGR2_LPTIM1PRIV            \ privileged access mode for LPTIM1


\
\ @brief GTZC1 TZSC privilege configuration register 3
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000004 constant GTZC1_GTZC1_TZSC_PRIVCFGR3_I3C2PRIV              \ privileged access mode for I3C2
$00000100 constant GTZC1_GTZC1_TZSC_PRIVCFGR3_CRCPRIV               \ privileged access mode for CRC
$00001000 constant GTZC1_GTZC1_TZSC_PRIVCFGR3_ICACHEPRIV            \ privileged access mode for ICACHE
$00004000 constant GTZC1_GTZC1_TZSC_PRIVCFGR3_ADC1PRIV              \ privileged access mode for ADC1
$00020000 constant GTZC1_GTZC1_TZSC_PRIVCFGR3_HASHPRIV              \ privileged access mode for HASH
$00040000 constant GTZC1_GTZC1_TZSC_PRIVCFGR3_RNGPRIV               \ privileged access mode for RNG
$04000000 constant GTZC1_GTZC1_TZSC_PRIVCFGR3_RAMCFGPRIV            \ privileged access mode for RAMSCFG


\
\ @brief GTZC1 TZSC BKPSRAM sub-region A watermark configuration register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_TZSC_MPCWM4ACFGR_SREN                \ Sub-region z enable
$00000002 constant GTZC1_GTZC1_TZSC_MPCWM4ACFGR_SRLOCK              \ Sub-region z lock This bit, once set, can be cleared only by a system reset.
$00000200 constant GTZC1_GTZC1_TZSC_MPCWM4ACFGR_PRIV                \ Privileged sub-region z This bit is taken into account only if SREN is set.


\
\ @brief GTZC1 TZSC BKPSRAM sub-region A watermark register
\ Address offset: 0x74
\ Reset value: 0x08000000
\

$000007ff constant GTZC1_GTZC1_TZSC_MPCWM4AR_SUBA_START             \ Start of sub-region A This field defines the address offset of the sub-region A, to be multiplied by the granularity defined in Table 16.
$0fff0000 constant GTZC1_GTZC1_TZSC_MPCWM4AR_SUBA_LENGTH            \ Length of sub-region A This field defines the length of the sub-region A, to be multiplied by the granularity defined in Table 16. When SUBA_START + SUBA_LENGTH is higher than the maximum size allowed for the memory, a saturation of SUBA_LENGTH is applied automatically. If SUBA_LENGTH = 0, the sub-region A is disabled (SREN bit in GTZC1_TZSC_MPCMWACFGR is cleared).


\
\ @brief GTZC1 TZSC BKPSRAM sub-region B watermark configuration register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_TZSC_MPCWM4BCFGR_SREN                \ Sub-region z enable
$00000002 constant GTZC1_GTZC1_TZSC_MPCWM4BCFGR_SRLOCK              \ Sub-region z lock This bit, once set, can be cleared only by a system reset.
$00000200 constant GTZC1_GTZC1_TZSC_MPCWM4BCFGR_PRIV                \ Privileged sub-region z This bit is taken into account only if SREN is set.


\
\ @brief GTZC1 TZSC BKPSRAM sub-region B watermark register
\ Address offset: 0x7C
\ Reset value: 0x08000000
\

$000007ff constant GTZC1_GTZC1_TZSC_MPCWM4BR_SUBB_START             \ Start of sub-region B This field defines the address offset of the sub-region B, to be multiplied by the granularity defined in Table 16.
$0fff0000 constant GTZC1_GTZC1_TZSC_MPCWM4BR_SUBB_LENGTH            \ Length of sub-region B This field defines the length of the sub-region B, to be multiplied by the granularity defined in Table 16. When SUBB_START + SUBB_LENGTH is higher than the maximum size allowed for the memory, a saturation of SUBB_LENGTH is applied automatically. If SUBB_LENGTH = 0, the sub-region B is disabled (SREN bit in GTZC1_TZSC_MPCMWBCFGR is cleared).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 0 register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 1 register
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 2 register
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 3 register
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 4 register
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 5 register
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 6 register
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 7 register
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 8 register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 9 register
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 10 register
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 11 register
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 12 register
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 13 register
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 14 register
\ Address offset: 0x238
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 15 register
\ Address offset: 0x23C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 16 register
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 17 register
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 18 register
\ Address offset: 0x248
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 19 register
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 20 register
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 21 register
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 22 register
\ Address offset: 0x258
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 23 register
\ Address offset: 0x25C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 24 register
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 25 register
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 26 register
\ Address offset: 0x268
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 27 register
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 28 register
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 29 register
\ Address offset: 0x274
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 30 register
\ Address offset: 0x278
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 31 register
\ Address offset: 0x27C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 0 register
\ Address offset: 0x600
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 1 register
\ Address offset: 0x604
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 2 register
\ Address offset: 0x608
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 3 register
\ Address offset: 0x60C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 4 register
\ Address offset: 0x610
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 5 register
\ Address offset: 0x614
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 6 register
\ Address offset: 0x618
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 7 register
\ Address offset: 0x61C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 8 register
\ Address offset: 0x620
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 9 register
\ Address offset: 0x624
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV0               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV1               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV2               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV3               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV4               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV5               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV6               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV7               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV8               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV9               \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV10              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV11              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV12              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV13              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV14              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV15              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV16              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV17              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV18              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV19              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV20              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV21              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV22              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV23              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV24              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV25              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV26              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV27              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV28              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV29              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV30              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9_PRIV31              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 10 register
\ Address offset: 0x628
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 11 register
\ Address offset: 0x62C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 12 register
\ Address offset: 0x630
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 13 register
\ Address offset: 0x634
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 14 register
\ Address offset: 0x638
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 15 register
\ Address offset: 0x63C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 16 register
\ Address offset: 0x640
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 17 register
\ Address offset: 0x644
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 18 register
\ Address offset: 0x648
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 19 register
\ Address offset: 0x64C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 20 register
\ Address offset: 0x650
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 21 register
\ Address offset: 0x654
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 22 register
\ Address offset: 0x658
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 23 register
\ Address offset: 0x65C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 24 register
\ Address offset: 0x660
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 25 register
\ Address offset: 0x664
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 26 register
\ Address offset: 0x668
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 27 register
\ Address offset: 0x66C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 28 register
\ Address offset: 0x670
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 29 register
\ Address offset: 0x674
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 30 register
\ Address offset: 0x678
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 31 register
\ Address offset: 0x67C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV0              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000002 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV1              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000004 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV2              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000008 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV3              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000010 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV4              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000020 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV5              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000040 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV6              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000080 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV7              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000100 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV8              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000200 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV9              \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000400 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV10             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00000800 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV11             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00001000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV12             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00002000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV13             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00004000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV14             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00008000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV15             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00010000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV16             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00020000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV17             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00040000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV18             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00080000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV19             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00100000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV20             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00200000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV21             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00400000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV22             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$00800000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV23             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$01000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV24             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$02000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV25             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$04000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV26             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$08000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV27             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$10000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV28             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$20000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV29             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$40000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV30             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
$80000000 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31_PRIV31             \ Privileged configuration for block y, belonging to super-block x (y = 31 to 0).


\
\ @brief Global privilege controller
\
$40032420 constant GTZC1_GTZC1_TZSC_PRIVCFGR1  \ offset: 0x20 : GTZC1 TZSC privilege configuration register 1
$40032424 constant GTZC1_GTZC1_TZSC_PRIVCFGR2  \ offset: 0x24 : GTZC1 TZSC privilege configuration register 2
$40032428 constant GTZC1_GTZC1_TZSC_PRIVCFGR3  \ offset: 0x28 : GTZC1 TZSC privilege configuration register 3
$40032470 constant GTZC1_GTZC1_TZSC_MPCWM4ACFGR  \ offset: 0x70 : GTZC1 TZSC BKPSRAM sub-region A watermark configuration register
$40032474 constant GTZC1_GTZC1_TZSC_MPCWM4AR  \ offset: 0x74 : GTZC1 TZSC BKPSRAM sub-region A watermark register
$40032478 constant GTZC1_GTZC1_TZSC_MPCWM4BCFGR  \ offset: 0x78 : GTZC1 TZSC BKPSRAM sub-region B watermark configuration register
$4003247c constant GTZC1_GTZC1_TZSC_MPCWM4BR  \ offset: 0x7C : GTZC1 TZSC BKPSRAM sub-region B watermark register
$40032600 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0  \ offset: 0x200 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 0 register
$40032604 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1  \ offset: 0x204 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 1 register
$40032608 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2  \ offset: 0x208 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 2 register
$4003260c constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3  \ offset: 0x20C : GTZC1 SRAM1 MPCBB privileged configuration for super-block 3 register
$40032610 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4  \ offset: 0x210 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 4 register
$40032614 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5  \ offset: 0x214 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 5 register
$40032618 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6  \ offset: 0x218 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 6 register
$4003261c constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7  \ offset: 0x21C : GTZC1 SRAM1 MPCBB privileged configuration for super-block 7 register
$40032620 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8  \ offset: 0x220 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 8 register
$40032624 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9  \ offset: 0x224 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 9 register
$40032628 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10  \ offset: 0x228 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 10 register
$4003262c constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11  \ offset: 0x22C : GTZC1 SRAM1 MPCBB privileged configuration for super-block 11 register
$40032630 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12  \ offset: 0x230 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 12 register
$40032634 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13  \ offset: 0x234 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 13 register
$40032638 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14  \ offset: 0x238 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 14 register
$4003263c constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15  \ offset: 0x23C : GTZC1 SRAM1 MPCBB privileged configuration for super-block 15 register
$40032640 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16  \ offset: 0x240 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 16 register
$40032644 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17  \ offset: 0x244 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 17 register
$40032648 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18  \ offset: 0x248 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 18 register
$4003264c constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19  \ offset: 0x24C : GTZC1 SRAM1 MPCBB privileged configuration for super-block 19 register
$40032650 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20  \ offset: 0x250 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 20 register
$40032654 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21  \ offset: 0x254 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 21 register
$40032658 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22  \ offset: 0x258 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 22 register
$4003265c constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23  \ offset: 0x25C : GTZC1 SRAM1 MPCBB privileged configuration for super-block 23 register
$40032660 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24  \ offset: 0x260 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 24 register
$40032664 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25  \ offset: 0x264 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 25 register
$40032668 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26  \ offset: 0x268 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 26 register
$4003266c constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27  \ offset: 0x26C : GTZC1 SRAM1 MPCBB privileged configuration for super-block 27 register
$40032670 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28  \ offset: 0x270 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 28 register
$40032674 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29  \ offset: 0x274 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 29 register
$40032678 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30  \ offset: 0x278 : GTZC1 SRAM1 MPCBB privileged configuration for super-block 30 register
$4003267c constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31  \ offset: 0x27C : GTZC1 SRAM1 MPCBB privileged configuration for super-block 31 register
$40032a00 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0  \ offset: 0x600 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 0 register
$40032a04 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1  \ offset: 0x604 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 1 register
$40032a08 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2  \ offset: 0x608 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 2 register
$40032a0c constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3  \ offset: 0x60C : GTZC1 SRAM2 MPCBB privileged configuration for super-block 3 register
$40032a10 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4  \ offset: 0x610 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 4 register
$40032a14 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5  \ offset: 0x614 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 5 register
$40032a18 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6  \ offset: 0x618 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 6 register
$40032a1c constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7  \ offset: 0x61C : GTZC1 SRAM2 MPCBB privileged configuration for super-block 7 register
$40032a20 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8  \ offset: 0x620 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 8 register
$40032a24 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9  \ offset: 0x624 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 9 register
$40032a28 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10  \ offset: 0x628 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 10 register
$40032a2c constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11  \ offset: 0x62C : GTZC1 SRAM2 MPCBB privileged configuration for super-block 11 register
$40032a30 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12  \ offset: 0x630 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 12 register
$40032a34 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13  \ offset: 0x634 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 13 register
$40032a38 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14  \ offset: 0x638 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 14 register
$40032a3c constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15  \ offset: 0x63C : GTZC1 SRAM2 MPCBB privileged configuration for super-block 15 register
$40032a40 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16  \ offset: 0x640 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 16 register
$40032a44 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17  \ offset: 0x644 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 17 register
$40032a48 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18  \ offset: 0x648 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 18 register
$40032a4c constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19  \ offset: 0x64C : GTZC1 SRAM2 MPCBB privileged configuration for super-block 19 register
$40032a50 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20  \ offset: 0x650 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 20 register
$40032a54 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21  \ offset: 0x654 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 21 register
$40032a58 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22  \ offset: 0x658 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 22 register
$40032a5c constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23  \ offset: 0x65C : GTZC1 SRAM2 MPCBB privileged configuration for super-block 23 register
$40032a60 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24  \ offset: 0x660 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 24 register
$40032a64 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25  \ offset: 0x664 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 25 register
$40032a68 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26  \ offset: 0x668 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 26 register
$40032a6c constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27  \ offset: 0x66C : GTZC1 SRAM2 MPCBB privileged configuration for super-block 27 register
$40032a70 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28  \ offset: 0x670 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 28 register
$40032a74 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29  \ offset: 0x674 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 29 register
$40032a78 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30  \ offset: 0x678 : GTZC1 SRAM2 MPCBB privileged configuration for super-block 30 register
$40032a7c constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31  \ offset: 0x67C : GTZC1 SRAM2 MPCBB privileged configuration for super-block 31 register

