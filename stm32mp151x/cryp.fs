\
\ @file cryp.fs
\ @brief CRYP1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CRYP_DEF

  [ifdef] CRYP_CRYP_CR_DEF
    \
    \ @brief CRYP control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $02 constant CRYP_ALGODIR                   \ [0x02] ALGODIR
    $03 constant CRYP_ALGOMODE                  \ [0x03 : 3] ALGOMODE
    $06 constant CRYP_DATATYPE                  \ [0x06 : 2] DATATYPE
    $08 constant CRYP_KEYSIZE                   \ [0x08 : 2] KEYSIZE
    $0e constant CRYP_FFLUSH                    \ [0x0e] FFLUSH
    $0f constant CRYP_CRYPEN                    \ [0x0f] CRYPEN
    $10 constant CRYP_GCM_CCMPH                 \ [0x10 : 2] GCM_CCMPH
    $13 constant CRYP_ALGOMODE3                 \ [0x13] ALGOMODE3
    $14 constant CRYP_NPBLB                     \ [0x14 : 4] NPBLB
  [then]


  [ifdef] CRYP_CRYP_SR_DEF
    \
    \ @brief CRYP status register
    \ Address offset: 0x04
    \ Reset value: 0x00000003
    \
    $00 constant CRYP_IFEM                      \ [0x00] IFEM
    $01 constant CRYP_IFNF                      \ [0x01] IFNF
    $02 constant CRYP_OFNE                      \ [0x02] OFNE
    $03 constant CRYP_OFFU                      \ [0x03] OFFU
    $04 constant CRYP_BUSY                      \ [0x04] BUSY
  [then]


  [ifdef] CRYP_CRYP_DIN_DEF
    \
    \ @brief The CRYP_DIN register is the data input register. It is 32-bit wide. It is used to enter into the input FIFO up to four 64-bit blocks (TDES) or two 128-bit blocks (AES) of plaintext (when encrypting) or ciphertext (when decrypting), one 32-bit word at a time. To fit different data sizes, the data can be swapped after processing by configuring the DATATYPE bits in the CRYP_CR register. Refer to Section39.3.16: CRYP data registers and data swapping for more details. When CRYP_DIN register is written to the data are pushed into the input FIFO. If CRYPEN = 1, when at least two 32-bit words in the DES/TDES mode have been pushed into the input FIFO (four words in the AES mode), and when at least two words are free in the output FIFO (four words in the AES mode), the CRYP engine starts an encrypting or decrypting process. When CRYP_DIN register is read: If CRYPEN = 0, the FIFO is popped, and then the data present in the Input FIFO are returned, from the oldest one (first reading) to the newest one (last reading). The IFEM flag must be checked before each read operation to make sure that the FIFO is not empty. if CRYPEN = 1, an undefined value is returned. After the CRYP_DIN register has been read once or several times, the FIFO must be flushed by setting the FFLUSH bit prior to processing new data.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DATAIN                    \ [0x00 : 32] DATAIN
  [then]


  [ifdef] CRYP_CRYP_DOUT_DEF
    \
    \ @brief The CRYP_DOUT register is the data output register. It is read-only and 32-bit wide. It is used to retrieve from the output FIFO up to four 64-bit blocks (TDES) or two 128-bit blocks (AES) of plaintext (when encrypting) or ciphertext (when decrypting), one 32-bit word at a time. To fit different data sizes, the data can be swapped after processing by configuring the DATATYPE bits in the CRYP_CR register. Refer to Section39.3.16: CRYP data registers and data swapping for more details. When CRYP_DOUT register is read, the last data entered into the output FIFO (pointed to by the read pointer) is returned.
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DATAOUT                   \ [0x00 : 32] DATAOUT
  [then]


  [ifdef] CRYP_CRYP_DMACR_DEF
    \
    \ @brief CRYP DMA control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DIEN                      \ [0x00] DIEN
    $01 constant CRYP_DOEN                      \ [0x01] DOEN
  [then]


  [ifdef] CRYP_CRYP_IMSCR_DEF
    \
    \ @brief The CRYP_IMSCR register is the interrupt mask set or clear register. It is a read/write register. When a read operation is performed, this register gives the current value of the mask applied to the relevant interrupt. Writing 1 to the particular bit sets the mask, thus enabling the interrupt to be read. Writing 0 to this bit clears the corresponding mask. All the bits are cleared to 0 when the peripheral is reset.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_INIM                      \ [0x00] INIM
    $01 constant CRYP_OUTIM                     \ [0x01] OUTIM
  [then]


  [ifdef] CRYP_CRYP_RISR_DEF
    \
    \ @brief The CRYP_RISR register is the raw interrupt status register. It is a read-only register. When a read operation is performed, this register gives the current raw status of the corresponding interrupt, i.e. the interrupt information without taking CRYP_IMSCR mask into account. Write operations have no effect.
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant CRYP_INRIS                     \ [0x00] INRIS
    $01 constant CRYP_OUTRIS                    \ [0x01] OUTRIS
  [then]


  [ifdef] CRYP_CRYP_MISR_DEF
    \
    \ @brief The CRYP_MISR register is the masked interrupt status register. It is a read-only register. When a read operation is performed, this register gives the current masked status of the corresponding interrupt, i.e. the interrupt information taking CRYP_IMSCR mask into account. Write operations have no effect.
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_INMIS                     \ [0x00] INMIS
    $01 constant CRYP_OUTMIS                    \ [0x01] OUTMIS
  [then]


  [ifdef] CRYP_CRYP_K0LR_DEF
    \
    \ @brief CRYP key registers contain the cryptographic keys. In DES/TDES mode, the keys are 64-bit binary values (number from left to right, that is the leftmost bit is bit 1) and named K1, K2 and K3 (K0 is not used). Each key consists of 56 information bits and 8 parity bits. In AES mode, the key is considered as a single 128, 192 or 256 bits long sequence K0K1K2...K127/191/255. The AES key is entered into the registers as follows: for AES-128: K0..K127 corresponds to b127..b0 (b255..b128 are not used), for AES-192: K0..K191 corresponds to b191..b0 (b255..b192 are not used), for AES-256: K0..K255 corresponds to b255..b0. In all cases key bit K0 is the leftmost bit in CRYP inner memory and register bit b0 is the rightmost bit in corresponding CRYP_KxLR key register. For more information refer to Section39.3.17: CRYP key registers. Write accesses to these registers are disregarded when the cryptographic processor is busy (bit BUSY = 1 in the CRYP_SR register)
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] K
  [then]


  [ifdef] CRYP_CRYP_K0RR_DEF
    \
    \ @brief Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] K
  [then]


  [ifdef] CRYP_CRYP_K1LR_DEF
    \
    \ @brief Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] K
  [then]


  [ifdef] CRYP_CRYP_K1RR_DEF
    \
    \ @brief Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] K
  [then]


  [ifdef] CRYP_CRYP_K2LR_DEF
    \
    \ @brief Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] K
  [then]


  [ifdef] CRYP_CRYP_K2RR_DEF
    \
    \ @brief Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] K
  [then]


  [ifdef] CRYP_CRYP_K3LR_DEF
    \
    \ @brief Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] K
  [then]


  [ifdef] CRYP_CRYP_K3RR_DEF
    \
    \ @brief Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] K
  [then]


  [ifdef] CRYP_CRYP_IV0LR_DEF
    \
    \ @brief The CRYP_IV0...1(L/R)R are the left-word and right-word registers for the initialization vector (64 bits for DES/TDES and 128 bits for AES). For more information refer to Section39.3.18: CRYP initialization vector registers. IV0 is the leftmost bit whereas IV63 (DES, TDES) or IV127 (AES) are the rightmost bits of the initialization vector. IV1(L/R)R is used only in the AES. Only CRYP_IV0(L/R) is used in DES/TDES. Write access to these registers are disregarded when the cryptographic processor is busy (bit BUSY = 1 in the CRYP_SR register).
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IV31                      \ [0x00] IV31
    $01 constant CRYP_IV30                      \ [0x01] IV30
    $02 constant CRYP_IV29                      \ [0x02] IV29
    $03 constant CRYP_IV28                      \ [0x03] IV28
    $04 constant CRYP_IV27                      \ [0x04] IV27
    $05 constant CRYP_IV26                      \ [0x05] IV26
    $06 constant CRYP_IV25                      \ [0x06] IV25
    $07 constant CRYP_IV24                      \ [0x07] IV24
    $08 constant CRYP_IV23                      \ [0x08] IV23
    $09 constant CRYP_IV22                      \ [0x09] IV22
    $0a constant CRYP_IV21                      \ [0x0a] IV21
    $0b constant CRYP_IV20                      \ [0x0b] IV20
    $0c constant CRYP_IV19                      \ [0x0c] IV19
    $0d constant CRYP_IV18                      \ [0x0d] IV18
    $0e constant CRYP_IV17                      \ [0x0e] IV17
    $0f constant CRYP_IV16                      \ [0x0f] IV16
    $10 constant CRYP_IV15                      \ [0x10] IV15
    $11 constant CRYP_IV14                      \ [0x11] IV14
    $12 constant CRYP_IV13                      \ [0x12] IV13
    $13 constant CRYP_IV12                      \ [0x13] IV12
    $14 constant CRYP_IV11                      \ [0x14] IV11
    $15 constant CRYP_IV10                      \ [0x15] IV10
    $16 constant CRYP_IV9                       \ [0x16] IV9
    $17 constant CRYP_IV8                       \ [0x17] IV8
    $18 constant CRYP_IV7                       \ [0x18] IV7
    $19 constant CRYP_IV6                       \ [0x19] IV6
    $1a constant CRYP_IV5                       \ [0x1a] IV5
    $1b constant CRYP_IV4                       \ [0x1b] IV4
    $1c constant CRYP_IV3                       \ [0x1c] IV3
    $1d constant CRYP_IV2                       \ [0x1d] IV2
    $1e constant CRYP_IV1                       \ [0x1e] IV1
    $1f constant CRYP_IV0                       \ [0x1f] IV0
  [then]


  [ifdef] CRYP_CRYP_IV0RR_DEF
    \
    \ @brief Refer to Section39.6.17: CRYP initialization vector register 0L (CRYP_IV0LR) for details.
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IV63                      \ [0x00] IV63
    $01 constant CRYP_IV62                      \ [0x01] IV62
    $02 constant CRYP_IV61                      \ [0x02] IV61
    $03 constant CRYP_IV60                      \ [0x03] IV60
    $04 constant CRYP_IV59                      \ [0x04] IV59
    $05 constant CRYP_IV58                      \ [0x05] IV58
    $06 constant CRYP_IV57                      \ [0x06] IV57
    $07 constant CRYP_IV56                      \ [0x07] IV56
    $08 constant CRYP_IV55                      \ [0x08] IV55
    $09 constant CRYP_IV54                      \ [0x09] IV54
    $0a constant CRYP_IV53                      \ [0x0a] IV53
    $0b constant CRYP_IV52                      \ [0x0b] IV52
    $0c constant CRYP_IV51                      \ [0x0c] IV51
    $0d constant CRYP_IV50                      \ [0x0d] IV50
    $0e constant CRYP_IV49                      \ [0x0e] IV49
    $0f constant CRYP_IV48                      \ [0x0f] IV48
    $10 constant CRYP_IV47                      \ [0x10] IV47
    $11 constant CRYP_IV46                      \ [0x11] IV46
    $12 constant CRYP_IV45                      \ [0x12] IV45
    $13 constant CRYP_IV44                      \ [0x13] IV44
    $14 constant CRYP_IV43                      \ [0x14] IV43
    $15 constant CRYP_IV42                      \ [0x15] IV42
    $16 constant CRYP_IV41                      \ [0x16] IV41
    $17 constant CRYP_IV40                      \ [0x17] IV40
    $18 constant CRYP_IV39                      \ [0x18] IV39
    $19 constant CRYP_IV38                      \ [0x19] IV38
    $1a constant CRYP_IV37                      \ [0x1a] IV37
    $1b constant CRYP_IV36                      \ [0x1b] IV36
    $1c constant CRYP_IV35                      \ [0x1c] IV35
    $1d constant CRYP_IV34                      \ [0x1d] IV34
    $1e constant CRYP_IV33                      \ [0x1e] IV33
    $1f constant CRYP_IV32                      \ [0x1f] IV32
  [then]


  [ifdef] CRYP_CRYP_IV1LR_DEF
    \
    \ @brief Refer to Section39.6.17: CRYP initialization vector register 0L (CRYP_IV0LR) for details.
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IV95                      \ [0x00] IV95
    $01 constant CRYP_IV94                      \ [0x01] IV94
    $02 constant CRYP_IV93                      \ [0x02] IV93
    $03 constant CRYP_IV92                      \ [0x03] IV92
    $04 constant CRYP_IV91                      \ [0x04] IV91
    $05 constant CRYP_IV90                      \ [0x05] IV90
    $06 constant CRYP_IV89                      \ [0x06] IV89
    $07 constant CRYP_IV88                      \ [0x07] IV88
    $08 constant CRYP_IV87                      \ [0x08] IV87
    $09 constant CRYP_IV86                      \ [0x09] IV86
    $0a constant CRYP_IV85                      \ [0x0a] IV85
    $0b constant CRYP_IV84                      \ [0x0b] IV84
    $0c constant CRYP_IV83                      \ [0x0c] IV83
    $0d constant CRYP_IV82                      \ [0x0d] IV82
    $0e constant CRYP_IV81                      \ [0x0e] IV81
    $0f constant CRYP_IV80                      \ [0x0f] IV80
    $10 constant CRYP_IV79                      \ [0x10] IV79
    $11 constant CRYP_IV78                      \ [0x11] IV78
    $12 constant CRYP_IV77                      \ [0x12] IV77
    $13 constant CRYP_IV76                      \ [0x13] IV76
    $14 constant CRYP_IV75                      \ [0x14] IV75
    $15 constant CRYP_IV74                      \ [0x15] IV74
    $16 constant CRYP_IV73                      \ [0x16] IV73
    $17 constant CRYP_IV72                      \ [0x17] IV72
    $18 constant CRYP_IV71                      \ [0x18] IV71
    $19 constant CRYP_IV70                      \ [0x19] IV70
    $1a constant CRYP_IV69                      \ [0x1a] IV69
    $1b constant CRYP_IV68                      \ [0x1b] IV68
    $1c constant CRYP_IV67                      \ [0x1c] IV67
    $1d constant CRYP_IV66                      \ [0x1d] IV66
    $1e constant CRYP_IV65                      \ [0x1e] IV65
    $1f constant CRYP_IV64                      \ [0x1f] IV64
  [then]


  [ifdef] CRYP_CRYP_IV1RR_DEF
    \
    \ @brief Refer to Section39.6.17: CRYP initialization vector register 0L (CRYP_IV0LR) for details.
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IV127                     \ [0x00] IV127
    $01 constant CRYP_IV126                     \ [0x01] IV126
    $02 constant CRYP_IV125                     \ [0x02] IV125
    $03 constant CRYP_IV124                     \ [0x03] IV124
    $04 constant CRYP_IV123                     \ [0x04] IV123
    $05 constant CRYP_IV122                     \ [0x05] IV122
    $06 constant CRYP_IV121                     \ [0x06] IV121
    $07 constant CRYP_IV120                     \ [0x07] IV120
    $08 constant CRYP_IV119                     \ [0x08] IV119
    $09 constant CRYP_IV118                     \ [0x09] IV118
    $0a constant CRYP_IV117                     \ [0x0a] IV117
    $0b constant CRYP_IV116                     \ [0x0b] IV116
    $0c constant CRYP_IV115                     \ [0x0c] IV115
    $0d constant CRYP_IV114                     \ [0x0d] IV114
    $0e constant CRYP_IV113                     \ [0x0e] IV113
    $0f constant CRYP_IV112                     \ [0x0f] IV112
    $10 constant CRYP_IV111                     \ [0x10] IV111
    $11 constant CRYP_IV110                     \ [0x11] IV110
    $12 constant CRYP_IV109                     \ [0x12] IV109
    $13 constant CRYP_IV108                     \ [0x13] IV108
    $14 constant CRYP_IV107                     \ [0x14] IV107
    $15 constant CRYP_IV106                     \ [0x15] IV106
    $16 constant CRYP_IV105                     \ [0x16] IV105
    $17 constant CRYP_IV104                     \ [0x17] IV104
    $18 constant CRYP_IV103                     \ [0x18] IV103
    $19 constant CRYP_IV102                     \ [0x19] IV102
    $1a constant CRYP_IV101                     \ [0x1a] IV101
    $1b constant CRYP_IV100                     \ [0x1b] IV100
    $1c constant CRYP_IV99                      \ [0x1c] IV99
    $1d constant CRYP_IV98                      \ [0x1d] IV98
    $1e constant CRYP_IV97                      \ [0x1e] IV97
    $1f constant CRYP_IV96                      \ [0x1f] IV96
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM0R_DEF
    \
    \ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM0                 \ [0x00 : 32] CSGCMCCM0
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM1R_DEF
    \
    \ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM1                 \ [0x00 : 32] CSGCMCCM1
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM2R_DEF
    \
    \ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM2                 \ [0x00 : 32] CSGCMCCM2
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM3R_DEF
    \
    \ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM3                 \ [0x00 : 32] CSGCMCCM3
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM4R_DEF
    \
    \ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM4                 \ [0x00 : 32] CSGCMCCM4
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM5R_DEF
    \
    \ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM5                 \ [0x00 : 32] CSGCMCCM5
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM6R_DEF
    \
    \ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM6                 \ [0x00 : 32] CSGCMCCM6
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM7R_DEF
    \
    \ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM7                 \ [0x00 : 32] CSGCMCCM7
  [then]


  [ifdef] CRYP_CRYP_CSGCM0R_DEF
    \
    \ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM0                    \ [0x00 : 32] CSGCM0
  [then]


  [ifdef] CRYP_CRYP_CSGCM1R_DEF
    \
    \ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM1                    \ [0x00 : 32] CSGCM1
  [then]


  [ifdef] CRYP_CRYP_CSGCM2R_DEF
    \
    \ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM2                    \ [0x00 : 32] CSGCM2
  [then]


  [ifdef] CRYP_CRYP_CSGCM3R_DEF
    \
    \ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM3                    \ [0x00 : 32] CSGCM3
  [then]


  [ifdef] CRYP_CRYP_CSGCM4R_DEF
    \
    \ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM4                    \ [0x00 : 32] CSGCM4
  [then]


  [ifdef] CRYP_CRYP_CSGCM5R_DEF
    \
    \ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM5                    \ [0x00 : 32] CSGCM5
  [then]


  [ifdef] CRYP_CRYP_CSGCM6R_DEF
    \
    \ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM6                    \ [0x00 : 32] CSGCM6
  [then]


  [ifdef] CRYP_CRYP_CSGCM7R_DEF
    \
    \ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM7                    \ [0x00 : 32] CSGCM7
  [then]


  [ifdef] CRYP_CRYP_HWCFGR_DEF
    \
    \ @brief CRYP hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000131
    \
    $00 constant CRYP_CFG1                      \ [0x00 : 4] CFG1
    $04 constant CRYP_CFG2                      \ [0x04 : 4] CFG2
    $08 constant CRYP_CFG3                      \ [0x08 : 4] CFG3
    $0c constant CRYP_CFG4                      \ [0x0c : 4] CFG4
  [then]


  [ifdef] CRYP_CRYP_VERR_DEF
    \
    \ @brief CRYP HW Version Register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000022
    \
    $00 constant CRYP_VER                       \ [0x00 : 8] VER
  [then]


  [ifdef] CRYP_CRYP_IPIDR_DEF
    \
    \ @brief CRYP Identification
    \ Address offset: 0x3F8
    \ Reset value: 0x00170011
    \
    $00 constant CRYP_ID                        \ [0x00 : 32] ID
  [then]


  [ifdef] CRYP_CRYP_MID_DEF
    \
    \ @brief CRYP HW Magic ID
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant CRYP_MID                       \ [0x00 : 32] MID
  [then]

  \
  \ @brief CRYP1
  \
  $00 constant CRYP_CRYP_CR             \ CRYP control register
  $04 constant CRYP_CRYP_SR             \ CRYP status register
  $08 constant CRYP_CRYP_DIN            \ The CRYP_DIN register is the data input register. It is 32-bit wide. It is used to enter into the input FIFO up to four 64-bit blocks (TDES) or two 128-bit blocks (AES) of plaintext (when encrypting) or ciphertext (when decrypting), one 32-bit word at a time. To fit different data sizes, the data can be swapped after processing by configuring the DATATYPE bits in the CRYP_CR register. Refer to Section39.3.16: CRYP data registers and data swapping for more details. When CRYP_DIN register is written to the data are pushed into the input FIFO. If CRYPEN = 1, when at least two 32-bit words in the DES/TDES mode have been pushed into the input FIFO (four words in the AES mode), and when at least two words are free in the output FIFO (four words in the AES mode), the CRYP engine starts an encrypting or decrypting process. When CRYP_DIN register is read: If CRYPEN = 0, the FIFO is popped, and then the data present in the Input FIFO are returned, from the oldest one (first reading) to the newest one (last reading). The IFEM flag must be checked before each read operation to make sure that the FIFO is not empty. if CRYPEN = 1, an undefined value is returned. After the CRYP_DIN register has been read once or several times, the FIFO must be flushed by setting the FFLUSH bit prior to processing new data.
  $0C constant CRYP_CRYP_DOUT           \ The CRYP_DOUT register is the data output register. It is read-only and 32-bit wide. It is used to retrieve from the output FIFO up to four 64-bit blocks (TDES) or two 128-bit blocks (AES) of plaintext (when encrypting) or ciphertext (when decrypting), one 32-bit word at a time. To fit different data sizes, the data can be swapped after processing by configuring the DATATYPE bits in the CRYP_CR register. Refer to Section39.3.16: CRYP data registers and data swapping for more details. When CRYP_DOUT register is read, the last data entered into the output FIFO (pointed to by the read pointer) is returned.
  $10 constant CRYP_CRYP_DMACR          \ CRYP DMA control register
  $14 constant CRYP_CRYP_IMSCR          \ The CRYP_IMSCR register is the interrupt mask set or clear register. It is a read/write register. When a read operation is performed, this register gives the current value of the mask applied to the relevant interrupt. Writing 1 to the particular bit sets the mask, thus enabling the interrupt to be read. Writing 0 to this bit clears the corresponding mask. All the bits are cleared to 0 when the peripheral is reset.
  $18 constant CRYP_CRYP_RISR           \ The CRYP_RISR register is the raw interrupt status register. It is a read-only register. When a read operation is performed, this register gives the current raw status of the corresponding interrupt, i.e. the interrupt information without taking CRYP_IMSCR mask into account. Write operations have no effect.
  $1C constant CRYP_CRYP_MISR           \ The CRYP_MISR register is the masked interrupt status register. It is a read-only register. When a read operation is performed, this register gives the current masked status of the corresponding interrupt, i.e. the interrupt information taking CRYP_IMSCR mask into account. Write operations have no effect.
  $20 constant CRYP_CRYP_K0LR           \ CRYP key registers contain the cryptographic keys. In DES/TDES mode, the keys are 64-bit binary values (number from left to right, that is the leftmost bit is bit 1) and named K1, K2 and K3 (K0 is not used). Each key consists of 56 information bits and 8 parity bits. In AES mode, the key is considered as a single 128, 192 or 256 bits long sequence K0K1K2...K127/191/255. The AES key is entered into the registers as follows: for AES-128: K0..K127 corresponds to b127..b0 (b255..b128 are not used), for AES-192: K0..K191 corresponds to b191..b0 (b255..b192 are not used), for AES-256: K0..K255 corresponds to b255..b0. In all cases key bit K0 is the leftmost bit in CRYP inner memory and register bit b0 is the rightmost bit in corresponding CRYP_KxLR key register. For more information refer to Section39.3.17: CRYP key registers. Write accesses to these registers are disregarded when the cryptographic processor is busy (bit BUSY = 1 in the CRYP_SR register)
  $24 constant CRYP_CRYP_K0RR           \ Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
  $28 constant CRYP_CRYP_K1LR           \ Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
  $2C constant CRYP_CRYP_K1RR           \ Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
  $30 constant CRYP_CRYP_K2LR           \ Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
  $34 constant CRYP_CRYP_K2RR           \ Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
  $38 constant CRYP_CRYP_K3LR           \ Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
  $3C constant CRYP_CRYP_K3RR           \ Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
  $40 constant CRYP_CRYP_IV0LR          \ The CRYP_IV0...1(L/R)R are the left-word and right-word registers for the initialization vector (64 bits for DES/TDES and 128 bits for AES). For more information refer to Section39.3.18: CRYP initialization vector registers. IV0 is the leftmost bit whereas IV63 (DES, TDES) or IV127 (AES) are the rightmost bits of the initialization vector. IV1(L/R)R is used only in the AES. Only CRYP_IV0(L/R) is used in DES/TDES. Write access to these registers are disregarded when the cryptographic processor is busy (bit BUSY = 1 in the CRYP_SR register).
  $44 constant CRYP_CRYP_IV0RR          \ Refer to Section39.6.17: CRYP initialization vector register 0L (CRYP_IV0LR) for details.
  $48 constant CRYP_CRYP_IV1LR          \ Refer to Section39.6.17: CRYP initialization vector register 0L (CRYP_IV0LR) for details.
  $4C constant CRYP_CRYP_IV1RR          \ Refer to Section39.6.17: CRYP initialization vector register 0L (CRYP_IV0LR) for details.
  $50 constant CRYP_CRYP_CSGCMCCM0R     \ These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
  $54 constant CRYP_CRYP_CSGCMCCM1R     \ These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
  $58 constant CRYP_CRYP_CSGCMCCM2R     \ These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
  $5C constant CRYP_CRYP_CSGCMCCM3R     \ These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
  $60 constant CRYP_CRYP_CSGCMCCM4R     \ These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
  $64 constant CRYP_CRYP_CSGCMCCM5R     \ These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
  $68 constant CRYP_CRYP_CSGCMCCM6R     \ These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
  $6C constant CRYP_CRYP_CSGCMCCM7R     \ These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
  $70 constant CRYP_CRYP_CSGCM0R        \ Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
  $74 constant CRYP_CRYP_CSGCM1R        \ Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
  $78 constant CRYP_CRYP_CSGCM2R        \ Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
  $7C constant CRYP_CRYP_CSGCM3R        \ Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
  $80 constant CRYP_CRYP_CSGCM4R        \ Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
  $84 constant CRYP_CRYP_CSGCM5R        \ Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
  $88 constant CRYP_CRYP_CSGCM6R        \ Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
  $8C constant CRYP_CRYP_CSGCM7R        \ Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
  $3F0 constant CRYP_CRYP_HWCFGR        \ CRYP hardware configuration register
  $3F4 constant CRYP_CRYP_VERR          \ CRYP HW Version Register
  $3F8 constant CRYP_CRYP_IPIDR         \ CRYP Identification
  $3FC constant CRYP_CRYP_MID           \ CRYP HW Magic ID

: CRYP_DEF ; [then]
