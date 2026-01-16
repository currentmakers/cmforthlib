\
\ @file syscfg.fs
\ @brief SYSCFG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief This register is used to know the state of BOOT pins and to control pull-up to reduce the static power consumption on the pin set to high level. )
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_BOOTR_BOOT0                        \ BOOT0
$00000002 constant SYSCFG_SYSCFG_BOOTR_BOOT1                        \ BOOT1
$00000004 constant SYSCFG_SYSCFG_BOOTR_BOOT2                        \ BOOT2
$00000010 constant SYSCFG_SYSCFG_BOOTR_BOOT0_PD                     \ BOOT0_PD
$00000020 constant SYSCFG_SYSCFG_BOOTR_BOOT1_PD                     \ BOOT1_PD
$00000040 constant SYSCFG_SYSCFG_BOOTR_BOOT2_PD                     \ BOOT2_PD


\
\ @brief SYSCFG peripheral mode configuration set register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_PMCSETR_I2C1_FMP                   \ I2C1_FMP
$00000002 constant SYSCFG_SYSCFG_PMCSETR_I2C2_FMP                   \ I2C2_FMP
$00000004 constant SYSCFG_SYSCFG_PMCSETR_I2C3_FMP                   \ I2C3_FMP
$00000008 constant SYSCFG_SYSCFG_PMCSETR_I2C4_FMP                   \ I2C4_FMP
$00000010 constant SYSCFG_SYSCFG_PMCSETR_I2C5_FMP                   \ I2C5_FMP
$00000020 constant SYSCFG_SYSCFG_PMCSETR_I2C6_FMP                   \ I2C6_FMP
$00000100 constant SYSCFG_SYSCFG_PMCSETR_EN_BOOSTER                 \ EN_BOOSTER
$00000200 constant SYSCFG_SYSCFG_PMCSETR_ANASWVDD                   \ ANASWVDD
$00010000 constant SYSCFG_SYSCFG_PMCSETR_ETH_CLK_SEL                \ ETH_CLK_SEL
$00020000 constant SYSCFG_SYSCFG_PMCSETR_ETH_REF_CLK_SEL            \ ETH_REF_CLK_SEL
$00100000 constant SYSCFG_SYSCFG_PMCSETR_ETH_SELMII                 \ ETH_SELMII
$00e00000 constant SYSCFG_SYSCFG_PMCSETR_ETH_SEL                    \ ETH_SEL
$01000000 constant SYSCFG_SYSCFG_PMCSETR_ANA0_SEL                   \ ANA0_SEL
$02000000 constant SYSCFG_SYSCFG_PMCSETR_ANA1_SEL                   \ ANA1_SEL


\
\ @brief SYSCFG IO control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_IOCTRLSETR_HSLVEN_TRACE            \ HSLVEN_TRACE
$00000002 constant SYSCFG_SYSCFG_IOCTRLSETR_HSLVEN_QUADSPI          \ HSLVEN_QUADSPI
$00000004 constant SYSCFG_SYSCFG_IOCTRLSETR_HSLVEN_ETH              \ HSLVEN_ETH
$00000008 constant SYSCFG_SYSCFG_IOCTRLSETR_HSLVEN_SDMMC            \ HSLVEN_SDMMC
$00000010 constant SYSCFG_SYSCFG_IOCTRLSETR_HSLVEN_SPI              \ HSLVEN_SPI


\
\ @brief SYSCFG interconnect control register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ICNR_AXI_M0                        \ AXI_M0
$00000002 constant SYSCFG_SYSCFG_ICNR_AXI_M1                        \ AXI_M1
$00000004 constant SYSCFG_SYSCFG_ICNR_AXI_M2                        \ AXI_M2
$00000008 constant SYSCFG_SYSCFG_ICNR_AXI_M3                        \ AXI_M3
$00000020 constant SYSCFG_SYSCFG_ICNR_AXI_M5                        \ AXI_M5
$00000040 constant SYSCFG_SYSCFG_ICNR_AXI_M6                        \ AXI_M6
$00000080 constant SYSCFG_SYSCFG_ICNR_AXI_M7                        \ AXI_M7
$00000100 constant SYSCFG_SYSCFG_ICNR_AXI_M8                        \ AXI_M8
$00000200 constant SYSCFG_SYSCFG_ICNR_AXI_M9                        \ AXI_M9
$00000400 constant SYSCFG_SYSCFG_ICNR_AXI_M10                       \ AXI_M10


\
\ @brief SYSCFG compensation cell control register
\ Address offset: 0x20
\ Reset value: 0x00870000
\

$00000002 constant SYSCFG_SYSCFG_CMPCR_SW_CTRL                      \ SW_CTRL
$00000100 constant SYSCFG_SYSCFG_CMPCR_READY                        \ READY
$000f0000 constant SYSCFG_SYSCFG_CMPCR_RANSRC                       \ RANSRC
$00f00000 constant SYSCFG_SYSCFG_CMPCR_RAPSRC                       \ RAPSRC
$0f000000 constant SYSCFG_SYSCFG_CMPCR_ANSRC                        \ ANSRC
$f0000000 constant SYSCFG_SYSCFG_CMPCR_APSRC                        \ APSRC


\
\ @brief SYSCFG compensation cell enable set register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_CMPENSETR_MPU_EN                   \ MPU_EN
$00000002 constant SYSCFG_SYSCFG_CMPENSETR_MCU_EN                   \ MCU_EN


\
\ @brief SYSCFG compensation cell enable set register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_CMPENCLRR_MPU_EN                   \ MPU_EN
$00000002 constant SYSCFG_SYSCFG_CMPENCLRR_MCU_EN                   \ MCU_EN


\
\ @brief SYSCFG control timer break register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_CBR_CLL                            \ CLL
$00000004 constant SYSCFG_SYSCFG_CBR_PVDL                           \ PVDL


\
\ @brief SYSCFG peripheral mode configuration clear register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_PMCCLRR_I2C1_FMP                   \ I2C1_FMP
$00000002 constant SYSCFG_SYSCFG_PMCCLRR_I2C2_FMP                   \ I2C2_FMP
$00000004 constant SYSCFG_SYSCFG_PMCCLRR_I2C3_FMP                   \ I2C3_FMP
$00000008 constant SYSCFG_SYSCFG_PMCCLRR_I2C4_FMP                   \ I2C4_FMP
$00000010 constant SYSCFG_SYSCFG_PMCCLRR_I2C5_FMP                   \ I2C5_FMP
$00000020 constant SYSCFG_SYSCFG_PMCCLRR_I2C6_FMP                   \ I2C6_FMP
$00000100 constant SYSCFG_SYSCFG_PMCCLRR_EN_BOOSTER                 \ EN_BOOSTER
$00000200 constant SYSCFG_SYSCFG_PMCCLRR_ANASWVDD                   \ ANASWVDD
$00010000 constant SYSCFG_SYSCFG_PMCCLRR_ETH_CLK_SEL                \ ETH_CLK_SEL
$00020000 constant SYSCFG_SYSCFG_PMCCLRR_ETH_REF_CLK_SEL            \ ETH_REF_CLK_SEL
$00100000 constant SYSCFG_SYSCFG_PMCCLRR_ETH_SELMII                 \ ETH_SELMII
$00e00000 constant SYSCFG_SYSCFG_PMCCLRR_ETH_SEL                    \ ETH_SEL
$01000000 constant SYSCFG_SYSCFG_PMCCLRR_ANA0_SEL                   \ ANA0_SEL
$02000000 constant SYSCFG_SYSCFG_PMCCLRR_ANA1_SEL                   \ ANA1_SEL


\
\ @brief SYSCFG IO control register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_IOCTRLCLRR_HSLVEN_TRACE            \ HSLVEN_TRACE
$00000002 constant SYSCFG_SYSCFG_IOCTRLCLRR_HSLVEN_QUADSPI          \ HSLVEN_QUADSPI
$00000004 constant SYSCFG_SYSCFG_IOCTRLCLRR_HSLVEN_ETH              \ HSLVEN_ETH
$00000008 constant SYSCFG_SYSCFG_IOCTRLCLRR_HSLVEN_SDMMC            \ HSLVEN_SDMMC
$00000010 constant SYSCFG_SYSCFG_IOCTRLCLRR_HSLVEN_SPI              \ HSLVEN_SPI


\
\ @brief SYSCFG version register
\ Address offset: 0x3F4
\ Reset value: 0x00000020
\

$0000000f constant SYSCFG_SYSCFG_VERR_MINREV                        \ MINREV
$000000f0 constant SYSCFG_SYSCFG_VERR_MAJREV                        \ MAJREV


\
\ @brief SYSCFG identification register
\ Address offset: 0x3F8
\ Reset value: 0x00030001
\

$00000000 constant SYSCFG_SYSCFG_IPIDR_ID                           \ ID


\
\ @brief SYSCFG size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant SYSCFG_SYSCFG_SIDR_SID                           \ SID


\
\ @brief SYSCFG
\
$50020000 constant SYSCFG_SYSCFG_BOOTR  \ offset: 0x00 : This register is used to know the state of BOOT pins and to control pull-up to reduce the static power consumption on the pin set to high level. )
$50020004 constant SYSCFG_SYSCFG_PMCSETR  \ offset: 0x04 : SYSCFG peripheral mode configuration set register
$50020018 constant SYSCFG_SYSCFG_IOCTRLSETR  \ offset: 0x18 : SYSCFG IO control register
$5002001c constant SYSCFG_SYSCFG_ICNR  \ offset: 0x1C : SYSCFG interconnect control register
$50020020 constant SYSCFG_SYSCFG_CMPCR  \ offset: 0x20 : SYSCFG compensation cell control register
$50020024 constant SYSCFG_SYSCFG_CMPENSETR  \ offset: 0x24 : SYSCFG compensation cell enable set register
$50020028 constant SYSCFG_SYSCFG_CMPENCLRR  \ offset: 0x28 : SYSCFG compensation cell enable set register
$5002002c constant SYSCFG_SYSCFG_CBR  \ offset: 0x2C : SYSCFG control timer break register
$50020044 constant SYSCFG_SYSCFG_PMCCLRR  \ offset: 0x44 : SYSCFG peripheral mode configuration clear register
$50020058 constant SYSCFG_SYSCFG_IOCTRLCLRR  \ offset: 0x58 : SYSCFG IO control register
$500203f4 constant SYSCFG_SYSCFG_VERR  \ offset: 0x3F4 : SYSCFG version register
$500203f8 constant SYSCFG_SYSCFG_IPIDR  \ offset: 0x3F8 : SYSCFG identification register
$500203fc constant SYSCFG_SYSCFG_SIDR  \ offset: 0x3FC : SYSCFG size identification register

