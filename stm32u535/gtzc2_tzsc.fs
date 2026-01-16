\
\ @file gtzc2_tzsc.fs
\ @brief GTZC2_TZSC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TZSC control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant GTZC2_TZSC_TZSC_CR_LCK                           \ lock the configuration of GTZC1_TZSC_SECCFGRx and GTZC1_TZSC_PRIVCFGRx registers until next reset


\
\ @brief TZSC secure configuration register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GTZC2_TZSC_TZSC_SECCFGR1_SPI3SEC                 \ secure access mode for SPI3
$00000002 constant GTZC2_TZSC_TZSC_SECCFGR1_LPUART1SEC              \ secure access mode for LPUART1
$00000004 constant GTZC2_TZSC_TZSC_SECCFGR1_I2C3SEC                 \ secure access mode for I2C3
$00000008 constant GTZC2_TZSC_TZSC_SECCFGR1_LPTIM1SEC               \ secure access mode for LPTIM1
$00000010 constant GTZC2_TZSC_TZSC_SECCFGR1_LPTIM3SEC               \ secure access mode for LPTIM3
$00000020 constant GTZC2_TZSC_TZSC_SECCFGR1_LPTIM4SEC               \ secure access mode for LPTIM4
$00000040 constant GTZC2_TZSC_TZSC_SECCFGR1_OPAMPSEC                \ secure access mode for OPAMP
$00000080 constant GTZC2_TZSC_TZSC_SECCFGR1_COMPSEC                 \ secure access mode for COMP
$00000200 constant GTZC2_TZSC_TZSC_SECCFGR1_VREFBUFSEC              \ secure access mode for VREFBUF
$00000800 constant GTZC2_TZSC_TZSC_SECCFGR1_DAC1SEC                 \ secure access mode for DAC1
$00001000 constant GTZC2_TZSC_TZSC_SECCFGR1_ADF1SEC                 \ secure access mode for ADF1


\
\ @brief TZSC privilege configuration register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant GTZC2_TZSC_TZSC_PRIVCFGR1_SPI3PRIV               \ privileged access mode for SPI3
$00000002 constant GTZC2_TZSC_TZSC_PRIVCFGR1_LPUART1PRIV            \ privileged access mode for LPUART1
$00000004 constant GTZC2_TZSC_TZSC_PRIVCFGR1_I2C3PRIV               \ privileged access mode for I2C3
$00000008 constant GTZC2_TZSC_TZSC_PRIVCFGR1_LPTIM1PRIV             \ privileged access mode for LPTIM1
$00000010 constant GTZC2_TZSC_TZSC_PRIVCFGR1_LPTIM3PRIV             \ privileged access mode for LPTIM3
$00000020 constant GTZC2_TZSC_TZSC_PRIVCFGR1_LPTIM4PRIV             \ privileged access mode for LPTIM4
$00000040 constant GTZC2_TZSC_TZSC_PRIVCFGR1_OPAMPPRIV              \ privileged access mode for OPAMP
$00000080 constant GTZC2_TZSC_TZSC_PRIVCFGR1_COMPPRIV               \ privileged access mode for COMP
$00000200 constant GTZC2_TZSC_TZSC_PRIVCFGR1_VREFBUFPRIV            \ privileged access mode for VREFBUF
$00000800 constant GTZC2_TZSC_TZSC_PRIVCFGR1_DAC1PRIV               \ privileged access mode for DAC1
$00001000 constant GTZC2_TZSC_TZSC_PRIVCFGR1_ADF1PRIV               \ privileged access mode for ADF1


\
\ @brief GTZC2_TZSC
\
$46023000 constant GTZC2_TZSC_TZSC_CR  \ offset: 0x00 : TZSC control register
$46023010 constant GTZC2_TZSC_TZSC_SECCFGR1  \ offset: 0x10 : TZSC secure configuration register 1
$46023020 constant GTZC2_TZSC_TZSC_PRIVCFGR1  \ offset: 0x20 : TZSC privilege configuration register 1

