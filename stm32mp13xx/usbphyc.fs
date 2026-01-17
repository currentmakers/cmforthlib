\
\ @file usbphyc.fs
\ @brief USBPHYC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USBPHYC_DEF

  [ifdef] USBPHYC_USBPHYC_PLL_DEF
    \
    \ @brief USBPHYC PLL control register
    \ Address offset: 0x00
    \ Reset value: 0xC0000000
    \
    $00 constant USBPHYC_PLLNDIV                \ [0x00 : 7] Loop division factor of PLL (integer part)
    $07 constant USBPHYC_PLLODF                 \ [0x07 : 3] PLL output division factor
    $0a constant USBPHYC_PLLFRACIN              \ [0x0a : 16] PLL fractional input PLLFRACIN is the fractional input of the PLL divider.
    $1a constant USBPHYC_PLLEN                  \ [0x1a] PLL enable This bit enables the PLL.
    $1b constant USBPHYC_PLLSTRB                \ [0x1b] PLL strobe This bit allows to control an asynchronous strobe signal provided as an input to the fractional controller. A rising edge of PLLSTRB signal indicates to the fractional controller that a new fractional word is to be loaded.
    $1c constant USBPHYC_PLLSTRBYP              \ [0x1c] PLL strobe bypass Bypass the strobe signal. If set to 1 before setting PLLEN=1, then the PLL will start up in fractional mode depending on the setting of PLLFRACCTL.
    $1d constant USBPHYC_PLLFRACCTL             \ [0x1d] PLL fractional mode control
    $1e constant USBPHYC_PLLDITHEN0             \ [0x1e] PLL dither 2 (triangular) This bit enables the triangular dither for the PLL.
    $1f constant USBPHYC_PLLDITHEN1             \ [0x1f] PLL dither 1 (rectangular) This bit enables the rectangular dither for the PLL.
  [then]


  [ifdef] USBPHYC_USBPHYC_MISC_DEF
    \
    \ @brief USBPHYC misc control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USBPHYC_SWITHOST               \ [0x00] Switch host Controls main switch connecting USB PHY 2nd port between USB host controller and USB OTG controller. This register is static.
    $01 constant USBPHYC_PPCKDIS                \ [0x01 : 2] Intelligent per HS PHY port clock gating control This register is static.
  [then]


  [ifdef] USBPHYC_USBPHYC_TUNE1_DEF
    \
    \ @brief USBPHYC PHY 1 TUNE register
    \ Address offset: 0x10C
    \ Reset value: 0x04070004
    \
    $00 constant USBPHYC_INCURREN               \ [0x00] The bit enables the current boosting function.
    $01 constant USBPHYC_INCURRINT              \ [0x01] Current boosting value This bit controls the PHY current boosting value.
    $02 constant USBPHYC_LFSCAPEN               \ [0x02] Low full speed enable This bit enables the low full speed feedback capacitor.
    $03 constant USBPHYC_HSDRVSLEW              \ [0x03] HS driver slew rate This bit controls the HS driver slew rate.
    $04 constant USBPHYC_HSDRVDCCUR             \ [0x04] HS driver DC level This bit allows to decrease the HS driver DC level.
    $05 constant USBPHYC_HSDRVDCLEV             \ [0x05] HS driver DC level This bit allows to increase the HS driver DC level. I is not applicable during the HS test J and test K data transfer.
    $06 constant USBPHYC_HSDRVCURINCR           \ [0x06] Enable the HS driver current increase feature
    $07 constant USBPHYC_FSDRVRFADJ             \ [0x07] Tuning pin to adjust the full speed rise/fall time
    $08 constant USBPHYC_HSDRVRFRED             \ [0x08] High-speed rise-fall reduction enable
    $09 constant USBPHYC_HSDRVCHKITRM           \ [0x09 : 4] HS driver choke current trim This bitfield controls the HS driver current trimming pins for choke compensation.
    $0d constant USBPHYC_HSDRVCHKZTRM           \ [0x0d : 2] HS driver choke impedance trim This bitfield controls the PHY bus HS driver impedance tuning for choke compensation.
    $0f constant USBPHYC_OTPCOMP                \ [0x0f : 5] OTP compensation code
    $14 constant USBPHYC_SQLCHCTL               \ [0x14 : 2] Squelch control This bitfield adjusts the squelch DC threshold value.
    $16 constant USBPHYC_HDRXGNEQEN             \ [0x16] Enable HS Rx gain equalizer
    $17 constant USBPHYC_HSRXOFF                \ [0x17 : 2] HS receiver offset adjustment
    $19 constant USBPHYC_HSFALLPREEM            \ [0x19] HS fall time pre-emphasis This bit enables the HS fall time control of single ended signals during pre-emphasis:
    $1a constant USBPHYC_SHTCCTCTLPROT          \ [0x1a] Short circuit control protection This bit enables the short circuit protection circuitry in LS/FS driver.
    $1b constant USBPHYC_STAGSEL                \ [0x1b] Staggering selection This bit enables the HS Tx staggering.
  [then]


  [ifdef] USBPHYC_USBPHYC_TUNE2_DEF
    \
    \ @brief USBPHYC PHY 2 TUNE register
    \ Address offset: 0x20C
    \ Reset value: 0x04070004
    \
    $00 constant USBPHYC_INCURREN               \ [0x00] The bit enables the current boosting function.
    $01 constant USBPHYC_INCURRINT              \ [0x01] Current boosting value This bit controls the PHY current boosting value.
    $02 constant USBPHYC_LFSCAPEN               \ [0x02] Low full speed enable This bit enables the low full speed feedback capacitor.
    $03 constant USBPHYC_HSDRVSLEW              \ [0x03] HS driver slew rate This bit controls the HS driver slew rate.
    $04 constant USBPHYC_HSDRVDCCUR             \ [0x04] HS driver DC level This bit allows to decrease the HS driver DC level.
    $05 constant USBPHYC_HSDRVDCLEV             \ [0x05] HS driver DC level This bit allows to increase the HS driver DC level. I is not applicable during the HS test J and test K data transfer.
    $06 constant USBPHYC_HSDRVCURINCR           \ [0x06] Enable the HS driver current increase feature
    $07 constant USBPHYC_FSDRVRFADJ             \ [0x07] Tuning pin to adjust the full speed rise/fall time
    $08 constant USBPHYC_HSDRVRFRED             \ [0x08] High-speed rise-fall reduction enable
    $09 constant USBPHYC_HSDRVCHKITRM           \ [0x09 : 4] HS driver choke current trim This bitfield controls the HS driver current trimming pins for choke compensation.
    $0d constant USBPHYC_HSDRVCHKZTRM           \ [0x0d : 2] HS driver choke impedance trim This bitfield controls the PHY bus HS driver impedance tuning for choke compensation.
    $0f constant USBPHYC_OTPCOMP                \ [0x0f : 5] OTP compensation code
    $14 constant USBPHYC_SQLCHCTL               \ [0x14 : 2] Squelch control This bitfield adjusts the squelch DC threshold value.
    $16 constant USBPHYC_HDRXGNEQEN             \ [0x16] Enable HS Rx gain equalizer
    $17 constant USBPHYC_HSRXOFF                \ [0x17 : 2] HS receiver offset adjustment
    $19 constant USBPHYC_HSFALLPREEM            \ [0x19] HS fall time pre-emphasis This bit enables the HS fall time control of single ended signals during pre-emphasis:
    $1a constant USBPHYC_SHTCCTCTLPROT          \ [0x1a] Short circuit control protection This bit enables the short circuit protection circuitry in LS/FS driver.
    $1b constant USBPHYC_STAGSEL                \ [0x1b] Staggering selection This bit enables the HS Tx staggering.
  [then]


  [ifdef] USBPHYC_USBPHYC_VERR_DEF
    \
    \ @brief USBPHYC VERSION register
    \ Address offset: 0xFFC
    \ Reset value: 0x00000010
    \
    $00 constant USBPHYC_MINREV                 \ [0x00 : 4] Minor revision
    $04 constant USBPHYC_MAJREV                 \ [0x04 : 4] Major revision
  [then]

  \
  \ @brief USBPHYC
  \
  $00 constant USBPHYC_USBPHYC_PLL      \ USBPHYC PLL control register
  $08 constant USBPHYC_USBPHYC_MISC     \ USBPHYC misc control register
  $10C constant USBPHYC_USBPHYC_TUNE1   \ USBPHYC PHY 1 TUNE register
  $20C constant USBPHYC_USBPHYC_TUNE2   \ USBPHYC PHY 2 TUNE register
  $FFC constant USBPHYC_USBPHYC_VERR    \ USBPHYC VERSION register

: USBPHYC_DEF ; [then]
