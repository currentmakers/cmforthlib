\
\ @file ramcfg.fs
\ @brief RAMs configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RAMCFG_DEF

  [ifdef] RAMCFG_RAMECC_IER_DEF
    \
    \ @brief RAMECC interrupt enable register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_GIE                     \ [0x00] Global interrupt enable When GIE bit is set to 1, an interrupt is generated when an enabled global ECC error (GECCDEBWIE, GECCDEIE or GECCSEIE) occurs.
    $01 constant RAMCFG_GECCSEIE                \ [0x01] Global ECC single error interrupt enable When GECCSEIE bit is set to 1, an interrupt is generated when an ECC single error occurs during a read operation from RAM.
    $02 constant RAMCFG_GECCDEIE                \ [0x02] Global ECC double error interrupt enable When GECCDEIE bit is set to 1, an interrupt is generated when an ECC double detection error occurs during a read operation from RAM.
    $03 constant RAMCFG_GECCDEBWIE              \ [0x03] Global ECC double error on byte write (BW) interrupt enable When GECCDEBWIE bit is set to 1, an interrupt is generated when an ECC double detection error occurs during a byte write operation to RAM (incomplete word write).
  [then]


  [ifdef] RAMCFG_RAMECC_M1CR_DEF
    \
    \ @brief RAMECC monitor 1 configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $02 constant RAMCFG_ECCSEIE                 \ [0x02] ECC single error interrupt enable When ECCSEIE bit is set to 1, monitor x generates an interrupt when an ECC single error occurs during a read operation from RAM.
    $03 constant RAMCFG_ECCDEIE                 \ [0x03] ECC double error interrupt enable When ECCDEIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a read operation from RAM.
    $04 constant RAMCFG_ECCDEBWIE               \ [0x04] ECC double error on byte write (BW) interrupt enable When ECCDEBWIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a byte write operation to RAM.
    $05 constant RAMCFG_ECCELEN                 \ [0x05] ECC error latching enable When ECCELEN bit is set to 1, if an ECC error occurs (both for single error correction or double detection) during a read operation, the context (address, data and ECC code) that generated the error are latched to their respective registers.
    $06 constant RAMCFG_ECCSECEN                \ [0x06] ECC single error counter enable When ECCSECEN bit is set to 1, the occurrence counter is incremented when an ECC single error occurs during a read operation from RAM.
    $07 constant RAMCFG_ECCDECEN                \ [0x07] ECC double error counter enable When ECCDECEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a read operation from RAM.
    $08 constant RAMCFG_ECCDEBWCEN              \ [0x08] ECC double error on byte write (BW) counter enable When ECCDEBWCEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a byte write operation to RAM.
    $10 constant RAMCFG_ECCTEA                  \ [0x10 : 2] ECC Test ECC access
  [then]


  [ifdef] RAMCFG_RAMECC_M1SR_DEF
    \
    \ @brief RAMECC monitor 1 status register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDCF                   \ [0x00] ECC single error detected and corrected flag This bit is set by hardware. It is cleared by software by writing a 0
    $01 constant RAMCFG_DEDF                    \ [0x01] ECC double error detected flag This bit is set by hardware. It is cleared by software by writing a 0
    $02 constant RAMCFG_DEBWDF                  \ [0x02] ECC double error on byte write (BW) detected flag This bit is set by hardware. It is cleared by software by writing a 0
  [then]


  [ifdef] RAMCFG_RAMECC_M1FAR_DEF
    \
    \ @brief RAMECC monitor 1 failing address register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FADD                    \ [0x00 : 32] ECC error failing address When an ECC error occurs the FADD bitfield contains the address that generated the ECC error.
  [then]


  [ifdef] RAMCFG_RAMECC_M1FDRL_DEF
    \
    \ @brief RAMECC monitor 1 failing data low register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FDATAL                  \ [0x00 : 32] Failing data low When an ECC error occurs the FDATAL bitfield contains the LSB part of the data that generated the error. For 32-bit word SRAM, this bitfield contains the full memory word that generated the error.
  [then]


  [ifdef] RAMCFG_RAMECC_M1FDRH_DEF
    \
    \ @brief RAMECC monitor 1 failing data high register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FDATAH                  \ [0x00 : 32] Failing data high (64-bit memory) When an ECC error occurs the FDATAH bitfield contains the MSB part of the data that generated the error.
  [then]


  [ifdef] RAMCFG_RAMECC_M1FECR_DEF
    \
    \ @brief RAMECC monitor 1 failing ECC error code register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FEC                     \ [0x00 : 32] Failing error code When an ECC error occurs the FEC bitfield contains the ECC failing code that generated the error.
  [then]


  [ifdef] RAMCFG_RAMECC_M2CR_DEF
    \
    \ @brief RAMECC monitor 2 configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $02 constant RAMCFG_ECCSEIE                 \ [0x02] ECC single error interrupt enable When ECCSEIE bit is set to 1, monitor x generates an interrupt when an ECC single error occurs during a read operation from RAM.
    $03 constant RAMCFG_ECCDEIE                 \ [0x03] ECC double error interrupt enable When ECCDEIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a read operation from RAM.
    $04 constant RAMCFG_ECCDEBWIE               \ [0x04] ECC double error on byte write (BW) interrupt enable When ECCDEBWIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a byte write operation to RAM.
    $05 constant RAMCFG_ECCELEN                 \ [0x05] ECC error latching enable When ECCELEN bit is set to 1, if an ECC error occurs (both for single error correction or double detection) during a read operation, the context (address, data and ECC code) that generated the error are latched to their respective registers.
    $06 constant RAMCFG_ECCSECEN                \ [0x06] ECC single error counter enable When ECCSECEN bit is set to 1, the occurrence counter is incremented when an ECC single error occurs during a read operation from RAM.
    $07 constant RAMCFG_ECCDECEN                \ [0x07] ECC double error counter enable When ECCDECEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a read operation from RAM.
    $08 constant RAMCFG_ECCDEBWCEN              \ [0x08] ECC double error on byte write (BW) counter enable When ECCDEBWCEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a byte write operation to RAM.
    $10 constant RAMCFG_ECCTEA                  \ [0x10 : 2] ECC Test ECC access
  [then]


  [ifdef] RAMCFG_RAMECC_M2SR_DEF
    \
    \ @brief RAMECC monitor 2 status register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDCF                   \ [0x00] ECC single error detected and corrected flag This bit is set by hardware. It is cleared by software by writing a 0
    $01 constant RAMCFG_DEDF                    \ [0x01] ECC double error detected flag This bit is set by hardware. It is cleared by software by writing a 0
    $02 constant RAMCFG_DEBWDF                  \ [0x02] ECC double error on byte write (BW) detected flag This bit is set by hardware. It is cleared by software by writing a 0
  [then]


  [ifdef] RAMCFG_RAMECC_M2FAR_DEF
    \
    \ @brief RAMECC monitor 2 failing address register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FADD                    \ [0x00 : 32] ECC error failing address When an ECC error occurs the FADD bitfield contains the address that generated the ECC error.
  [then]


  [ifdef] RAMCFG_RAMECC_M2FDRL_DEF
    \
    \ @brief RAMECC monitor 2 failing data low register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FDATAL                  \ [0x00 : 32] Failing data low When an ECC error occurs the FDATAL bitfield contains the LSB part of the data that generated the error. For 32-bit word SRAM, this bitfield contains the full memory word that generated the error.
  [then]


  [ifdef] RAMCFG_RAMECC_M2FDRH_DEF
    \
    \ @brief RAMECC monitor 2 failing data high register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FDATAH                  \ [0x00 : 32] Failing data high (64-bit memory) When an ECC error occurs the FDATAH bitfield contains the MSB part of the data that generated the error.
  [then]


  [ifdef] RAMCFG_RAMECC_M2FECR_DEF
    \
    \ @brief RAMECC monitor 2 failing ECC error code register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FEC                     \ [0x00 : 32] Failing error code When an ECC error occurs the FEC bitfield contains the ECC failing code that generated the error.
  [then]


  [ifdef] RAMCFG_RAMECC_M3CR_DEF
    \
    \ @brief RAMECC monitor 3 configuration register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $02 constant RAMCFG_ECCSEIE                 \ [0x02] ECC single error interrupt enable When ECCSEIE bit is set to 1, monitor x generates an interrupt when an ECC single error occurs during a read operation from RAM.
    $03 constant RAMCFG_ECCDEIE                 \ [0x03] ECC double error interrupt enable When ECCDEIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a read operation from RAM.
    $04 constant RAMCFG_ECCDEBWIE               \ [0x04] ECC double error on byte write (BW) interrupt enable When ECCDEBWIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a byte write operation to RAM.
    $05 constant RAMCFG_ECCELEN                 \ [0x05] ECC error latching enable When ECCELEN bit is set to 1, if an ECC error occurs (both for single error correction or double detection) during a read operation, the context (address, data and ECC code) that generated the error are latched to their respective registers.
    $06 constant RAMCFG_ECCSECEN                \ [0x06] ECC single error counter enable When ECCSECEN bit is set to 1, the occurrence counter is incremented when an ECC single error occurs during a read operation from RAM.
    $07 constant RAMCFG_ECCDECEN                \ [0x07] ECC double error counter enable When ECCDECEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a read operation from RAM.
    $08 constant RAMCFG_ECCDEBWCEN              \ [0x08] ECC double error on byte write (BW) counter enable When ECCDEBWCEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a byte write operation to RAM.
    $10 constant RAMCFG_ECCTEA                  \ [0x10 : 2] ECC Test ECC access
  [then]


  [ifdef] RAMCFG_RAMECC_M3SR_DEF
    \
    \ @brief RAMECC monitor 3 status register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDCF                   \ [0x00] ECC single error detected and corrected flag This bit is set by hardware. It is cleared by software by writing a 0
    $01 constant RAMCFG_DEDF                    \ [0x01] ECC double error detected flag This bit is set by hardware. It is cleared by software by writing a 0
    $02 constant RAMCFG_DEBWDF                  \ [0x02] ECC double error on byte write (BW) detected flag This bit is set by hardware. It is cleared by software by writing a 0
  [then]


  [ifdef] RAMCFG_RAMECC_M3FAR_DEF
    \
    \ @brief RAMECC monitor 3 failing address register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FADD                    \ [0x00 : 32] ECC error failing address When an ECC error occurs the FADD bitfield contains the address that generated the ECC error.
  [then]


  [ifdef] RAMCFG_RAMECC_M3FDRL_DEF
    \
    \ @brief RAMECC monitor 3 failing data low register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FDATAL                  \ [0x00 : 32] Failing data low When an ECC error occurs the FDATAL bitfield contains the LSB part of the data that generated the error. For 32-bit word SRAM, this bitfield contains the full memory word that generated the error.
  [then]


  [ifdef] RAMCFG_RAMECC_M3FDRH_DEF
    \
    \ @brief RAMECC monitor 3 failing data high register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FDATAH                  \ [0x00 : 32] Failing data high (64-bit memory) When an ECC error occurs the FDATAH bitfield contains the MSB part of the data that generated the error.
  [then]


  [ifdef] RAMCFG_RAMECC_M3FECR_DEF
    \
    \ @brief RAMECC monitor 3 failing ECC error code register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FEC                     \ [0x00 : 32] Failing error code When an ECC error occurs the FEC bitfield contains the ECC failing code that generated the error.
  [then]


  [ifdef] RAMCFG_RAMECC_M4CR_DEF
    \
    \ @brief RAMECC monitor 4 configuration register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $02 constant RAMCFG_ECCSEIE                 \ [0x02] ECC single error interrupt enable When ECCSEIE bit is set to 1, monitor x generates an interrupt when an ECC single error occurs during a read operation from RAM.
    $03 constant RAMCFG_ECCDEIE                 \ [0x03] ECC double error interrupt enable When ECCDEIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a read operation from RAM.
    $04 constant RAMCFG_ECCDEBWIE               \ [0x04] ECC double error on byte write (BW) interrupt enable When ECCDEBWIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a byte write operation to RAM.
    $05 constant RAMCFG_ECCELEN                 \ [0x05] ECC error latching enable When ECCELEN bit is set to 1, if an ECC error occurs (both for single error correction or double detection) during a read operation, the context (address, data and ECC code) that generated the error are latched to their respective registers.
    $06 constant RAMCFG_ECCSECEN                \ [0x06] ECC single error counter enable When ECCSECEN bit is set to 1, the occurrence counter is incremented when an ECC single error occurs during a read operation from RAM.
    $07 constant RAMCFG_ECCDECEN                \ [0x07] ECC double error counter enable When ECCDECEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a read operation from RAM.
    $08 constant RAMCFG_ECCDEBWCEN              \ [0x08] ECC double error on byte write (BW) counter enable When ECCDEBWCEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a byte write operation to RAM.
    $10 constant RAMCFG_ECCTEA                  \ [0x10 : 2] ECC Test ECC access
  [then]


  [ifdef] RAMCFG_RAMECC_M4SR_DEF
    \
    \ @brief RAMECC monitor 4 status register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDCF                   \ [0x00] ECC single error detected and corrected flag This bit is set by hardware. It is cleared by software by writing a 0
    $01 constant RAMCFG_DEDF                    \ [0x01] ECC double error detected flag This bit is set by hardware. It is cleared by software by writing a 0
    $02 constant RAMCFG_DEBWDF                  \ [0x02] ECC double error on byte write (BW) detected flag This bit is set by hardware. It is cleared by software by writing a 0
  [then]


  [ifdef] RAMCFG_RAMECC_M4FAR_DEF
    \
    \ @brief RAMECC monitor 4 failing address register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FADD                    \ [0x00 : 32] ECC error failing address When an ECC error occurs the FADD bitfield contains the address that generated the ECC error.
  [then]


  [ifdef] RAMCFG_RAMECC_M4FDRL_DEF
    \
    \ @brief RAMECC monitor 4 failing data low register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FDATAL                  \ [0x00 : 32] Failing data low When an ECC error occurs the FDATAL bitfield contains the LSB part of the data that generated the error. For 32-bit word SRAM, this bitfield contains the full memory word that generated the error.
  [then]


  [ifdef] RAMCFG_RAMECC_M4FDRH_DEF
    \
    \ @brief RAMECC monitor 4 failing data high register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FDATAH                  \ [0x00 : 32] Failing data high (64-bit memory) When an ECC error occurs the FDATAH bitfield contains the MSB part of the data that generated the error.
  [then]


  [ifdef] RAMCFG_RAMECC_M4FECR_DEF
    \
    \ @brief RAMECC monitor 4 failing ECC error code register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FEC                     \ [0x00 : 32] Failing error code When an ECC error occurs the FEC bitfield contains the ECC failing code that generated the error.
  [then]


  [ifdef] RAMCFG_RAMECC_M5CR_DEF
    \
    \ @brief RAMECC monitor 5 configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $02 constant RAMCFG_ECCSEIE                 \ [0x02] ECC single error interrupt enable When ECCSEIE bit is set to 1, monitor x generates an interrupt when an ECC single error occurs during a read operation from RAM.
    $03 constant RAMCFG_ECCDEIE                 \ [0x03] ECC double error interrupt enable When ECCDEIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a read operation from RAM.
    $04 constant RAMCFG_ECCDEBWIE               \ [0x04] ECC double error on byte write (BW) interrupt enable When ECCDEBWIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a byte write operation to RAM.
    $05 constant RAMCFG_ECCELEN                 \ [0x05] ECC error latching enable When ECCELEN bit is set to 1, if an ECC error occurs (both for single error correction or double detection) during a read operation, the context (address, data and ECC code) that generated the error are latched to their respective registers.
    $06 constant RAMCFG_ECCSECEN                \ [0x06] ECC single error counter enable When ECCSECEN bit is set to 1, the occurrence counter is incremented when an ECC single error occurs during a read operation from RAM.
    $07 constant RAMCFG_ECCDECEN                \ [0x07] ECC double error counter enable When ECCDECEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a read operation from RAM.
    $08 constant RAMCFG_ECCDEBWCEN              \ [0x08] ECC double error on byte write (BW) counter enable When ECCDEBWCEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a byte write operation to RAM.
    $10 constant RAMCFG_ECCTEA                  \ [0x10 : 2] ECC Test ECC access
  [then]


  [ifdef] RAMCFG_RAMECC_M5SR_DEF
    \
    \ @brief RAMECC monitor 5 status register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDCF                   \ [0x00] ECC single error detected and corrected flag This bit is set by hardware. It is cleared by software by writing a 0
    $01 constant RAMCFG_DEDF                    \ [0x01] ECC double error detected flag This bit is set by hardware. It is cleared by software by writing a 0
    $02 constant RAMCFG_DEBWDF                  \ [0x02] ECC double error on byte write (BW) detected flag This bit is set by hardware. It is cleared by software by writing a 0
  [then]


  [ifdef] RAMCFG_RAMECC_M5FAR_DEF
    \
    \ @brief RAMECC monitor 5 failing address register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FADD                    \ [0x00 : 32] ECC error failing address When an ECC error occurs the FADD bitfield contains the address that generated the ECC error.
  [then]


  [ifdef] RAMCFG_RAMECC_M5FDRL_DEF
    \
    \ @brief RAMECC monitor 5 failing data low register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FDATAL                  \ [0x00 : 32] Failing data low When an ECC error occurs the FDATAL bitfield contains the LSB part of the data that generated the error. For 32-bit word SRAM, this bitfield contains the full memory word that generated the error.
  [then]


  [ifdef] RAMCFG_RAMECC_M5FDRH_DEF
    \
    \ @brief RAMECC monitor 5 failing data high register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FDATAH                  \ [0x00 : 32] Failing data high (64-bit memory) When an ECC error occurs the FDATAH bitfield contains the MSB part of the data that generated the error.
  [then]


  [ifdef] RAMCFG_RAMECC_M5FECR_DEF
    \
    \ @brief RAMECC monitor 5 failing ECC error code register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_FEC                     \ [0x00 : 32] Failing error code When an ECC error occurs the FEC bitfield contains the ECC failing code that generated the error.
  [then]

  \
  \ @brief RAMs configuration controller
  \
  $00 constant RAMCFG_RAMECC_IER        \ RAMECC interrupt enable register
  $20 constant RAMCFG_RAMECC_M1CR       \ RAMECC monitor 1 configuration register
  $24 constant RAMCFG_RAMECC_M1SR       \ RAMECC monitor 1 status register
  $28 constant RAMCFG_RAMECC_M1FAR      \ RAMECC monitor 1 failing address register
  $2C constant RAMCFG_RAMECC_M1FDRL     \ RAMECC monitor 1 failing data low register
  $30 constant RAMCFG_RAMECC_M1FDRH     \ RAMECC monitor 1 failing data high register
  $34 constant RAMCFG_RAMECC_M1FECR     \ RAMECC monitor 1 failing ECC error code register
  $40 constant RAMCFG_RAMECC_M2CR       \ RAMECC monitor 2 configuration register
  $44 constant RAMCFG_RAMECC_M2SR       \ RAMECC monitor 2 status register
  $48 constant RAMCFG_RAMECC_M2FAR      \ RAMECC monitor 2 failing address register
  $4C constant RAMCFG_RAMECC_M2FDRL     \ RAMECC monitor 2 failing data low register
  $50 constant RAMCFG_RAMECC_M2FDRH     \ RAMECC monitor 2 failing data high register
  $54 constant RAMCFG_RAMECC_M2FECR     \ RAMECC monitor 2 failing ECC error code register
  $60 constant RAMCFG_RAMECC_M3CR       \ RAMECC monitor 3 configuration register
  $64 constant RAMCFG_RAMECC_M3SR       \ RAMECC monitor 3 status register
  $68 constant RAMCFG_RAMECC_M3FAR      \ RAMECC monitor 3 failing address register
  $6C constant RAMCFG_RAMECC_M3FDRL     \ RAMECC monitor 3 failing data low register
  $70 constant RAMCFG_RAMECC_M3FDRH     \ RAMECC monitor 3 failing data high register
  $74 constant RAMCFG_RAMECC_M3FECR     \ RAMECC monitor 3 failing ECC error code register
  $80 constant RAMCFG_RAMECC_M4CR       \ RAMECC monitor 4 configuration register
  $84 constant RAMCFG_RAMECC_M4SR       \ RAMECC monitor 4 status register
  $88 constant RAMCFG_RAMECC_M4FAR      \ RAMECC monitor 4 failing address register
  $8C constant RAMCFG_RAMECC_M4FDRL     \ RAMECC monitor 4 failing data low register
  $90 constant RAMCFG_RAMECC_M4FDRH     \ RAMECC monitor 4 failing data high register
  $94 constant RAMCFG_RAMECC_M4FECR     \ RAMECC monitor 4 failing ECC error code register
  $A0 constant RAMCFG_RAMECC_M5CR       \ RAMECC monitor 5 configuration register
  $A4 constant RAMCFG_RAMECC_M5SR       \ RAMECC monitor 5 status register
  $A8 constant RAMCFG_RAMECC_M5FAR      \ RAMECC monitor 5 failing address register
  $AC constant RAMCFG_RAMECC_M5FDRL     \ RAMECC monitor 5 failing data low register
  $B0 constant RAMCFG_RAMECC_M5FDRH     \ RAMECC monitor 5 failing data high register
  $B4 constant RAMCFG_RAMECC_M5FECR     \ RAMECC monitor 5 failing ECC error code register

: RAMCFG_DEF ; [then]
