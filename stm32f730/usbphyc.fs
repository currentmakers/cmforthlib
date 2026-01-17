\
\ @file usbphyc.fs
\ @brief USBPHYC register interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USBPHYC_DEF

  [ifdef] USBPHYC_PLL1_DEF
    \
    \ @brief USBPHYC PLL1 control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USBPHYC_PLL1EN                 \ [0x00] Enable the PLL1 inside PHY
    $01 constant USBPHYC_PLL1SEL                \ [0x01 : 3] : Controls the PHY PLL1 input clock frequency selection
  [then]


  [ifdef] USBPHYC_TUNE_DEF
    \
    \ @brief USBPHYC tuning control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000004
    \
    $00 constant USBPHYC_INCURREN               \ [0x00] Controls the current boosting function
    $01 constant USBPHYC_INCURRINT              \ [0x01] Controls PHY current boosting
    $02 constant USBPHYC_LFSCAPEN               \ [0x02] : Enables the Low Full Speed feedback capacitor
    $03 constant USBPHYC_HSDRVSLEW              \ [0x03] Controls the HS driver slew rate
    $04 constant USBPHYC_HSDRVDCCUR             \ [0x04] Decreases the HS driver DC level
    $05 constant USBPHYC_HSDRVDCLEV             \ [0x05] Increases the HS Driver DC level. Not applicable during the HS Test J and Test K data transfer
    $06 constant USBPHYC_HSDRVCURINCR           \ [0x06] Enable the HS driver current increase feature
    $07 constant USBPHYC_FSDRVRFADJ             \ [0x07] Tuning pin to adjust the full speed rise/fall time
    $08 constant USBPHYC_HSDRVRFRED             \ [0x08] High Speed rise-fall reduction enable
    $09 constant USBPHYC_HSDRVCHKITRM           \ [0x09 : 4] HS Driver current trimming pins for choke compensation
    $0d constant USBPHYC_HSDRVCHKZTRM           \ [0x0d : 2] Controls the PHY bus HS driver impedance tuning for choke compensation
    $0f constant USBPHYC_SQLCHCTL               \ [0x0f : 2] Adjust the squelch DC threshold value
    $11 constant USBPHYC_HDRXGNEQEN             \ [0x11] Enables the HS Rx Gain Equalizer
    $12 constant USBPHYC_STAGSEL                \ [0x12] HS Tx staggering enable
    $13 constant USBPHYC_HSFALLPREEM            \ [0x13] HS Fall time control of single ended signals during pre-emphasis
    $14 constant USBPHYC_HSRXOFF                \ [0x14 : 2] : HS Receiver Offset adjustment
    $16 constant USBPHYC_SHTCCTCTLPROT          \ [0x16] Enables the short circuit protection circuitry in LS/FS driver
    $17 constant USBPHYC_SQLBYP                 \ [0x17] This pin is used to bypass the squelch inter-locking circuitry
  [then]


  [ifdef] USBPHYC_LDO_DEF
    \
    \ @brief USBPHYC LDO control and status register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant USBPHYC_LDO_USED               \ [0x00] Indicates the presence of the LDO in the chip
    $01 constant USBPHYC_LDO_STATUS             \ [0x01] Monitors the status of the PHY's LDO
    $02 constant USBPHYC_LDO_DISABLE            \ [0x02] Controls disable of the High Speed PHY's LDO
  [then]

  \
  \ @brief USBPHYC register interface
  \
  $00 constant USBPHYC_PLL1             \ USBPHYC PLL1 control register
  $0C constant USBPHYC_TUNE             \ USBPHYC tuning control register
  $18 constant USBPHYC_LDO              \ USBPHYC LDO control and status register

: USBPHYC_DEF ; [then]
